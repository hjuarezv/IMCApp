using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IMCApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularIMCPage : ContentPage
    {
        public CalcularIMCPage()
        {
            InitializeComponent();
        }

        private void btnCalcularIMC_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTalla.Text) || string.IsNullOrEmpty(txtPeso.Text))
                DisplayAlert("Error", "Debes de ingresar los datos para poder calcular tu IMC.", "OK");
            else
            {
                var talla = double.Parse(txtTalla.Text);
                var peso = double.Parse(txtPeso.Text);

                var imc = Math.Round(peso / (talla * talla), 2);

                txtResultado.Text = imc.ToString();

                if (imc < 18.5)
                {
                    imgResultado.Source = "desnutricion.jpg";
                    imgResultado.IsVisible = true;
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    imgResultado.Source = "saludable.jpg";
                    imgResultado.IsVisible = true;
                }
            }

        }
    }
}