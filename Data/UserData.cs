using System;
using System.Collections.Generic;
using HiringTest.Models;
using HiringTest.Data;
using Microsoft.AspNetCore.Mvc;

namespace HiringTest.Data
{
    public class UserData
    {

        // List<UserModel> userModels = new List<UserModel>();
        UserModel user;
        public UserModel login(string username, string password)
        {
            //code
            UserModel user = new UserModel();

            user.Name = "Dono";
            user.Password = "12345";

            // Console.WriteLine("Enter username : ");
            // string name  = Console.ReadLine();

            // Console.WriteLine("Enter password : ");
            // string pass  = Console.ReadLine();
            
            // if(name != "Dono")
            // {
            //     Console.WriteLine("error");
            // }
            // else{
            //     Console.WriteLine("berhasil");
            // }
                   
            return user;

        }

        // public List<UserModel> getAllUser()
        // {
        //     return  ;
        // }

        public UserModel registerUser(UserModel userModel)
        {
            // code

            
            return userModel ;
        }
        
    }
    
}