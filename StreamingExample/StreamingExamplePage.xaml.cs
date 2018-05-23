using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace StreamingExample
{
    public partial class StreamingExamplePage : ContentPage
    {
		private StreamingViewModel ViewModel { get { return (StreamingViewModel)this.BindingContext; } }

        public StreamingExamplePage()
        {
			InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

			BindingContext = new StreamingViewModel();
        }

		// Callbacks to images tapped
		private void Play_tapped(object sender, EventArgs e)
		{
			Play.IsVisible = false;
			PauseStop.IsVisible = true;
			ViewModel.Play();
		}

		private void Pause_tapped(object sender, EventArgs e)
        {
			Play.IsVisible = true;
			PauseStop.IsVisible = false;
			ViewModel.Pause();
        }

		private void Stop_tapped(object sender, EventArgs e)
        {
			Play.IsVisible = true;
			PauseStop.IsVisible = false;
			ViewModel.Stop();
        }
    }
}
