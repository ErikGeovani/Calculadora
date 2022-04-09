using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Total de la Suma es:", Convert.ToString(Convert.ToDouble(numero1.Text) + Convert.ToDouble(numero2.Text)), "ok");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Total de la Resta es:", Convert.ToString(Convert.ToDouble(numero1.Text) - Convert.ToDouble(numero2.Text)), "ok");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Total de la Multiplicacion es:", Convert.ToString(Convert.ToDouble(numero1.Text) * Convert.ToDouble(numero2.Text)), "ok");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await DisplayAlert("Total de la Divicion es:", Convert.ToString(Convert.ToDouble(numero1.Text) / Convert.ToDouble(numero2.Text)), "ok");
        }
    }
}
