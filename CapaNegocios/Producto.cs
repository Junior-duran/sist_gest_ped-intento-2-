using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaNegocios;
using CapaDatos;
using System.Data;


namespace ENT
{
    public class Producto : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }
        public decimal Precio { get; set; }
        public int IdProducto { get; set; }
        public Producto(int id, string nombre, string marca, string descripcion, int idProveedor)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Descripcion = descripcion;
            IdProveedor = idProveedor;
        }

        public override string ToString()
        {
            return $"Producto: {Nombre}, Marca: {Marca}, Descripción: {Descripcion}, Proveedor ID: {IdProveedor}";
        }


        public static List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            
                using (SqlConnection conn = new SqlConnection(Conexion.CadenaConexion))
                {
                    string sql = "SELECT * FROM Producto";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(dr["idProducto"]),
                            Nombre = dr["Nombre"].ToString(),
                            Marca = dr["Marca"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            IdProveedor = Convert.ToInt32(dr["idProveedor"]),
                            Precio = Convert.ToDecimal(dr["Precio"])
                        });
                    }
                }
            return lista;

        }
    }
}
