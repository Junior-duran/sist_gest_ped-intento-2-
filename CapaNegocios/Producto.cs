using CapaNegocios;
using System.Data.SqlClient;
using CapaDatos;

public class Producto : IEntidad
{
    public int Id { get; set; } // ID del producto
    public string Nombre { get; set; }

        public int IdProveedor { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"📦 PRODUCTO ENCONTRADO\n" +
                   $"ID: {Id}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Marca: {Marca}\n" +
                   $"Descripción: {Descripcion}\n" +
                   $"Precio: {Precio:C}";
        }
    private Producto ObtenerProductoPorId(int id)
    {
        return ObtenerProductos().FirstOrDefault(p => p.Id == id);
    }

    

    public static List<Producto> ObtenerProductos()
    {
        var productos = new List<Producto>();

        productos.Add(new Producto { Id = 1, Nombre = "CPU", IdProveedor = 1, Marca = "I5 12600K", Descripcion = "Procesador Intel Core i5 de 12ª generación, 10 núcleos y 16 hilos.", Precio = 230 });
        productos.Add(new Producto { Id = 2, Nombre = "CPU", IdProveedor = 1, Marca = "I7 14700K", Descripcion = "Procesador Intel Core i7 de 14ª generación, alto rendimiento.", Precio = 415 });
        productos.Add(new Producto { Id = 3, Nombre = "CPU", IdProveedor = 1, Marca = "I9 13900K", Descripcion = "Procesador Intel Core i9 de 13ª generación, máximo desempeño.", Precio = 570 });
        productos.Add(new Producto { Id = 4, Nombre = "GPU", IdProveedor = 2, Marca = "RTX 3050", Descripcion = "Tarjeta gráfica NVIDIA RTX 3050, ideal para gaming en 1080p.", Precio = 200 });
        productos.Add(new Producto { Id = 5, Nombre = "GPU", IdProveedor = 2, Marca = "RTX 4070 SUPER", Descripcion = "Tarjeta gráfica NVIDIA RTX 4070 SUPER, excelente rendimiento", Precio = 650 });
        productos.Add(new Producto { Id = 6, Nombre = "GPU", IdProveedor = 2, Marca = "RTX 5080", Descripcion = "Tarjeta gráfica NVIDIA RTX 5080, alto desempeño.", Precio = 999 });
        productos.Add(new Producto { Id = 7, Nombre = "RAM", IdProveedor = 3, Marca = "DDR4 8GB 3200 MHz", Descripcion = "Módulo de memoria RAM DDR4 de 8GB a 3200 MHz.", Precio = 20 });
        productos.Add(new Producto { Id = 8, Nombre = "RAM", IdProveedor = 3, Marca = "DDR5 16GB 4800 MHz", Descripcion = "Memoria RAM DDR5 de 16GB a 4800 MHz.", Precio = 60 });
        productos.Add(new Producto { Id = 9, Nombre = "RAM", IdProveedor = 3, Marca = "DDR4 32GB 5600 MHz", Descripcion = "Módulo de memoria DDR4 de 32GB a 5600 MHz.", Precio = 120 });
        productos.Add(new Producto { Id = 10, Nombre = "SSD 2.5", IdProveedor = 4, Marca = "KINGSTON", Descripcion = "Unidad de estado sólido Kingston 2.5\".", Precio = 35 });
        productos.Add(new Producto { Id = 11, Nombre = "SSD M2", IdProveedor = 5, Marca = "SAMSUNG", Descripcion = "SSD M.2 NVMe Samsung, alto rendimiento.", Precio = 80 });
        productos.Add(new Producto { Id = 12, Nombre = "SSD M2", IdProveedor = 6, Marca = "HIK-VISION", Descripcion = "Unidad SSD M.2 Hik-Vision, almacenamiento rápido.", Precio = 40 });
        productos.Add(new Producto { Id = 13, Nombre = "ASUS ROG STRIX G15", IdProveedor = 7, Marca = "ASUS", Descripcion = "Portátil gaming ASUS ROG STRIX G15.", Precio = 1100 });
        productos.Add(new Producto { Id = 14, Nombre = "LENOVO LEGION 5 PRO", IdProveedor = 8, Marca = "LENOVO", Descripcion = "Laptop Lenovo Legion 5 Pro, diseño gamer.", Precio = 1300 });
        productos.Add(new Producto { Id = 15, Nombre = "ALIENWARE", IdProveedor = 9, Marca = "DELL", Descripcion = "Portátil Alienware de Dell, máxima potencia.", Precio = 1499 });
        productos.Add(new Producto { Id = 16, Nombre = "BLACKBERRY CLASSIC", IdProveedor = 10, Marca = "BLACKBERRY", Descripcion = "Teléfono BlackBerry Classic.", Precio = 150 });
        productos.Add(new Producto { Id = 17, Nombre = "GALAXY S25 ULTRA", IdProveedor = 5, Marca = "SAMSUNG", Descripcion = "Smartphone Samsung Galaxy S25 Ultra.", Precio = 1200 });
        productos.Add(new Producto { Id = 18, Nombre = "IPHONE 15 PRO MAX", IdProveedor = 12, Marca = "APPLE", Descripcion = "iPhone 15 Pro Max con chip A17 Bionic.", Precio = 1100 });
        productos.Add(new Producto { Id = 19, Nombre = "AirPods Pro", IdProveedor = 12, Marca = "APPLE", Descripcion = "Audífonos inalámbricos con cancelación activa de ruido.", Precio = 250 });
        productos.Add(new Producto { Id = 20, Nombre = "Sony WH-1000XM5", IdProveedor = 13, Marca = "SONY", Descripcion = "Audífonos de diadema con cancelación de ruido líder.", Precio = 400 });
        productos.Add(new Producto { Id = 21, Nombre = "Bose Companion 2 Series III", IdProveedor = 14, Marca = "Bose", Descripcion = "Bocinas con sonido nítido y bajos mejorados.", Precio = 100 });
        productos.Add(new Producto { Id = 22, Nombre = "Logitech Z407", IdProveedor = 15, Marca = "Logitech", Descripcion = "Sistema de bocinas 2.1 con subwoofer y Bluetooth.", Precio = 120 });

        return productos;
    }

}
