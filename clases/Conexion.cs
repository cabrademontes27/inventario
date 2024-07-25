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
                string sql = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

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
}
