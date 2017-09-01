using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_1
{
    public partial class MinhaPagina: ContentPage
    {
        private String soma, sub, mult, div;
        Button button;
        Entry entry, entry2;
        public MinhaPagina()
        {
            //InitializeComponent();
            entry = new Entry
            {
                Placeholder = "Digite primeiro valor",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            entry2 = new Entry
            {
                Placeholder = "Digite segundo valor",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            button =
            new Button
            {
                Text = "Realizar operações",
                FontSize = 12,
                HorizontalOptions = LayoutOptions.Center,

            };


            
            button.Clicked += (sender, args) =>
            {
                Calcula(entry.Text, entry2.Text);
                Navigation.PushAsync(new PaginaResult(soma, sub, mult, div));
            };
            

            Title = "Calculadorinha";
            Content = new StackLayout
            {
               
                BackgroundColor=Color.Cyan,
                Padding = 40,
                VerticalOptions=LayoutOptions.Start,
               // HeightRequest=500,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment=TextAlignment.Center,
                        Text="Digite dois valores para cálcular:",
                        //FontSize=20,
                        TextColor=Color.Black
                    },
                    entry,
                    entry2,
                    button
                }
            };
            

        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{

        //    if (DisplayAlert("Titulo","Deu pau no bagulho","accept","cancel").IsCanceled)
        //    {
        //        Navigation.PushAsync(new MainPage());
        //    }
        //}



        public void Calcula(String x, String y)
        {
            double valor1 = Convert.ToDouble(x);
            double valor2 = Convert.ToDouble(y);
            soma = Convert.ToString(valor1 + valor2);
            sub = Convert.ToString(valor1 - valor2);
            mult = Convert.ToString(valor1 * valor2);
            div = Convert.ToString(valor1 / valor2);
        }
    }
}
