using Entities.Models;
using Services.Expections;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Implementations
{
    public class UserService : IUserService
    {
        public Status GetStatusById(int id, User user)
        {
            Status status=user.Statuses.FirstOrDefault(item=>item.Id==id);
            if (status==null)
            {
                throw new NotFoundExpection();
            }
            return status;
        }
    }
}
