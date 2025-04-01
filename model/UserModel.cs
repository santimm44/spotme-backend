using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spotme_backend.model
{
    public class UserModel
    {
        public string? Email{get;set;}
        public string? Salt {get;set;}
        public string? Hash {get;set;}
    }
}