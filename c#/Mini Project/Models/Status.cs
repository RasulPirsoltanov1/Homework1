using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Models
{
    internal class Status
    {
        //-Id
        //- Title
        //- Content
        //- SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
        //- GetStatusInfo() -geriyə "Title: test title - Content: test content - shared 5 seconds ago"(burda qeyd olunan "shared
        //5 seconds ago" hissəsi dinamik olmalıdı status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; } = DateTime.Now;
        public Status(string title,string content)
        {
            Content= content;
            Title= title;
            Id++;
        }
        public string GetStatusInfo()
        {
            return $"Title: {Title} - Content: {Content} - {(DateTime.Now.Ticks - SharedDate.Ticks)/10000000} seconds ago";
        }
    }
}
