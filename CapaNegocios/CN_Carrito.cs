using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    using CapaDatos;
    using CapaDatos.CapaDatos;
    using System.Data;

    namespace CapaNegocios
    {
        public class CN_Carrito
        {
            CD_Carrito cd_carrito = new CD_Carrito();

            public DataTable MostrarCarrito()
            {
                return cd_carrito.ObtenerCarrito();
            }
        }
    }
}
