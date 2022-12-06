using homework_mini_project.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace homework_mini_project.Models
{
    internal class User
    {
        //  User class
        //- Id
        //- Statuses - status obyektlərini özündə saxlayan bir list olacaq.
        //- Username
        //- ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.
        //- GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək
        //həmin id-li statusu tapıb geriyə qaytaracaq.
        //- GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.
        //- FilterStatusByDate() - parametr olaraq bir nullable id və DateTime tipindən
        //bir tarix qəbul edəcək göndərilən id-li user-in həmin tarixdən sonra paylaşılan
        //bütün statuslarını geriyə qaytaracaq, göndərilən tarixdən sonra heç bir status
        //paylaşılmayıbsa NotFoundException baş verəcək.
        //ps: Username olmadan user obyekti yaratmaq olmaz.
        public int Id { get; set; }
        List<Status> Statuses;
        private Status status;

        public string Username { get; set; }
        public User(string username)
        {
            Username = username;
            Statuses = new List<Status>();
        }
        public void ShareStatus(Status obj)
        {
            Statuses.Add(obj);
        }
        public void getStatuses()
        {
            foreach (var stat in Statuses)
            {
                Console.WriteLine(stat.GetStatusInfo());
            }
        }
        public Status GetStatusById(int? id)
        {
            Status result = Statuses.Find(status => status.Id == id);
            return result;
        }
        public List<Status> GetAllStatuses()
        {
            return Statuses;
        }
        public List<Status> FilterStatusByDate(int id,DateTime date)
        {
            if(Statuses.FindAll(s => s.Id == id && s.SharedDate.Ticks <= date.Ticks) == null)
            {
                throw new NotFoundException("data not found");
            }
            return Statuses.FindAll(s=>s.Id==id&&s.SharedDate.Ticks<=date.Ticks);
        }

    }
}
