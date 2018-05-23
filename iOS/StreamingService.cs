using StreamingExample.iOS;
using Xamarin.Forms;
using AVFoundation;
using Foundation;

[assembly: Dependency(typeof(StreamingService))]
namespace StreamingExample.iOS
{
	public class StreamingService : IStreaming
	{
		AVPlayer player;
		bool isPrepared;
		string dataSource = "http://your.domain.com/stream";

        public void Play()
        {
			AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.Playback);
			if (!isPrepared || player == null)
                player = AVPlayer.FromUrl(NSUrl.FromString(dataSource));

			isPrepared = true;
            player.Play();
        }

		public void Pause()
		{
            player.Pause();
		}
      
		public void Stop()
		{
            player.Dispose();
            isPrepared = false;
		}
	}
}
