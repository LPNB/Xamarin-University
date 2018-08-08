using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NetStatus
{
	public class NoNetworkPage : ContentPage
	{
		public NoNetworkPage ()
		{
            // experiment defining UI through code-behind rather than xaml
            BackgroundColor = Color.FromRgb(0xf0, 0xf0, 0xf0);
            Content = new Label()
            {
                Text = "No Network Connection Available",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.FromRgb(0x40, 0x40, 0x40),
            };
        }
	}
}