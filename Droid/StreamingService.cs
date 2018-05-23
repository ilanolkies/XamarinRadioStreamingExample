using StreamingExample.Droid;
using Xamarin.Forms;
using Android.Media;

[assembly: Dependency(typeof(StreamingService))]
namespace StreamingExample.Droid
{
	public class StreamingService : IStreaming
	{
		MediaPlayer player;
        string dataSource = "rtsp://your.domain.com/stream.stream";

        bool isPrepared;
      
        public void Play()
        {
			if (!isPrepared)
            {
                if (player == null)
                    player = new MediaPlayer();
                else
                    player.Reset();

                player.SetDataSource(dataSource);
                player.PrepareAsync();
            }

            player.Prepared += (sender, args) =>
            {
                player.Start();
                isPrepared = true;
            };
        }

		public void Pause()
		{
            player.Pause();
		}

		public void Stop()
		{
            player.Stop();
            isPrepared = false;
		}
	}
}
