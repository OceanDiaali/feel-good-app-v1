using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;

using Xamarin.Essentials;

namespace FeelGood
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
       
        string[] words = {
                   "The sky is just the start for you", "Feel good", "You have a good heart",
                   "You are the salt of the earth", "There is someone out there that truly appreciates you",
                   "Your days shall be sunny", "People love you", "They envy what you have, be kind to them",
                   "Your only limitation is your imagination", 
                   "When you believe in you, the universe has to agree", "Keep shining!",
                   "Rise like an eagle", "The yam and knife are in your hands",
                   "Aim for another galaxy, and even if you miss, you'll still be among stars",
                   "There's no one like you", "You have a greater strength within yourself",
                   "Life is worth living", "There's so much that you can achieve, when you believe",
                   "Never give up, never quit", "You don't know your own strength", 
                   "The offspring of a tiger, is a tiger"
                   };

        public MainPage()
        {
            InitializeComponent();
        }




        //protected override void OnAppearing()
        //{
        //    Accelerometer.ShakeDetected += Accelerometer_OnShaked;
        //    Accelerometer.Start(SensorSpeed.Game);
        //    base.OnAppearing();
        //}

        //void Accelerometer_OnShaked(object sender, EventArgs e)
        //{
        //    Random random = new Random();

        //    int index = random.Next(words.Length);
        //    var settings = new SpeechOptions()
        //    {
        //        Volume = .90f,
        //        Pitch = 1.0f
        //    };
        //    Console.WriteLine("We are shakin'..");
        //    TextToSpeech.SpeakAsync(words[index], settings);
        //}

        //protected override void OnDisappearing()
        //{
        //    Accelerometer.Stop();
        //    Accelerometer.ShakeDetected -= Accelerometer_OnShaked;
        //    base.OnDisappearing();
        //}



        async void SpeechButton_Clicked(object sender, EventArgs eventArgs) 
        {
            //string[] words = { 
                   //"Hello, pretty!", "Feel good", "Nice smile",
                   //"You are the salt of the earth", "There is someone out there for you",
                   //"Your day shall be sunny", "People love you", "They envy what they do not have"
                   //};
            Random random = new Random();

            int index = random.Next(words.Length);
            var settings = new SpeechOptions()
            {
                Volume = .90f,
                Pitch = 1.0f
            };
            await TextToSpeech.SpeakAsync(words[index], settings);


        }


    }
}
