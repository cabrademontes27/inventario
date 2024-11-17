using System;
using System.Security.Cryptography.X509Certificates;
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

    public static void EliminarDB()
    {
        Console.WriteLine("ESTAS A PUNTO... DE BORRAR LA BASE DE DATOS >:)");
        Console.WriteLine("Estas seguro de lo que estas a punto de hacer ");
        Console.Write("(SI/NO): ");
        string respuesta =  Console.ReadLine();

        if(respuesta == "SI" || respuesta =="si")
        {
            Console.WriteLine("Esta sera la consulta que se realizara: DROP DATABASE INVENTARIO ");
            Console.WriteLine("Esta correcta la consulta?");
            string? respuesta1 = Console.ReadLine();
            if(respuesta1 == "NO" || respuesta1 == "no")
            {
                Console.WriteLine("Si no le sabes papito....");
                Console.WriteLine("PAQUE VRGA LE MUEVES SI NO SABES HIJO DE TU PUTA MADRE >:(");
                Console.WriteLine("Baii..... >:(");
            }
            else if(respuesta1 == "SI" || respuesta1 == "si")
            {
                Console.WriteLine("va, pero no se vale llorar despues ;)");
                Console.WriteLine("Base de datos eliminada....");
                Console.WriteLine(" ");
                Console.WriteLine("Te cuajas bb, eso no se hace :)");
            }
            else
            {
                Console.WriteLine("Ingresa lo que se te pide para que metes otra cosa");
                Console.WriteLine("Que barbaro, bai...");
            }
        }
        else
        {
           Console.WriteLine("Si yo se que no quieres papito, ya vete a chingar tu maye, bai...."); 
        }
        
    }

    public static void Salir()
    {
        Console.WriteLine("Hasta luego...");
    }



}