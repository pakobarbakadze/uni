using AutoMapper;
using Microsoft.EntityFrameworkCore;
using uni.Models;

namespace uni.Services.UserServices
{
    public class UserService(DataContext context, IMapper mapper) : IUserService
    {
        private readonly DataContext _context = context;
        private readonly IMapper _mapper = mapper;

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var serviceResponse = new ServiceResponse<List<User>>();

            var users = await _context.Users.ToListAsync();
            serviceResponse.Data = users;

            return serviceResponse;
        }

        public async Task<ServiceResponse<User>> GetUser(int id)
        {
            var serviceResponse = new ServiceResponse<User>();

            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                serviceResponse.Data = user;
            }
            else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "User doesnt exist";
            }

            return serviceResponse;
        }
    }
}