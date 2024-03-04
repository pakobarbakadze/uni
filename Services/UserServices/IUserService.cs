using uni.Dtos;
using uni.Entities;
using uni.Models;

namespace uni.Services.UserServices
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();
        Task<ServiceResponse<User>> GetUser(int id);
        Task<ServiceResponse<User>> AddUser(AddUserDto addUserDto);
    }
}