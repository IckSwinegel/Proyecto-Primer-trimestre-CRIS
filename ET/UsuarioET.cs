using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class UsuarioET
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasenna;
        private string direccion;
        private int idTipoUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenna { get => contrasenna; set => contrasenna = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
    }
}