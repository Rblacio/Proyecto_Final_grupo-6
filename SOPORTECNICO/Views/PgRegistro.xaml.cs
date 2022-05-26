using SOPORTECNICO.Model;
using SOPORTECNICO.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SOPORTECNICO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgRegistro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public PgRegistro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();

        }

        private void Registrar_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Cedula.Text) || String.IsNullOrEmpty(Nombre.Text) || String.IsNullOrEmpty(Usuario.Text) || String.IsNullOrEmpty(Contraseña.Text))
            {
                DisplayAlert("Alerta", "Complete todos los campos", "ok");

            }
            else
            {
                try
                {
                    var datosRegistro = new Tecnicos { Cedula = Cedula.Text, Nombre = Nombre.Text, Usuario = Usuario.Text, Contrasena = Contraseña.Text };
                    con.InsertAsync(datosRegistro);
                    Navigation.PushAsync(new PgLogin());
                }
                catch (Exception)
                {

                    DisplayAlert("Alerta", "Usuario ingresado", "ok");
                }
            }
            
        }
    }
}