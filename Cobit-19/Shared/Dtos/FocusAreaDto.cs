using Cobit_19.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Cobit_19.Shared.Dtos
{
    public class FocusAreaDto
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime DateCreated { get; set; }
        public UserDto User { get; set; } = default!;
        public ICollection<DesignFactorDto>? DesignFactors { get; set; }
    }
}
