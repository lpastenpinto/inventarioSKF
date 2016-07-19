using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Model
{
    class DetalleDespacho
    {
        public int DetalleDespachoID { get; set; }

       
        public int DespachoID { get; set; }
        public int productosID { get; set; }

        public double Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double TotalNetoLinea { get; set; }
        public double CostoVigente { get; set; }

        public virtual Despacho Despacho { get; set; }
        public productos productos { get; set; }
    }
}
