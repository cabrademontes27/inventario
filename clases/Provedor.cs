using System;


public class Provedor{

    
    protected string? Nombre;
    protected string? Empresa;
    protected string? Telefono;
    /*
    public Provedor(string _nombreProvedor, string _empresaProvedor, string _telefonoProvedor){
        this.Nombre = _nombre;
        this.Empresa = _empresa;
        this.Telefono = _telefono;
    }
    */
    // al parecer se puede omitir para no agregarle valores,


    public void ingresarProvedor(){
        bool validar1 = true;
        bool validar2 = true;
        bool validar3 = true;

        // agregar validacion sobre si el valor a recibir es nulo o vacio -- CUMPLIDO
        while(validar1){
            Console.WriteLine("Nombre del provedor");
            Nombre = Console.ReadLine();
            if(!string.IsNullOrEmpty(Nombre) &&validarInformacion.Nombres(Nombre) == false){
                Console.WriteLine("se agrego correctamente el nombre");
                validar1 = false;
            }else{
                Console.WriteLine("El texto contiene caracteres raros o esta ingresando texto vacio, intentelo nuevamente");
            }
        }

        while(validar2){
            Console.WriteLine("Nombre de la empresa");
            Empresa = Console.ReadLine();
            if(!string.IsNullOrEmpty(Empresa) && validarInformacion.Nombres(Empresa) == false){
                Console.WriteLine("se agrego correctamente la empresa");
                validar2 = false;
            }else{
                Console.WriteLine("El texto contiene caracteres raros o esta ingresando texto vacio, intentelo nuevamente");
            }
        }

    
        while(validar3){
            Console.WriteLine("Numero Telefonico ");
            Telefono = Console.ReadLine();
          
            if( !string.IsNullOrEmpty(Telefono) && validarInformacion.Telefonos(Telefono)){
                Console.WriteLine("se agrego correctamente el telefono");
                validar3 = false;
            }else{
                Console.WriteLine("El numero telefonico  contiene caracteres raros o ingreso un numero de mas, intentelo nuevamente");
            }
        }



        
        
        
    }
}

// me falta terminar la clase que valide si los datos ingresados son texto -- HECHO
// empezar a pasar los datos a la base de datos, y separa la clase conxion o hacerlo mas sencilla