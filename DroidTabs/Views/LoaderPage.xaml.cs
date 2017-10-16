using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DroidTabs.Views
{
    public partial class LoaderPage : ContentPage
    {

        public LoaderPage()
        {

            InitializeComponent();
            //switch on pageName and load it
            //Navigation.PushAsync(new TabbedPage());
            //Application.Current.MainPage = new ContentPage1();
            //Application.Current.MainPage = new ContentPage2();
            //Application.Current.MainPage = new NavigationPage();
            //Application.Current.MainPage = new NavigationPage();
            //Application.Current.MainPage.Navigation.PushAsync(new TabPage());

            //Application.Current.MainPage.Navigation.PushAsync(new ContentPage1());



        }

        public void TabClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new TabPage());
            /*
            Application.Current.MainPage = new NavigationPage();
            Application.Current.MainPage.Navigation.PushAsync(new TabPage());
            */

            string direction = "StartTabPage"; MessagingCenter.Send(direction, "StartTabPage");

            /*
            Device.BeginInvokeOnMainThread(async () => {
                //var mainPage = new TabPage();//this could be content page
                //Application.Current.MainPage.Navigation.PopToRootAsync();
                var mainPage = new NavigationPage(new TabPage());
                Application.Current.MainPage = mainPage;
            });
            */

        }

    }
}
