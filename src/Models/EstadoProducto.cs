/// <summary>
/// Ciclo de vida de un producto en el inventario
/// </summary>
namespace InventarioApp.Models
{
    public enum EstadoProducto
    {
        /// <summary>
        ///  Disponible para venta.
        /// </summary>
        Activo,
        /// <summary>
        /// Temporalmente fuera de disponibilidad.
        /// </summary>
        Inactivo,
        /// <summary>
        /// Retirado permanentemente del catalogo.
        /// </summary>
        Descontinuado
    }
}