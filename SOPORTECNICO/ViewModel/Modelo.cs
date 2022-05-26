using MySql.Data.MySqlClient;
using SOPORTECNICO.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOPORTECNICO.ViewModel
{
    class Modelo
    {
        //public MUsersModel porUsuario(string usuario)
        //{
        //    MySqlDataReader reader;
        //    MySqlConnection conexion = ConexionMaestra.getConexion();
        //    conexion.Open();

        //    string sql = "SELECT cedula, contraseña, nombres FROM usuarios WHERE usuario LIKE @usuario";
        //    MySqlCommand comando = new MySqlCommand(sql, conexion);
        //    comando.Parameters.AddWithValue("@usuario", usuario);

        //    reader = comando.ExecuteReader();

        //    MUsersModel usr = null;

        //    while (reader.Read())
        //    {
        //        usr = new MUsersModel();
        //        usr.Id = reader["cedula"].ToString();
        //        usr.Nombre = reader["nombres"].ToString();
        //    }
        //    return usr;
        //}
    }
}
