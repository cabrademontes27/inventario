using System;


public class Producto{


    protected string? Nombre;
    protected string? Precio;
    protected string? caducidad;
    protected string? Provedor;

    /*
    public Producto(string? _nombreProducto, int? _precioProducto, string? _caducidadProducto, string? _provedorProducto){
        this.Nombre = _nombreProducto;
        this.Precio = _precioProducto;
        this.caducidad = _caducidadProducto;
        this.Provedor = _provedorProducto;
    }
    */
    


    public void IntegrarProducto(){
        bool validar1 = true;
        bool validar2 = true;
        bool validar3 = true;



        while(validar1){
            Console.WriteLine("Nombre del producto");
            Nombre = Console.ReadLine();

            if(!string.IsNullOrEmpty(Nombre) && validarInformacion.Nombres(Nombre)){
                Console.WriteLine("Se agrego correctamente el producto");
                validar1 = false;
            }else{
                Console.WriteLine("El texto contiene caracteres raros o esta ingresando texto vacio, intentelo nuevamente");
            }
        }
        
        while(validar2){
            Console.WriteLine("precio del producto");
            Precio = Console.ReadLine();

            if(!string.IsNullOrEmpty(Precio) && validarInformacion.Numeros(Precio)){
                Console.WriteLine("Se agrego correctamente el precio del producto");
                validar1 = false;
            }else{
                Console.WriteLine("El precio contiene caracteres raros o esta ingresando texto vacio, intentelo nuevamente");
            }
        }
        //este sera sobre provedor, pero no entiendo como se supone si en una base de datos esta clase o aqui seria su llave foranea de la clase provedor 
        //deberia hacer que reciviera o una comparacion y si es alguno de los provedores, asignarle un id ????/
        while(validar3){
            
        }






    }
}