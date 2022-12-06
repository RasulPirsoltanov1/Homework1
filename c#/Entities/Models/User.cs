using Entities.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User:BaseEntity
    {
        private static int _id = 0;
        public List<Status> Statuses;
        public string UserName{ get; set; }
        public User(string username)
        {
            Id = ++_id;
            UserName = username;
            Statuses = new List<Status>();
        }
    }
}
