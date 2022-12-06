using Reflections_Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections_Practica.Models
{
    internal class User:IUser
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public void animal()
        {
            throw new NotImplementedException();
        }
    }
}
