using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            lblRespuesta.Text = (Int32.Parse(txtNum1.Text) + (Int32.Parse(txtNum2.Text))).ToString();
        }

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            lblRespuesta.Text = (Int32.Parse(txtNum1.Text) - (Int32.Parse(txtNum2.Text))).ToString();
        }

        private void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            lblRespuesta.Text = (Int32.Parse(txtNum1.Text) * (Int32.Parse(txtNum2.Text))).ToString();
        }

        private void btnDivision_Clicked(object sender, EventArgs e)
        {
            lblRespuesta.Text = (Int32.Parse(txtNum1.Text) / (Int32.Parse(txtNum2.Text))).ToString();
        }
    }
}
