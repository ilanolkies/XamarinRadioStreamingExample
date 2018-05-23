using System;
namespace StreamingExample
{
    public class StreamingViewModel
    {
		public bool IsPlaying { get; set; } = false;

        public void Play()
		{
			IsPlaying = true;
		}   

		public void Pause()
		{
			IsPlaying = false;
		}

        public void Stop()
		{
			IsPlaying = false;
		}
    }
}
