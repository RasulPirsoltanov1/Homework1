using Mini_Project.Expections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Models
{
    internal class User
    {
        //User class
        //- Id
        //- Statuses - status obyektlərini özündə saxlayan bir list olacaq.
        //- Username
        //- ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.
        public static int userid;
        private int Id;
        private Status[] Statuses;
        public string Username { get; set; }
        public User(string username)
        {
            userid++;
            Username = username;
            Statuses = new Status[0];
        }
        public void ShareStatus(Status status)
        {
            Array.Resize(ref Statuses, Id + 1);
            Statuses[Id] = status;
            Id++;
        }
        public void GetStatus()
        {
            foreach (var stat in Statuses)
            {
                Console.WriteLine(Username + stat.GetStatusInfo());
            }
        }
        //GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək həmin id-li
        //statusu tapıb geriyə qaytaracaq.
        public Status GetStatusById(int id)
        {
            return Statuses[id];
        }
        public Status[] GetAllStatuses()
        {
            return Statuses;
        }
        public string FilterStatusByDate(DateTime time)
        {
            bool chechk = true;
            for (int i = 0; i < Statuses.Length; i++)
            {
                if (time < Statuses[i].SharedDate)
                {
                    chechk = false;
                    return $"{Statuses[i].SharedDate}";
                }
            }
            throw new NotFoundException("Data not found!");
        }
    }
}
