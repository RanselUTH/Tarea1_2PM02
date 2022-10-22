using System;
using Xamarin.Forms;

namespace Tarea1_2PM02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado
            {
                nombres = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text
            };

            var pagina = new Views.Pagina1();
            pagina.BindingContext = emple;
            await Navigation.PushAsync(pagina);
        }
    }
}

