using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StramRead_and_SreamWrite.Models
{
    internal class Post
    {
        public int userId{ get; set; }
        public int id{ get; set; }
        public string Title{ get; set; }
        public bool completed { get; set; }
    }
}
