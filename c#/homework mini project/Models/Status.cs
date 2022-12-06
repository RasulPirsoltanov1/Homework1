using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace homework_mini_project.Models
{
    internal class Status
    {
        public int Id { get; set; }
        private static int _id;
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
        public Status(string title,string content)
        {
            Id = _id;
            _id++;
            Title = title;
            Content = content;
            SharedDate = DateTime.Now;
        }
        public string GetStatusInfo()
        {
            return $"Id: {Id} -Title: {Title} -Content: {Content} -Shared {(DateTime.Now.Ticks - SharedDate.Ticks)/10000000} second ago";
        }
        
    }
}
