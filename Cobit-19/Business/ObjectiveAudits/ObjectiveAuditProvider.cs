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
        public async Task<IEnumerable<ObjectiveAuditDto>> getAllAsync(int auditId)
        {
            var quary = await _dbContext.ObjectiveAudits
                .Where(a => a.AuditID == auditId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<ObjectiveAuditDto>>(quary);
        }

        // Set selected objectiveAudits
        public async Task<ObjectiveAuditDto> updateSelected(ObjectiveAuditEditorDto objectiveAuditEditor)
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

            lock (_lock)
            {
                _dbContext.ObjectiveAudits.Update(objectiveAudit);
                _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<ObjectiveAuditDto>(objectiveAudit);
        }

        public async Task<ObjectiveAuditMemberDto> addMember(int objectiveAuditID, ObjectiveAuditMemberEditorDto memberEditorDto)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Find(objectiveAuditID);
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
            var objectiveAuditMemberModel = _dbContext.ObjectiveAuditMembers.Where(a => a.ObjectiveAuditID == objectiveAuditMemberDto.ObjectiveAuditID && a.ApplicationUserID == objectiveAuditMemberDto.ApplicationUserID).First();
            if (objectiveAuditMemberModel == null)
            {
                return null;
            }
            _dbContext.ObjectiveAuditMembers.Remove(objectiveAuditMemberModel);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<ObjectiveAuditMemberDto>(objectiveAuditMemberModel); ;
        }
    }
}
