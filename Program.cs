using System;
using Productos;

class Program{

    public static void Main(){
        
        Producto producto1 = new Producto();
        producto1.AñadirProductos("Gansito",15.50);
        producto1.AñadirProductos("Galletas", 15.50,"Abarrotes");
        producto1.AñadirProductos("pan",123);

        producto1.MostrarListaDeProductos();    



        
    }
}

