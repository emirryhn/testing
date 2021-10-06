using System.Collections.Generic;
namespace HiringTest.Models
{
    public class UserModel
    {
        private long Id {get;set;}
        private string Name {get;set;}
        private string Password {get;set;}

        public UserModel(long id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}