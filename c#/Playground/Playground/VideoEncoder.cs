using System;
using System.Threading;


namespace Playground
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Steps to make/use a delegate for an event 
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        public event EventHandler<VideoEventArgs> VideoEncoded; // event defined (delegate defined in EventHandler)

        protected virtual void OnVideoEncoded(Video video) // event raised
=> VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video } );

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
    }



}
