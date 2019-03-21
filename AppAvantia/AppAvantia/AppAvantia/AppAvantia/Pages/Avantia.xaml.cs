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
        string videoURL = "https://r1---sn-25glen7e.googlevideo.com/videoplayback?dur=138.530&expire=1553279439&source=youtube&pl=22&id=o-AMziXmzk_P_i-mdhEucLet6dnjXuF614eyBSfITNasrK&ei=btWUXLfcM4KrhAfYuabIBw&ms=au,onr&mt=1553257730&mime=video/mp4&mv=m&ipbits=0&ratebypass=yes&signature=9CB26BF4D3E82DD786E6072C3FFCC1509F5246DD.7A95978E429C4B7FB0146FB381833C222EAB2B39&sparams=dur,ei,id,initcwndbps,ip,ipbits,itag,lmt,mime,mm,mn,ms,mv,pl,ratebypass,requiressl,source,expire&mn=sn-25glen7e,sn-4g5e6nzs&requiressl=yes&ip=94.23.214.151&key=yt6&lmt=1521043858588631&itag=22&initcwndbps=343750&c=WEB&fvip=1&mm=31,26&&title=Criar%2C+Superar%2C+Realizar.+-+Avantia";
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