using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ImpuestoET
    {
        private int idImpuestos;
        private float porcentaje;
        private int idTipoImpuesto;

        public int IdImpuestos { get => idImpuestos; set => idImpuestos = value; }
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }
        public int IdTipoImpuesto { get => idTipoImpuesto; set => idTipoImpuesto = value; }
    }
}
