using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaResult : ContentPage
	{
        Label lblSoma, lblSub, lblDiv, lblMult;
        public PaginaResult (string soma, string sub, string mult, string div)
		{
            //InitializeComponent ();
            lblSoma = new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = "Resultado da SOMA é: " + soma,
                FontSize = 15,
                TextColor = Color.DarkRed
            };

            lblSub = new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = "Resultado da SUBTRAÇÃO é: " + sub,
                FontSize = 15,
                TextColor = Color.DarkBlue
            };

            lblMult = new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = $"Resultado da MULTIPLICAÇÃO é: " + mult,
                FontSize = 15,
                TextColor = Color.DarkOrange
            };

            lblDiv = new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = $"Resultado da DIVISÃO é: " + div,
                FontSize = 15,
                TextColor = Color.DarkGreen
            };

            Title = "Resultados";
            Content = new StackLayout
            {

                BackgroundColor = Color.Cyan,
                Padding = 40,
                VerticalOptions = LayoutOptions.Start,
                // HeightRequest=500,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment=TextAlignment.Center,
                        Text="Resultados dos cálculos:",
                        //FontSize=20,
                        TextColor=Color.Black
                    },
                    lblSoma,
                    lblSub,
                    lblMult,
                    lblDiv

                }
            };
        }


        

	}
}