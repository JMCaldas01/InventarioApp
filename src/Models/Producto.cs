namespace InventarioApp.Models
{
    public class Producto
    {
        private string _nombre = "";
        private decimal _precio;
        private int _cantidad;
        public int Id { get; set; }
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Nombre no puede estar vacio {value}");
                }
                _nombre = value;
            }
        }
        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"Precio no puede ser un valor negativo");
                }
                _precio = value;
            }
        }
        public int Cantidad
        {
            get => _cantidad;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException($"Cantidad no puede ser un valor negativo");
                }
                _cantidad = value;
            }
        }
        public CategoriaProducto Categoria { get; set; }
        public EstadoProducto Estado { get; set; } = EstadoProducto.Activo;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public decimal ValorTotal => Precio * Cantidad;
    }
}