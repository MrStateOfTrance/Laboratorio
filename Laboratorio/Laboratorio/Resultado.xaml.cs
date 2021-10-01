using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado()
        {
            InitializeComponent();

            
        }

        private void btnCalcularfac_Clicked(object sender, EventArgs e)
        {
            if(ValorFahren != null)
            {
                float fahrenheit = float.Parse(ValorFahren.Text);
                float centigrados = (fahrenheit - 32f) * 5 / 9f;
                centigrados = centigrados * 10f / 10f;

                ResultadoFaC.Text = centigrados.ToString();
            }

           



          
        }

        private void btnCalcularcaf_Clicked(object sender, EventArgs e)
        {
            if (ValorCentig != null)
            {
                float centigrados = float.Parse(ValorCentig.Text);
                float fahrenheit = centigrados * 9f / 5 + 32f;
                fahrenheit = fahrenheit * 10f / 10f;

                ResultadoCaF.Text = fahrenheit.ToString();
            }

        }

    }
}