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
}