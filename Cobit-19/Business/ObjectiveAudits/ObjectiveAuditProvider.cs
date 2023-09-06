using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

        public string getAuditJSON(int objectiveAuditID)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.Where(objAudit => objAudit.ID == objectiveAuditID).FirstOrDefault();

            var objectiveAuditJSON = objectiveAudit.UserAuditObject;

            return objectiveAuditJSON;
        }

        public void updateAuditJSON(int objectiveAuditID, string auditJSON)
        {
            var objectiveAudit = _dbContext.ObjectiveAudits.FirstOrDefault(objAudit => objAudit.ID == objectiveAuditID);

            if (objectiveAudit != null)
            {
                objectiveAudit.UserAuditObject = auditJSON;

                _dbContext.SaveChanges();
            }
        }

        public List<SubComponentDto> getSubComponents(ComponentDto component)
        {
            if (component.subComponents == null)
            {
                return null;
            }
            else
            {
                return component.subComponents;
            }

        }

        public ComponentDto getComponent(FullObjectiveAuditDto objectiveAudit,int componentID)
        {
            if (objectiveAudit.components[componentID] == null)
            {
                return null;
            }
            else
            {
                return objectiveAudit.components[componentID];
            }
        }

        public List<subComponentQuestionDto> GetSubComponentMLevelQuestions(SubComponentDto subComp)
        {
            var subCompQuestions = subComp.subComponentQuestions;

            var query = subCompQuestions.Where(question => question.questionType.Contains("Maturity Level"));
            var MLevelQuestios = query.ToList();

            if (MLevelQuestios.Count > 0)
            {
                return MLevelQuestios;
            }
            else
            {
                return null;
            }
        }

        public List<subComponentQuestionDto> GetSubComponentInputQuestions(SubComponentDto subComp)
        {
            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question => 
                question.questionType.Equals("Input"));

            var inputQuestions = query.ToList();

            if (inputQuestions.Count > 0)
            {
                return inputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<subComponentQuestionDto> GetSubComponentOutputQuestions(SubComponentDto subComp)
        {
            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question =>
                question.questionType.Equals("Output"));

            var outputQuestions = query.ToList();

            if (outputQuestions.Count > 0)
            {
                return outputQuestions;
            }
            else
            {
                return null;
            }
        }

        public List<subComponentQuestionDto> GetSubComponentRelatedGuidanceQuestions(SubComponentDto subComp)
        {
            var SubCompQuestions = subComp.subComponentQuestions;

            var query = SubCompQuestions.Where(question =>
                question.questionType.Equals("Related Guidance"));

            var relatedGuidanceQuestions = query.ToList();

            if (relatedGuidanceQuestions.Count > 0)
            {
                return relatedGuidanceQuestions; 
            }
            else
            {
                return null;
            }
        }

        public int GetAnswerAchievement(int answerValue)
        {
            if (answerValue <= 2)
            {
                return 0;
            }
            else if (answerValue > 2 && answerValue <= 5)
            {
                return 1;
            }
            else if (answerValue > 5 && answerValue <= 8)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
