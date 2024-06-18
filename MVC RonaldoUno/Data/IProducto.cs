using MVC_RonaldoUno.Models;

namespace MVC_RonaldoUno.Data
{
    public interface IProducto
    {
        IEnumerable<Producto> ObtenerProductos();
        Producto ObtenerProductoPorId(int id);
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
    }
}
