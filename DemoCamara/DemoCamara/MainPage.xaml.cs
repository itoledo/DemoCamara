using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoCamara
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public async void SacarFoto(object sender, EventArgs pars)
        {
            CrossMedia.Current.Initialize();
            var opts = new StoreCameraMediaOptions()
            {
                 
            };
            var foto = await CrossMedia.Current.TakePhotoAsync(opts);
            Imagen.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                return stream;
            });
        }
    }
}
