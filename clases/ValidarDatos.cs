using System;


public static class validarInformacion{

    public static bool Texto(string texto){
        
        //-1 indica que no hay caracteres raros
        char[] caracteresRaros = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '='};
        if(texto.IndexOfAny(caracteresRaros) ==  -1){
            return false;
        }else {
            return true;
        }
    } 

    public static bool Numero(string numero){
        
        char[] numerosValidos = {'0','1','2','3','4','5','6','7','8','9'};
        
        //el -1 aqui indica que si hay otros valores no permitidos 
        foreach(char c in numero){
            if(Array.IndexOf(numerosValidos, c) == -1){
                return false;
            }
        }
         return true;
       
    }


}
//Para validar caracter
// me falta validar si una cadena contiene caracteres raros, deben ser solo letras --CUMPLIDO   