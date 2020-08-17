using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.UserService.Db.Entities
{
    public class UserView
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

}
