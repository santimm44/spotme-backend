<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Context
{
    public class DataContext
    {
        public DataContext(DBContextOptions option) : base(options)
    }

    public DbSet<UserModel> Users {get;set;}
=======
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

>>>>>>> af925110411b5a749b6f677393ef693acc620ca0
}