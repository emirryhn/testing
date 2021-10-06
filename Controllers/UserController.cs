using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HiringTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;

namespace HiringTest.Controllers
{
    [ApiController]

    public class UserController : Controller
    {

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

    }

}
