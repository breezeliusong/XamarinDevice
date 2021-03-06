﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinDevice
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            Button bt = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Welcome to Xamarin Forms!"
            };
            bt.Clicked += (send, e) =>
            {
                DependencyService.Get<IInterface>().speak("hello dependency service");
            };
            var content = new ContentPage
            {
                Title = "XamarinDevice",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {bt}
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
