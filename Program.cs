using System.Net;
using System.Text;

namespace FTP_exampl_30_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // смотреть урок от 30-11-2023 
            // нужно зайти на бесплатный ftp сервер и получить письмо на почту  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("", File.ReadAllText(""));
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            //считать ответ
            byte[] buffer = new byte[1024];
            response.GetResponseStream().Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(content);
        }
    }
}