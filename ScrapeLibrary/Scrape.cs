using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            WebClient client = new WebClient(); // DownloadString()是一个下载网页的方法，位于System.Net命名空间的WebClient类中
            return GetWebpage(url);
        }
        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(@"C:\Users\lx389\Documents\reply.txt", reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string content= client.DownloadString(url);
            content += "\n\n\nTHAT'S ALL FORKS !";
            return content;
        }
    }
}
