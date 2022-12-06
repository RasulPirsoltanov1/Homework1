using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Services.Services.Interfaces
{
    public interface IUserService
    {
        Status GetStatusById(int id,User user);
    }
}
