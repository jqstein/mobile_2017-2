using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public class MinhaPagina : ContentPage
    {
        public MinhaPagina()
        {
            Content = new StackLayout
            {
                BackgroundColor = Color.Gray,
                Padding = 20,
                VerticalOptions = LayoutOptions.Start,
                // HeightRequest = 500,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Start,

                        Text = "Digite Seu Nome",
                        TextColor = Color.Purple

                    }
                }
            };
                
        }
              

    }
}
