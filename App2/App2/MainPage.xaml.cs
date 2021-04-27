using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*private async void Button_Clicked(object sender, EventArgs e)
         {
             await TextToSpeech.SpeakAsync(txtTexto.Text);
         }

         private async void Button_Clicked2(object sender, EventArgs e)
         {
             if (txtComida.IsPressed)
             {
                 await TextToSpeech.SpeakAsync("Me gustaria Comer algo");
             }
             else if (txtBebida.IsPressed)
             {
                 await TextToSpeech.SpeakAsync("Me gustaria beber algo");
             }
             else if (txtBanio.IsPressed)
             {
                 await TextToSpeech.SpeakAsync("Tengo que hacer del Baño");
             }
             else if (txtRevision.IsPressed)
             {
                 await TextToSpeech.SpeakAsync("Me siento mal");
             }
         }*/
    }
}
