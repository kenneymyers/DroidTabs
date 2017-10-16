using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DroidTabs.Views
{
    public partial class ContentPage2 : ContentPage
    {
        public ContentPage2()
        {
            InitializeComponent();
            Title = "Page 2";
        }

        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
    }
}
