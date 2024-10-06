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
        bool bandera = true;
        Producto producto = new Producto();
        UIMenu uIMenu = new UIMenu();
        string? nombre,precio,categoria,contrasena;
        DateTime Fecha_ingreso = DateTime.Now;
        List<Producto> ListaTemporal = new List<Producto>();

        Console.WriteLine("Ingrese todos los productos que desee, cuando este listo solo ingrese su contrasena");
        while(bandera)
        {
            Console.WriteLine("Ingrese el nombre de el producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto");
            precio = Console.ReadLine();
            Console.WriteLine("Ingrese la categoria del producto");
            categoria = Console.ReadLine();
                    //fecha de ingreso, se colocara en automatico una vez ingresado   
            if(!string.IsNullOrEmpty(nombre))
            {
                if(!string.IsNullOrEmpty(precio))
                {
                    if(!string.IsNullOrEmpty(categoria))
                    {
                        ListaTemporal.Add(new Producto(nombre,Convert.ToDouble(precio),categoria,Fecha_ingreso));
                        Console.WriteLine("Producto ingresado temporalmente:");
                        contrasena = Console.ReadLine();
                        if(contrasena == "1234")
                        {
                            bandera = false;
                            Console.WriteLine("Productos agregados exitosamente");
                            // anadir la lista temporal a la base de datos y limpiarla
                            foreach(Producto productosEnLista in ListaTemporal)
                            {
                                conexionSQL.AnadirProductos(productosEnLista);
                            }

                            uIMenu.UIMenuPrincipal();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La categoria esta vacia, ingrese el tipo de categoria");
                    }
                }
                else
                {
                    Console.WriteLine("El precio esta vacio, ingrese el precio del producto");
                }
            }
            else
            {
                Console.WriteLine("EL nombre esta vacio, ingrese un nombre al producto");
            }
        }
    }

    public static void EliminarProducto()
    {
        
    }



}