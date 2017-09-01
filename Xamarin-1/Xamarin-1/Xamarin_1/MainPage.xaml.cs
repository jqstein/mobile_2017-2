using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            
        }
        public void AoClicar(object sender,EventArgs e)
        {

          if(login.Text=="admin" && senha.Text == "xuxa")
            {
                Navigation.PushAsync(new MinhaPagina());
            }
            else
            {
                DisplayAlert("Login", "dados incorretos", "ok");
            }
               
               
            
        }
	}
}
