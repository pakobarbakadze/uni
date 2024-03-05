using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace uni.Models
{
    public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<User>(options) { }
}