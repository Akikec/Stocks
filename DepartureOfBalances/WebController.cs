using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartureOfBalances
{
    class WebController
    {

        string _link;
        string _filename;
        bool _needChange = false;
        bool _needLogin = false;
        string _login, _password, _autorizeLink;

        public WebController(string link,string filename)
        {
            _link = link;
            _filename = filename;
        }

        public WebController(string link, string filename, bool needChange)
        {
            _link = link;
            _filename = filename;
            _needChange = needChange;
        }

        public WebController(string link, string filename, bool needLogin, string login, string password, string autorizeLink)
        {
            _link = link;
            _filename = filename;
            _needLogin = needLogin;
            _autorizeLink = autorizeLink;
            _login = login;
            _password = password;
        }

        public WebController(string link, string filename, bool needChange ,bool needLogin , string login , string password, string autorizeLink)
        {
            _link = link;
            _filename = filename;
            _needChange = needChange;
            _needLogin = needLogin;
            _autorizeLink = autorizeLink;
            _login = login;
            _password = password;
        }


        public bool DownloadFile()
        {
            if (!_needChange && !_needLogin)
            {
                try
                {
                    DownloadFF();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else if (_needChange && !_needLogin)
            {
                try
                {
                    DownloadTF();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else if(!_needChange && _needLogin)
            {
                DownloadFT();

                try
                {
                    // Вернуть

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    DownloadTT();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        void DownloadFF()
        { // Скачиваем напрямую
            System.Net.WebClient mainWC = new System.Net.WebClient();
            mainWC.DownloadFile(_link, _filename);
            mainWC.Dispose();
            
        }

        void DownloadTF()
        { // Редактирование файла
            System.Net.WebClient mainWC = new System.Net.WebClient();
            mainWC.DownloadFile(_link, _filename);
            mainWC.Dispose();

        }

        void DownloadFT()
        { // Логинимся
            if(_link[0] == 'f' && _link[1] == 't')
            {
                System.Net.FtpWebRequest request = (System.Net.FtpWebRequest)System.Net.WebRequest.Create(_link);
                request.Method = System.Net.WebRequestMethods.Ftp.DownloadFile;
                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new System.Net.NetworkCredential(_login, _password);

                System.Net.FtpWebResponse response = (System.Net.FtpWebResponse)request.GetResponse();

                System.IO.Stream stream = response.GetResponseStream();
                List<byte> list = new List<byte>();
                int b;
                while ((b = stream.ReadByte()) != -1)
                    list.Add((byte)b);
                System.IO.File.WriteAllBytes(_filename, list.ToArray());
                response.Close();
            }else
            {
                // ЗАПОЛНИТЬ!
            }
        }

        void DownloadTT()
        { // Логинимся и редактируем
            System.Net.WebClient mainWC = new System.Net.WebClient();
            mainWC.DownloadFile(_link, _filename);
            mainWC.Dispose();

        }

    }
}
