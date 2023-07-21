using AutoMapper;
using Cobit_19.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using Cobit_19.Data;
using Cobit_19.Shared.Enums;
using Cobit_19.Data.Models;

namespace Cobit_19.Business.FocusAreas
{
    public class FocusAreaProvider
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public FocusAreaProvider(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public IEnumerable<FocusAreaDto> GetFocusAreasByUserID(string userID)
        {
            var subscriptions = _dbContext.Subscriptions
                .Where(sub => sub.ApplicationUserID == userID)
                .Select(sub => sub.FocusAreaID)
                .ToList();

            var focusAreaList = _dbContext.FocusAreas
                .Where(fa => subscriptions.Contains(fa.ID))
                .ToList();

            return _mapper.Map<IEnumerable<FocusAreaDto>>(focusAreaList);
        }

        public IEnumerable<AuditDto> GetAuditsForFocusAreaByUserID(string userID, int focusAreaID)
        {
            var query = _dbContext.Audits
                .Where(audit => audit.ApplicationUserID == userID && audit.FocusAreaID == focusAreaID)
                .Include(audit => audit.FocusArea);

            return _mapper.Map<IEnumerable<AuditDto>>(query);
        }

        public IEnumerable<FocusAreaDto> GetAllFocusAreas()
        {
            var query = _dbContext.FocusAreas.ToList();

            return _mapper.Map<IEnumerable<FocusAreaDto>>(query);
        }

        public IEnumerable<AuditDto> GetAllAuditsForFocusArea(int focusAreaID)
        {
            var query = _dbContext.Audits.Where(audit => audit.FocusAreaID == focusAreaID).ToList();

            return _mapper.Map<IEnumerable<AuditDto>>(query);
        }

        public AuditStatus GetFocusAreaCompletionStatus(string userID, int focusAreaID)
        {
            var audit = GetLastAuditForFocusAreaByUserID(userID, focusAreaID);
            return audit.Status;
        }

        public bool GetFocusAreaActivityStatus(string userID, int focusAreaID)
        {
            var audits = GetAuditsForFocusAreaByUserID(userID, focusAreaID);
            bool focusAreaActivityStatus = false;

            foreach(var audit in audits)
            {
                if (audit.Status == AuditStatus.InProgress || audit.Status == AuditStatus.NotStarted)
                {
                    focusAreaActivityStatus = true;
                }
            }

            return focusAreaActivityStatus;
        }

        public AuditDto GetLastAuditForFocusAreaByUserID(string userID, int focusAreaID)
        {
            var query = _dbContext.Audits
                .Where(audit => audit.FocusAreaID == focusAreaID && audit.ApplicationUserID == userID)
                .OrderByDescending(audit => audit.DateCreated)
                .FirstOrDefault();
                           
            return _mapper.Map<AuditDto>(query);
        }

            
    }
}
