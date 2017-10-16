using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DroidTabs.Views
{
    public partial class RoutingPage : ContentPage
    {

        public RoutingPage()
        {
            InitializeComponent();

            //publish message to go back to Android
            string direction = "StartMainActivity"; MessagingCenter.Send(direction, "StartMainActivity");

        }

    }
}
