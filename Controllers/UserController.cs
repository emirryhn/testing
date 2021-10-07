using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HiringTest.Data;
using HiringTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;

namespace HiringTest.Controllers
{
    [ApiController]

    public class UserController : Controller
    {
        //======================hardcoded values========================
        UserData userData = new UserData();
        
        [HttpGet ("user/all")]
        public IActionResult GetAllUser()
        {
            var user = userData.GetUser();
            if(user == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpPost("user/add")]

        public IActionResult NewUser([FromBody] UserModel userModel)
        {
            userData.AddNewUser(userModel);
            return Ok();
        }

        //=========================database value=======================
        

    }

}
