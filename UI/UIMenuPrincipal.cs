using System;
using LogicaMenu;

public static class UIMenu
{
    public static void UIInicioDeSesion()
    {
        Console.WriteLine("..::Hola, ingrese sus credenciales para iniciar sesion::..");
        Console.Write("Usuario: ");
        string? usuario = Console.ReadLine();
        Console.Write("Contraseña: ");
        string? contrasena = Console.ReadLine();
        Console.WriteLine("");

        if (contrasena == "1234" && usuario == "Cabrera")
        {
            Console.WriteLine("..::Bienvenido::..");
            UIMenuPrincipal();
        }
        else
        {
            Console.WriteLine("Credenciales incorrectas");
            Console.WriteLine("Hasta luego...");
        }
    }

    public static void UIMenuPrincipal()
    {
        Console.WriteLine("1)Visualizar productos en el inventarios \n2)Agregar productos \n3)Eliminar productos \n4)Salir");
        Console.WriteLine("");
        int opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1: LogicaDelMenu.ConsultarInventaraio(); break; //bien
            case 2: LogicaDelMenu.ingresarProducto(); break; //
            case 3: LogicaDelMenu.EliminarProducto() /*logica*/ ; break;
            case 4: LogicaDelMenu.Salir(); break;
            default: Console.WriteLine("Ingrese solo las opciones mencionadas"); break;
        }
    }





}
