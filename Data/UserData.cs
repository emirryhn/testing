using System;
using System.Collections.Generic;
using HiringTest.Models;
using HiringTest.Data;
using Microsoft.AspNetCore.Mvc;

namespace HiringTest.Data
{
    public class UserData
    {
        UserModel userModel;
        // List<UserModel> userModels = new List<UserModel>();
        private List<UserModel> UserModels()
        {
            return new List<UserModel>
            {
                new UserModel() {Id=1, Name="User 1", Password="12345"},
                new UserModel() {Id=1, Name="User 2", Password="12345"},
                new UserModel() {Id=1, Name="User 3", Password="12345"},
                new UserModel() {Id=1, Name="User 4", Password="12345"}                
            };
        }

        public string GetUser()
        {
            var users = UserModels();
            return "ok";
        }

        // public UserModel registerUser(UserModel userModel)
        // {
            
        // }
        
    }
    
}