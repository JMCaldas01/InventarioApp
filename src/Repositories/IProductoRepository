using InventarioApp.Models;

namespace InventarioApp.Repositories;

/// <summary>
/// Contrato para el repositorio de productos.
/// Define las operaciones básicas y avanzadas de almacenamiento.
/// </summary>
public interface IProductoRepository
{
    // CRUD básico
    void Agregar(Producto producto);
    Producto? ObtenerPorId(int id);
    IEnumerable<Producto> ObtenerTodos();
    bool Actualizar(Producto producto);
    bool Eliminar(int id);
    int Cantidad { get; }

    // Búsquedas
    IEnumerable<Producto> BuscarPorCategoria(CategoriaProducto categoria);
    IEnumerable<Producto> BuscarPorNombre(string nombre);
    IEnumerable<Producto> BuscarPorRangoPrecio(decimal min, decimal max);

    // Estadísticas
    decimal ObtenerValorTotalInventario();
    decimal ObtenerPrecioPromedio();
    Producto? ObtenerProductoMasCaro();
    Dictionary<CategoriaProducto, int> ContarPorCategoria();

    // Stock
    bool HayStockBajo(int minimo = 5);
    IEnumerable<Producto> ObtenerStockBajo(int minimo = 5);
}
