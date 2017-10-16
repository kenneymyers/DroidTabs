using System;
using System.Collections.Generic;
using System.ComponentModel;
using DroidTabs.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DroidTabs
{
    public partial class App : Application
    {

        public static Page mainPage { get; set; }

        public App()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<string>(this, "StartTabPage", (sender) => {
                GoToTabPage();
            });

            //MainPage = new TabPage();
            mainPage = new NavigationPage(new RoutingPage());

        }

        public void GoToTabPage(){
            
            Application.Current.MainPage.Navigation.PushAsync(new TabPage());
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
