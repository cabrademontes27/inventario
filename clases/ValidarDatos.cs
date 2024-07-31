using System;


public static class validarInformacion{

    public static bool ValidarTexto(string texto){
        
        char[] caracteresRaros = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '='};
        if(texto.IndexOfAny(caracteresRaros) ==  -1){
            return false;
        }else {
            return true;
        }
    } 

    public static bool ValidarNumero(string numero){
        
        char[] numerosValidos = {'0','1','2','3','4','5','6','7','8','8'};
        foreach(char c in numero){
            // terminar para buscar numeros distintos de los validos
        }
    }


}

// me falta validar si una cadena contiene caracteres raros, deben ser solo letras --CUMPLIDO   