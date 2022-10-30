using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Modelos;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("TraerTodosProductos")]
        public List<Producto> Get()
        {
            return ADO_Producto.DevolverProductos();
        }
        [HttpGet("GetProductosId")]
        public Producto Get(Int32 id)
        {
            return ADO_Producto.TraerProductoId(id);
        }

        [HttpPost("CrearProducto")]
        public void Crear([FromBody] Producto prod)
        {
            ADO_Producto.CrearProducto(prod);
        }
        [HttpPut("ModificarProducto")]
        public void Modificar([FromBody] Producto prod)
        {
            ADO_Producto.ModificarProducto(prod);
        }
        [HttpDelete("EliminarProducto")]
        public void Eliminar([FromBody] long idProducto)
        {
            ADO_Producto.EliminarProducto(idProducto);
        }
    }
}
