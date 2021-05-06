using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApp2FirstTask
{
    
        
    class Program
    {
        static void Main(string[] args)
        {
            String JsonString = File.ReadAllText("C:\\Users\\Rositsa Ruseva\\Desktop\\QA testing\\xoomworks\\json\\input.json");
            List<MovieStar> info = JsonConvert.DeserializeObject<List<MovieStar>>(JsonString);
            
            StringBuilder sb = new StringBuilder();
            foreach (var item in info)
            {
                sb.AppendLine(item.Name + " " + item.Surname);
                sb.AppendLine(item.Sex);
                sb.AppendLine(item.Nationality);
                DateTime now = DateTime.Today;
                DateTime bday = Convert.ToDateTime(item.DateOfBirth);
                int age = now.Year - bday.Year;
                if (bday > now.AddYears(-age))
                {
                    age--;
                }
                sb.AppendLine(age.ToString());
                sb.AppendLine(Environment.NewLine);
            }
            Console.WriteLine(string.Format(string.Join(" ",sb)));
        }
    }
}
