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
        
        [HttpGet]
        public IActionResult userLogin()
        {
            Console.WriteLine("Enter username : ");
            string name  = Console.ReadLine();

            Console.WriteLine("Enter password : ");
            string password  = Console.ReadLine();

            userData.login(name, password);
            
            if(name != "Dono")
            {
                return BadRequest();
            }
            else{
                Console.WriteLine("berhasil");
                return Ok();
            }
        }

    }

}
