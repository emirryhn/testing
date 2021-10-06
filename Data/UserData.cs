using System;
using System.Collections.Generic;
using HiringTest.Models;
using HiringTest.Data;
using Microsoft.AspNetCore.Mvc;

namespace HiringTest.Data
{
    public class UserData
    {    

        public string GetUser()
        {
            UserModel user = new UserModel();
            var users = user.UserModels();

            return "okkk";
        }

        // public UserModel registerUser(UserModel userModel)
        // {
            
        // }
        
    }
    
}