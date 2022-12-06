using Entities.Models;
using Services.Expections;
using Services.Services.Implementations;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace at_classroom_task.Controllers
{
    public class UserController
    {
        private readonly IUserService userService;
        public UserController()
        {
            userService=new UserService();
        }
        public void GetById(int id)
        {
            User newUser = new User("user1");
            try
            {
                userService.GetStatusById(id, newUser);
            }
            catch (NotFoundExpection ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
