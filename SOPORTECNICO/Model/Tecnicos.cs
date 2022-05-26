using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOPORTECNICO.Model
{
    public class Tecnicos
    {
        [PrimaryKey]
        public string Cedula { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Usuario { get; set; }

        [MaxLength(50)]
        public string Contrasena { get; set; }
    }
}
