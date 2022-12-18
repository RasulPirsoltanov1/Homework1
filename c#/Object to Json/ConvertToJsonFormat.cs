using Newtonsoft.Json;
using Object_to_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_to_Json
{
    class ConvertToJsonFormat
    {
        public static async Task GetTask(User user)
        {
            var result = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.WriteLine(result);
        }
    }
}


