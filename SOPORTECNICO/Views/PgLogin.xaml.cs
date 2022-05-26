using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using SOPORTECNICO.Model;
using SOPORTECNICO.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SOPORTECNICO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgLogin : ContentPage
    {
        private SQLiteAsyncConnection con;
        public PgLogin()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        public static IEnumerable<Tecnicos> Select_Where(SQLiteConnection db, string usuario, string contrasena)

        {
            return db.Query<Tecnicos>("SELECT * FROM Tecnicos where Usuario =? and Contrasena =?", usuario, contrasena);
        }
        private void Ingresar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Usuario.Text) || String.IsNullOrEmpty(Contraseña.Text))
            {
                DisplayAlert("Alerta", "Complete todos los campos", "ok");

            }
            else
            {
                try
                {
                    var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "soportecnico.db3");
                    var db = new SQLiteConnection(databasePath);
                    db.CreateTable<Tecnicos>();
                    IEnumerable<Tecnicos> resultado = Select_Where(db, Usuario.Text, Contraseña.Text);
                    if (resultado.Count() > 0)
                    {
                        Navigation.PushAsync(new VHome());

                    }
                    else
                    {
                        DisplayAlert("Alerta", "Usuario Incorrecto", "cerrar");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private async void Registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PgRegistro());
        }
    }
}