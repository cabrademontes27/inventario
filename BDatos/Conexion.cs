/*
using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;


public static class conexionSQL{
    public static void conexion(){

        string conexcionString = "Server=localhost;Database=inventario;User ID=root;Password=2704;SslMode=none;";

        using (MySqlConnection conn = new MySqlConnection(conexcionString))
        {
            try
            {
                // Abrir la conexión
                conn.Open();

                // Crear un comando
                //consulta = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);

                // Ejecutar el comando y obtener un lector de datos
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Leer los datos (ejemplo: primera columna como string)
                        string valor = reader.GetString(1);
                        Console.WriteLine(valor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    public static void addProductDatabase()
    {

    }

    public static void delateProductDatabase()
    {


    }

    public static void readProductDatabase(string consulta, string columna  )
    {
        string conecxionTexto = "Server=localhost;Database=inventario;User ID=root;Password=2704;SslMode=none;";

        using (MySqlConnection conection1 = new MySqlConnection(conecxionTexto))
        {
            try
            {
                // Abrir la conexión
                conection1.Open();

                // Crear un comando
                //consulta = "SELECT * FROM productos";
                MySqlCommand ejecutarConsulta = new MySqlCommand(consulta, conection1);

                // Ejecutar el comando y obtener un lector de datos
                using (MySqlDataReader almacenadorConsulta = ejecutarConsulta.ExecuteReader())
                {
                    while (almacenadorConsulta.Read())
                    {
                        // Leer los datos (ejemplo: primera columna como string)
                        string valor = almacenadorConsulta.GetString(columna);
                        Console.WriteLine(valor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }





}

// modificar esta clase para que haga la conexion con cualquier dato que entre o sea cambiar todo 

*/