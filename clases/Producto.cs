using System;


public class Producto{


    protected string? Nombre;
    protected int? Precio;
    protected string? caducidad;
    protected string? Provedor;
    public Producto(string? _nombreProducto int? _precioProducto, string? _caducidadProducto, string? _provedorProducto){
        this.Nombre = _nombreProducto;
        this.Precio = _precioProducto;
        this.caducidad = _caducidadProducto;
        this.Provedor = _provedorProducto;
    }

    


    public void integrarProducto(){
            
    }




}