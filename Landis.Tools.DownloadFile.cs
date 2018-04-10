using System;
using System.Net;
using System.IO;
namespace Landis.Tools.DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Submit a url to download from followed by what you want the downloaded file's name to be.");
                throw new Exception("Program requires two inputs.");
            }
            var downloader = new WebClient();

            downloader.DownloadFile(args[0], args[1]);

            if (File.Exists(args[1]))
            {
                Console.WriteLine("File download successful");
            }
            else
            {
                Console.WriteLine("File download failed.");
                throw new Exception("Download was not successful");
            }

        }
    }
}
