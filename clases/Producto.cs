using System;
using System.Collections;
using ValidarDatos;
namespace Productos;


public class Producto
{
    private String Nombre = "";
    private double Precio = 0.0;
    private String  Categoria ="";
    private String FechaIngreso = ""; 
    
    List<Producto> MisProductos = new List<Producto>();
    
    public Producto(String Nombre, double Precio,String Categoria, String FechaIngreso)
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
    public String GetFechaIngresoProducto()
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

    public void setFechaIngresoProducto(String FechaIngreso)
    {
        this.FechaIngreso = FechaIngreso;
    }



    public void AñadirProductos(String Nombre, double Precio,String Categoria, String FechaIngreso)
    {
        MisProductos.Add(new Producto(Nombre,Precio,Categoria,FechaIngreso));
    }
    public void AñadirProductos(String Nombre, double Precio,String Categoria)
    {
        MisProductos.Add(new Producto(Nombre,Precio,Categoria));
    }
    public void AñadirProductos(String Nombre, double Precio)
    {
        MisProductos.Add(new Producto(Nombre,Precio));
    }




    public void MostrarListaDeProductos()
    {
        foreach(Producto producto in MisProductos)
        {
            Console.WriteLine($"{producto.Nombre}, {producto.Precio},{producto.Categoria},{producto.FechaIngreso}");
        }
    }



    





    public void MostrarProducto()
    {
        Console.WriteLine($"El producto agregado fue: {Nombre} \nSu precio es de: ${Precio} \nSu categoria: {Categoria} \nCon fecha de ingreso de: {FechaIngreso}");
    }







}









