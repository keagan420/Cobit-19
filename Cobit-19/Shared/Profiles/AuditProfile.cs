using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;

namespace Cobit_19.Shared.Profiles
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditModel, AuditDto>().ReverseMap();
            CreateMap<AuditDto, AuditEditorDto>();
            CreateMap<AuditEditorDto, AuditModel>().ReverseMap();
        }
    }
}
