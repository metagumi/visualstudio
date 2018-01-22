using System;

using Xamarin.Forms;

namespace TrackMyWalks {
    public class App : Application {
        public App() {
            // Check the Target OS Platform 
            if (Device.RuntimePlatform == Device.Android) {
               MainPage = new Pages.SplashPage();
            } else {
                // The root page of your application  
                var navPage = new NavigationPage(new TrackMyWalks.Pages.WalksPage() {
                    Title = "Track My Walks"
                });
                MainPage = navPage;
            }
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
