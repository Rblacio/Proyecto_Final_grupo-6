using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SOPORTECNICO.Model;
using SOPORTECNICO.ViewModel;
using Xamarin.Forms;

namespace SOPORTECNICO.ViewModel
{
    class VMLogin
    {
        //public string ctrlLogin(string usuario, string password)
        //{
        //    Modelo modelo = new Modelo();
        //    string respuesta = "";
        //    MUsersModel datosUsuario = null;

        //    if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
        //    {
        //        respuesta = "Debe llenar todos los campos";
        //    }
        //    else
        //    {
        //        datosUsuario = modelo.porUsuario(usuario);

        //        if (datosUsuario == null)
        //        {
        //            respuesta = "El usuario no existe";
        //        }
        //        else
        //        {
        //            if (datosUsuario.Password != password)
        //            {
        //                respuesta = "El usuario y/o contraseña no coinciden";
        //            }
        //            else
        //            {
        //                MLogin.id = datosUsuario.Id;
        //                MLogin.usuario = usuario;
        //                MLogin.nombre = datosUsuario.Nombre;
        //            }
        //        }
        //    }
        //    return respuesta;
        //}
    }
}
