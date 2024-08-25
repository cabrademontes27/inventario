using System;
using Org.BouncyCastle.Crypto.Engines;

public class InteraccionUsario
{
    public int Opciones()
    {
        string? opcion = "";
        bool validadorBucle = true;
        
        Console.WriteLine("------------------------------------MENU------------------------------------");
        Console.WriteLine("Hola, que categoria desea visualizar");
        Console.WriteLine(" 1) Abarrotes \n 2) Frutas y verduras \n 3) Bebidas");
        
        while(validadorBucle)
        {
            opcion = Console.ReadLine();
            if(validarInformacion.NumerosNulosVacios(opcion) == false)
            {
                int retornar = Convert.ToInt16(opcion);
                    switch(retornar)
                    {
                        case 1: validadorBucle = false; return 1;
                        case 2: validadorBucle = false; return 2;
                        case 3: validadorBucle = false; return 3;
                        default: Console.WriteLine("Seleccione una de las opciones");break;
                    }
            } 
        }  
        return 0;
    }

    







}
