using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class TipoImpuestoET
    {
        private int idTipoImpuesto;
        private string descripcion;

        public int IdTipoImpuesto { get => idTipoImpuesto; set => idTipoImpuesto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
