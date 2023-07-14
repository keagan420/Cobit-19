using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Cobit_19.Business.Admin
{
    public class UserManagementProvider
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUser> _roleManager;

        public UserManagementProvider(IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<ApplicationUser> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserDto GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateUser()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser()
        {
            throw new NotImplementedException();
        }
        public bool DeleteUser()
        {
            throw new NotImplementedException();
        }
    }
}
