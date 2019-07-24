using System;


namespace Playground
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }



}
