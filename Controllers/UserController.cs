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
    [Route ("api/[controller]")]

    public class UserController : Controller
    {

        UserData userData = new UserData();
        
        [HttpGet]
        public IActionResult GetAllUser()
        {
            userData.GetUser();
            return Ok();
        }

    }

}
