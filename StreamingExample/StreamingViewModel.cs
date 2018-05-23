using System.ComponentModel;
using System.Runtime.CompilerServices;

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
