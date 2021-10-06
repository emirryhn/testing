using System;
using System.Collections.Generic;

namespace HiringTest.Models
{
    public class UserModel
    {
        public long Id {get;set;}
        public string Name {get;set;}
        public string Password {get;set;}

        public List<UserModel> UserModels()
        {
            return new List<UserModel>
            {
                new UserModel() {Id=1, Name="User 1", Password="12345"},
                new UserModel() {Id=1, Name="User 2", Password="12345"},
                new UserModel() {Id=1, Name="User 3", Password="12345"},
                new UserModel() {Id=1, Name="User 4", Password="12345"}                
            };
        }
    }
}