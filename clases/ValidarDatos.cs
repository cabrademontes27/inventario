using System;
namespace ValidarDatos;

public static class validarInformacion{

    public static bool Nombres(string texto){
        
        //-1 indica que no hay caracteres raros
        char[] caracteresRaros = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '='};
        if(texto.IndexOfAny(caracteresRaros) ==  -1){
            return false;
        }else {
            return true;
        }
    } 

    public static bool Telefonos(string numeroTelefonico){
        int longitud = numeroTelefonico.Length;
        char[] numerosValidos = {'0','1','2','3','4','5','6','7','8','9'};
        
        if(longitud == 10){
            //el -1 aqui indica que si hay otros valores no permitidos 
            foreach(char c in numeroTelefonico){
                    if(Array.IndexOf(numerosValidos, c) == -1){
                    return false;
                }
            }
            return true;
        }else{
            return false;
        }  
    }

    public static bool Precios(string numeros){
        char[] numerosValidos = {'0','1','2','3','4','5','6','7','8','9'};
        
        int longitud = numeros.Length;
        if(longitud >= 0 && longitud <= 5){
            foreach(char c in numeros){
                if(Array.IndexOf(numerosValidos, c) == -1){
                return false;
            }
        }
            return true;
        }else{
            return false;
        }
    }

    public static bool numerosValidos(string numeros){
        char[] arregloNumerosValidos = {'0','1','2','3','4','5','6','7','8','9'};
        
       
        if(numeros != null){
            foreach(char c in numeros){
                if(Array.IndexOf(arregloNumerosValidos, c) == -1){
                return false;
            }
        }
            return true;
        }else{
            return false;
        }
    }

    public static bool NumerosNulosVacios(string opcion)
    {
         if((string.IsNullOrEmpty(opcion)) == false)
        {
            if((validarInformacion.numerosValidos(opcion)) == true)
            {
                return false;
            }else{Console.WriteLine("El dato ingresado contien caracteres raros, intete nuevamente"); return true;}
        }else{Console.WriteLine("El valor es nulo o contiene nada, intente nuevamente"); return true;}
    }

    public static String FechaParciada(String fechaIngresada)
    {
        DateTime fecha = DateTime.Parse(fechaIngresada);
        
        
       return fecha.ToString("dd/MM/yyyy");
    }



}
//Para validar caracter
// me falta validar si una cadena contiene caracteres raros, deben ser solo letras --CUMPLIDO   