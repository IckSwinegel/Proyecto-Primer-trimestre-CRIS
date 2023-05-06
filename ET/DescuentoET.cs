using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class DescuentoET
    {
        private int idDescuento;
        private float procentaje;
        private int idTipoDescuento;

        public int IdDescuento { get => idDescuento; set => idDescuento = value; }
        public float Procentaje { get => procentaje; set => procentaje = value; }
        public int IdTipoDescuento { get => idTipoDescuento; set => idTipoDescuento = value; }
    }
}
