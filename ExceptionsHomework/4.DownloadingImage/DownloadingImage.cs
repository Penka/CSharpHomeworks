using System;
using System.Net;

class DownloadingImage
{
    static void Main(string[] args)
    {
        using (WebClient webClient = new WebClient())
        {
            //string downloadString = Console.ReadLine();
            string downloadURL = "http://www.devbg.org/img/Logo-BASD.jpg";
            try
            {
                webClient.DownloadFile(downloadURL, "downloadedPicture.jpg");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null value entered!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The addres is not valid!");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("Invalid address!");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The requested opperation is not supported!");
            }
        }
    }
}

