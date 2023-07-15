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

        public UserManagementProvider(IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = _userManager.Users.ToList();
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);

            return userDtos;
        }

        public async Task<UserDto> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<bool> CreateUser(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user,password);
            return result.Succeeded;
        }

        public async Task<bool> UpdateUser(ApplicationUser user)
        {
            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }
        public async Task<bool> DeleteUser(ApplicationUser user)
        {
            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }
    }
}
