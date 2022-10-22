using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_2PM02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }
        public Pagina1(String pmessage)
        {
            InitializeComponent();

            lbnombres.Text = pmessage;
            lbapellidos.Text = pmessage;
            lbedad.Text = pmessage;
            lbcorreo.Text = pmessage;


        }
    }
}