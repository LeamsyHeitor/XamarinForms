using Plugin.MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAvantia.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Avantia : ContentPage
    {
        string videoURL = "https://bit.ly/2CxDAAb";
        public Avantia()
        {
            InitializeComponent();
        }
        private void PlayStop_Clicked(object sender, EventArgs args)
        {
            if (PlayStopButton.Text == "Play")
            {
                CrossMediaManager.Current.Play(videoURL, Plugin.MediaManager.Abstractions.Enums.MediaFileType.Video);

                PlayStopButton.Text = "Stop";
            }
            else if (PlayStopButton.Text == "Stop")
            {
                CrossMediaManager.Current.Stop();

                PlayStopButton.Text = "Play";
            }
        }
    }
}