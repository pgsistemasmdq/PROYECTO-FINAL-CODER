namespace WebApiCoder.Modelos
{
    public class VentaProductoDetalle :ProductoVendido
    {
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public double Total { get; set; }
    }
}
