using Entities.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Status:BaseEntity
    {
        private static int _id;
        public string Title{ get; set; }
        public string Content { get; set; }
        public DateTime ShareDate{ get; set; }
        public Status(string title,string content)
        {
            Title = title;
            Content = content;
            _id++;
            Id= _id;
            ShareDate= DateTime.Now;
        }
    }
}
