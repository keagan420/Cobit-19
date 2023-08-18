using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Business.ObjectiveAudits
{
    public class ObjectiveAuditProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private static readonly object _lock = new object();
        public ObjectiveAuditProvider(IMapper mapper, AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // Get objectiveAudits by audit id
        public IList<ObjectiveAuditDto> getAll(int auditId)
        {
            var quary = _dbContext.ObjectiveAudits
                .Where(a => a.AuditID == auditId)
                .Include(a => a.Objective)
                .ToList();

            return _mapper.Map<IList<ObjectiveAuditDto>>(quary);
        }

        // Get objectiveAudits by objectiveAudit id
        public ObjectiveAuditDto getByID(int objectiveAuditID)
        {
            var quary = _dbContext.ObjectiveAudits
                .Where(a => a.ID == objectiveAuditID)
                .Include(a => a.ObjectiveAuditMembers)
                .FirstOrDefault();

            return _mapper.Map<ObjectiveAuditDto>(quary);
        }

        // Get the members of the objectiveAudit
        public IList<ObjectiveAuditMemberDto> getMembersByObjectiveAuditID(int objectiveAuditID)
        {
            var quary = _dbContext.ObjectiveAuditMembers
                .Where(a => a.ObjectiveAuditID == objectiveAuditID)
                .Include(a => a.ApplicationUser)
                .ToList();

            return _mapper.Map<IList<ObjectiveAuditMemberDto>>(quary);
        }

        // Set selected objectiveAudits
        // TODO Implement status functionality
        public async Task<ObjectiveAuditDto> updateAsync(ObjectiveAuditEditorDto objectiveAuditEditor)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Find(objectiveAuditEditor.ID);

            if (objectiveAudit == null)
            {
                return null;
            }

            _mapper.Map(objectiveAuditEditor, objectiveAudit);

            if (objectiveAudit.Status == AuditStatus.InProgress)
            {
                objectiveAudit.DateCompleted = null;
            }
            else if (objectiveAudit.Status == AuditStatus.Completed)
            {
                objectiveAudit.DateCompleted = DateTime.Now;
            }

            _dbContext.ObjectiveAudits.Update(objectiveAudit);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ObjectiveAuditDto>(objectiveAudit);
        }

        // Determines of a user is a member of an objectiveAudit
        public bool isMember(ObjectiveAuditMemberEditorDto objectiveAuditMemberDto)
        {
            return _dbContext.ObjectiveAuditMembers.Any(a => 
                a.ObjectiveAuditID == objectiveAuditMemberDto.ObjectiveAuditID 
                && a.ApplicationUserID == objectiveAuditMemberDto.ApplicationUserID);
        }

        public async Task<ObjectiveAuditMemberDto> addMember(ObjectiveAuditMemberEditorDto memberEditorDto)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Find(memberEditorDto.ObjectiveAuditID);
            if (objectiveAudit == null)
            {
                return null;
            }

            var objectiveAuditMember = _mapper.Map<ObjectiveAuditMembersModel>(memberEditorDto);
            await _dbContext.ObjectiveAuditMembers.AddAsync(objectiveAuditMember);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ObjectiveAuditMemberDto>(objectiveAuditMember); ;
        }

        public async Task<ObjectiveAuditMemberDto> deleteMember(ObjectiveAuditMemberEditorDto objectiveAuditMemberDto)
        {
            if (!isMember(objectiveAuditMemberDto))
            {
                return null;
            }

            var objectiveAuditMemberModel = _dbContext.ObjectiveAuditMembers.Where(a => a.ObjectiveAuditID == objectiveAuditMemberDto.ObjectiveAuditID && a.ApplicationUserID == objectiveAuditMemberDto.ApplicationUserID).First();

            _dbContext.ObjectiveAuditMembers.Remove(objectiveAuditMemberModel);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ObjectiveAuditMemberDto>(objectiveAuditMemberModel); ;
        }
    }
}
