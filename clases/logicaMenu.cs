using System;
using Productos;
namespace LogicaMenu;

public static class LogicaDelMenu
{
    public static void ConsultarInventaraio()
    {
        conexionSQL.VisualizarProductos();
    }

    public static void AgregarProductos()
    {
        Producto producto = new Producto();
        string? nombre,precio,categoria;

        Console.WriteLine("Ingrese el nombre de el producto");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el precio del producto");
        precio = Console.ReadLine();
        Console.WriteLine("Ingrese la categoria del producto");
        categoria = Console.ReadLine();
                //fecha de ingreso, se colocara en automatico una vez ingresado   

        
        
    }



}