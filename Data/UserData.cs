using System.Collections.Generic;
using HiringTest.Models;

namespace HiringTest.Data
{
    public class UserData
    {

        // List<UserModel> userModels = new List<UserModel>();
        UserModel user;
        public string login(string username, string password)
        {
            //code
            username = "Dono";
            password = "12345";

            user = new UserModel(1,username,password);

            return "ok";

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