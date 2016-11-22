using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using XamarinDevice.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(UWPImplement))]
namespace XamarinDevice.UWP
{
    public class UWPImplement : IInterface
    {
        public UWPImplement() { }
        public async void speak(string text)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //await synth.SynthesizeTextToStreamAsync(text);
            //Debug.WriteLine("uwp text");
            var mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            var stream = await synth.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }
    }
}
