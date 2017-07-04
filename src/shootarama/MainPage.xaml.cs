﻿using System;

using Xamarin.Forms;

namespace shootarama
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

	    protected async void btnAbout_Click(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new AboutPage(), true);
        }
	}
}