using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace StreamingExample
{
    public partial class StreamingExamplePage : ContentPage
    {
        public StreamingExamplePage()
        {
			InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

		// Callbacks to images tapped
		private void Play_tapped(object sender, EventArgs e)
		{
			Play.IsVisible = false;
			PauseStop.IsVisible = true;
		}

		private void Pause_tapped(object sender, EventArgs e)
        {
			Play.IsVisible = true;
			PauseStop.IsVisible = false;
        }

		private void Stop_tapped(object sender, EventArgs e)
        {
			Play.IsVisible = true;
			PauseStop.IsVisible = false;
        }
    }
}
