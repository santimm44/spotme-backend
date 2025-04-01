 
using Microsoft.EntityFrameworkCore;
using spotme_backend.Models;
namespace spotme_backend.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        {
        }
        public DbSet<UserModel> User { get; set;}
    }
}