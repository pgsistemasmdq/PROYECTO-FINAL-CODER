using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Modelos;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaProductoDetalleController : ControllerBase
    {
        [HttpGet("TraerVentas")]
        public List<VentaProductoDetalle> Get()
        {
            return ADO_Venta.DevolverVentaProductos();
        }
    }
}
