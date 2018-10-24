using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace _10_UWP_Solarizr.Views
{
	/// <summary>
	/// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
	/// </summary>
	public sealed partial class agendaView : Page
	{
		public agendaView()
		{
			this.InitializeComponent();
			
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			// Specify a known location.
			BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 37.3914105, Longitude = -5.9591776 };
			Geopoint cityCenter = new Geopoint(cityPosition);

			// Set the map location.
			MapControl1.Center = cityCenter;
			MapControl1.ZoomLevel = 16;
			MapControl1.LandmarksVisible = true;
		}

		private void rpText1_PointerPressed(object sender, PointerRoutedEventArgs e)
		{
			Frame.Navigate(typeof(citaView));
		}
	}
}
