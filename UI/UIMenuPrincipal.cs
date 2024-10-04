using System;
using LogicaMenu;

public class UIMenu
{
    public void UIInicioDeSesion()
    {   
        Console.WriteLine("..::Hola, ingrese sus credenciales para iniciar sesion::..");
        Console.Write("Usuario: ");
        string? usuario = Console.ReadLine();
        Console.Write("Contraseña: ");
        string contrasena = Console.ReadLine();
        Console.WriteLine("");

        if(contrasena == "1234" && usuario == "Cabrera")
        {
            UIMenuPrincipal();
        }   
        else
        {
            Console.WriteLine("Credenciales incorrectas");
            Console.WriteLine("Hasta luego...");
        }
    }

    public void UIMenuPrincipal()
    {
        Console.WriteLine("..::Bienvenido::..");
        Console.WriteLine("1)Visualizar productos en el inventarios \n2)Agregar productos \n3)Eliminar productos \n4)ELIMINAR BASE DE DATOS >:) \n5)Salir");
        Console.WriteLine("");
        int opcion = Convert.ToInt32(Console.ReadLine());
        

        switch(opcion)
        {
            case 1:LogicaDelMenu.ConsultarInventaraio();break;
            case 2:LogicaDelMenu.AgregarProductos();break;
            case 3:/*aqui va una funcion */ ;break;
            case 4:/*aqui va una funcion */ ;break;
            case 5:/*aqui va una funcion */ ;break;
            default: Console.WriteLine("Ingrese solo las opciones mencionadas");break;
        }
    }





}