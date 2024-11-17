using System;
using System.Collections;
using ValidarDatos;
namespace Productos;


public class Producto
{
    private String Nombre = "";
    private double Precio = 0.0;
    private String  Categoria ="";
    private DateTime FechaIngreso; 
    
    public Producto(String Nombre, double Precio,String Categoria, DateTime FechaIngreso)
    {
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Categoria = Categoria;
        this.FechaIngreso = FechaIngreso;
    }

    public Producto(String Nombre, double Precio,String Categoria)
    {
        this.Nombre = Nombre;
        this.Precio = Precio;
        this.Categoria = Categoria;
    }

    public Producto(String Nombre, double Precio)
    {
        this.Nombre = Nombre;
        this.Precio = Precio;
    }

    public Producto()
    {
        
    }


    //get y set
    public String GetNombreProducto()
    {
        return this.Nombre;
    }

    public double GetPrecioProducto()
    {
        return this.Precio;
    }
    public String GetCategoriaProducto()
    {
        return this.Categoria;
    }
    public DateTime GetFechaIngresoProducto()
    {
        return this.FechaIngreso;
    }

    public void setNombreProducto(String Nombre)
    {
        this.Nombre = Nombre;
    }

    public void setPrecioProducto(double Precio)
    {
        this.Precio = Precio;
    }

    public void setCategoriaProducto(String Categoria)
    {
        this.Categoria = Categoria;
    }

    public void setFechaIngresoProducto(DateTime FechaIngreso)
    {
        this.FechaIngreso = FechaIngreso;
    }

    public String mostrar(){
        return "Nombre: " + GetNombreProducto() + " Precio: " + GetPrecioProducto() + " Categoria " + GetCategoriaProducto() + "Fecha de ingreso: " + GetFechaIngresoProducto();
    }
}









