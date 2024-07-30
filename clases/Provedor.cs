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
        
        while(validarInformacion.validarDato()){

        }



        Console.WriteLine("Nombre del provedor");
        Nombre = Console.ReadLine();
        Console.WriteLine("Nombre de la empresa");
        Empresa = Console.ReadLine();
        Console.WriteLine("Numero Telefonico ");
        Telefono = Console.ReadLine();
    }
}

// me falta terminar la clase que valide si los datos ingresados son texto