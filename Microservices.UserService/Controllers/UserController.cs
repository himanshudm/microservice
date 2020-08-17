using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.UserService.Db;
using Microservices.UserService.Db.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DBContext dB;
        public UserController()
        {
            dB = new DBContext();
        }
        // GET: api/Users
        [HttpGet]
        public IEnumerable<UserView> Get()
        {
            return (from u in dB.Users
                    select new UserView
                    {
                        Name=u.Name,
                        Age=u.Age,
                        Email =u.Email

                    }).ToList();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public UserView Get(int id)
        {
            return (from u in dB.Users
                    where u.UserId == id
                    select new UserView
                    {
                        Name = u.Name,
                        Age = u.Age,
                        Email = u.Email

                    }).FirstOrDefault();
        }

        // POST: api/Users
        [HttpPost]
        public IActionResult Post([FromBody] Users model)
        {
            try
            {
                dB.Users.Add(model);
                dB.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,ex);

            }
        }

    }
}
