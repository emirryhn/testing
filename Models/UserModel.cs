using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringTest.Models
{
    public class UserModel
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public string Password {get;set;}

        // public UserModel(long id, string name, string password)
        // {
        //     Id = id;
        //     Name = name;
        //     Password = password;
        // }
    }
}