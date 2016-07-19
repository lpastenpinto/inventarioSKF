using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Model
{
    class productos
    {
        public int productosID { get; set; }

        public string codigo { get; set; }
        
        public string codigoBarra { get; set; }

        public string codigoBarraInterno { get; set; }
        
        public string descripcion { get; set; }
    }
}
