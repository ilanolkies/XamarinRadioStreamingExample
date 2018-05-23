using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace StreamingExample
{
	public class StreamingViewModel : INotifyPropertyChanged
	{
		public bool DisplayPlay { get => !isPlaying; }
		public bool DisplayPauseStop { get => isPlaying; }

		// INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		bool isPlaying;
		bool IsPlaying
		{
			get => isPlaying;
			set
			{
				isPlaying = value;
				// Notify the property has changed
				OnPropertyChanged("DisplayPlay");
				OnPropertyChanged("DisplayPauseStop");
			}
		}

		public void Play()
		{
            DependencyService.Get<IStreaming>().Play();
			IsPlaying = true;
		}   

		public void Pause()
		{
			DependencyService.Get<IStreaming>().Pause();
			IsPlaying = false;
		}
        
        public void Stop()
		{
			DependencyService.Get<IStreaming>().Stop();
			IsPlaying = false;
		}
    }
}
