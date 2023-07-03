using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Business.Audits
{
    public class AuditProvider : AppProvider<AuditModel, int>
    {
        private readonly IMapper _mapper;
        protected AuditProvider(IMapper mapper, AppDbContext dbContext) : base(dbContext)
        {
            _mapper = mapper;
        }

        public async Task<AuditDto> getAsync(int id)
        {
            var quary = _dbContext.Audits
                .Where(a => a.ID == id);
            return await _mapper.ProjectTo<AuditDto>(quary).FirstAsync();
        }
    }
}
