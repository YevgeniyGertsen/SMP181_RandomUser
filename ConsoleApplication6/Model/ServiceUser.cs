using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.Model
{
    public class ServiceUser
    {
        public ServiceUser(string Url)
        {
            this.Url = Url;
        }

        public string Url { get; set; }

        /// <summary>
        /// Метод возвращает список пользователей
        /// </summary>
        /// <returns></returns>
        public Users GetUsers()
        {
            string json = GetJsonUser();
            return JsonConvert.DeserializeObject<Users>(json);
        }

        private string GetJsonUser()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }
    }
}
