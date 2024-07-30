using System;


public static class validarInformacion{

    public static bool validarDato(string dato){
        
        char[] caracteresRaros = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '='};
        if(dato.IndexOfAny(caracteresRaros) ==  -1){
            return false;
        }else {
            return true;
        }

    } 


}

// me falta validar si una cadena contiene caracteres raros, deben ser solo letras --CUMPLIDO   