using System;

public abstract class Producto
{
    protected string Nombre = "";
    protected string Precio = "";
    
    protected Producto(string _Nombre, string _Precio)
    {
        this.Nombre = _Nombre;
        this.Precio = _Precio;
    }

    public abstract void IngresarBaseDeDatos();

}


// no esta bien hacer las clases aqui juntas, por eso se dividen pero x

public class Bebidas : Producto 
{
    private double Litros;
    private string Caducidad;

    public Bebidas(string _Nombre, string _Precio, double _Litros, string _Caducidad) : base(_Nombre,_Precio)
    {
        this.Litros = _Litros;
        this.Caducidad = _Caducidad;
    }

    public override void  IngresarBaseDeDatos()
    {
        // aqui se metera a la base de datos
    }
}

public class Abarrotes : Producto
{
    private string Proveedor;
    private string Caducidad;
    public Abarrotes(string _Nombre, string _Precio, string _Proveedor, string _Caducidad) : base(_Nombre, _Precio) 
    {
        this.Proveedor = _Proveedor;
        this.Caducidad = _Caducidad;
    }

    public override void IngresarBaseDeDatos()
    {
        //se ingresara a la base de datos
    }
}

public class FrutasVerduras : Producto 
{
    private string FechaCompra;
    public FrutasVerduras(string _Nombre, string _Precio, string _FechaCompra) : base(_Nombre , _Precio) 
    {
        this.FechaCompra = _FechaCompra;
    }

    public override void IngresarBaseDeDatos()
    {
        // se ingresa a la database
    }
}


