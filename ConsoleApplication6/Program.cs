using ConsoleApplication6.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static void Main(string[] args)
        {
            string url = "https://randomuser.me/api/?results=10";

            ServiceUser serviceUser = new ServiceUser(url);

            Users users = serviceUser.GetUsers();

            for (int i = 0; i < users.results.Count; i++)
            {
                //results user = users.results[i];
                users.results[i].PrintInfo();
                Console.WriteLine("---------------------");
            }
        }
    }
}
