namespace WebApplicationBlazor002.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } = 0;
        public double Amount { get; set; }
        public double MinStock { get; set; }
        public double? MaxStock { get; set; }
        

        // clave foranea
        public int? ProveedorCodigo { get; set; }

        // propiedades de navegacion
        public Proveedor Proveedor { get; set; }

    }

    public class ListaProductos { 
        public List<Producto> Productos { get; set; }
        public double TotalInventario
        {
            get
            {
                return Productos.Sum(p => p.Price * p.Amount);
            }
            set 
            { 
            }
        }
    }
}
