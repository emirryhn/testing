using System;
using System.Collections.Generic;
using HiringTest.Models;
using HiringTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HiringTest.Data
{
    public class UserData
    {    
        // readonly private string MyDbConnectionString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["MyDbConnectionString"];


        //========================hardcoded value=======================
        public string GetUser()
        {
            UserModel user = new UserModel();
            var users = user.UserModels();
            Console.WriteLine(users);
            return "okkk";
        }

        public string AddNewUser(UserModel userModel)
        {

            return "user added";
        }

        //=========================database value============================

        public string Register()
        {
            
            return "";
        }
    }
    
}