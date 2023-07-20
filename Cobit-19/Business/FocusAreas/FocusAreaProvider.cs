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
            var query = _dbContext.FocusAreas
                .Where(fa => fa.ApplicationUserID == userID);

            return _mapper.Map<IEnumerable<FocusAreaDto>>(query);
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
    }
}
