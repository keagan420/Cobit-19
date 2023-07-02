using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<AuditModel> Audit { get; set; }
    }
}
