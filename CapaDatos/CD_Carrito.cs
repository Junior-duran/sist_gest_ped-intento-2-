using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    using System.Data;
    using System.Data.SqlClient;

    namespace CapaDatos
    {
        public class CD_Carrito
        {
            private SqlConnection conn = new SqlConnection("Server=TU_SERVIDOR;Database=TU_BASE;Trusted_Connection=True;");

            public DataTable ObtenerCarrito()
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Carrito", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
