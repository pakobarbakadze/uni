using uni.Models;

namespace uni.Services.UserServices
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();
        Task<ServiceResponse<User>> GetUser(int id);
    }
}