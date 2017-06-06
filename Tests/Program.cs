using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Tests
{
    class Program
    {
        public static string sendPost(string data, ref CookieContainer cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://iek.ru/partner/index.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] sentData = Encoding.UTF8.GetBytes(data);
            request.ContentLength = sentData.Length;
            request.CookieContainer = cookies;
            Stream sendStream = request.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();
            WebResponse response = request.GetResponse();
            return (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }

        public static string sendGet(string url, ref CookieContainer cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookies;
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            return (new StreamReader(stream)).ReadToEnd();
        }

        public static List<byte> getFile(string url, ref CookieContainer cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookies;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            List<byte> result = new List<byte>();
            BinaryReader binaryReader = new BinaryReader(stream);
            result.AddRange(binaryReader.ReadBytes((int)response.ContentLength));
            return result;
        }

        static void Main(string[] args)
        {
            CookieContainer cookies = new CookieContainer();
            /* Для некоторых сайтов, для авторизации нужно получить Cookie,
               для вашего не нужно, поэтому в целях скорости работы не используем.
               sendGet(@"http://notabenoid.org/", ref cookies); */

            //https://iek.ru/partner/index.php?login=yes

            //https://iek.ru/partner/catalog/excel.php?excel=Y

            string data = @"";
            sendPost(data, ref cookies);
            sendGet(@"https://iek.ru/partner/catalog/excel.php?excel=Y", ref cookies);
            List<byte> test = new List<byte>();
            test = getFile(@"https://iek.ru/partner/catalog/excel.php?excel=Y", ref cookies);
            /* Указываем путь и расширение для записи. */
            File.WriteAllBytes(@"E:\file", test.ToArray());
            Console.ReadKey();
        }
    }
}
