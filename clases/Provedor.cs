using System;


public class Provedor{

    protected string? Nombre;
    protected string? Empresa;
    protected string? Telefono;
    public Provedor(string _nombre, string _empresa, string _telefono){
        this.Nombre = _nombre;
        this.Empresa = _empresa;
        this.Telefono = _telefono;
    }


    public void ingresarProvedor(){
        bool validar1 = true;
        bool validar2 = true;
        bool validar3 = true;


        while(validar1){
            Console.WriteLine("Nombre del provedor");
            Nombre = Console.ReadLine();
            if(validarInformacion.Texto(Nombre) == false){
                Console.WriteLine("se agrego correctamente el nombre");
                validar1 = false;
            }else{
                Console.WriteLine("El texto contiene caracteres raros, intentelo nuevamente");
            }
        }

        while(validar2){
            Console.WriteLine("Nombre de la empresa");
            Empresa = Console.ReadLine();
            if(validarInformacion.Texto(Empresa) == false){
                Console.WriteLine("se agrego correctamente la empresa");
                validar2 = false;
            }else{
                Console.WriteLine("El texto contiene caracteres raros, intentelo nuevamente");
            }
        }

    
        while(validar3){
            Console.WriteLine("Numero Telefonico ");
            Telefono = Console.ReadLine();
            if(validarInformacion.Numero(Telefono) == true){
                Console.WriteLine("se agrego correctamente el telefono");
                validar3 = false;
            }else{
                Console.WriteLine("El numero telefonico  contiene caracteres raros, intentelo nuevamente");
            }
        }



        
        
        
    }
}

// me falta terminar la clase que valide si los datos ingresados son texto