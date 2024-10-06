
using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;


public static class conexionSQL{


    public static void AnadirProductos(string Nombre, string Categoria, string Precio)
    {
        DateTime Fecha_Ingreso = DateTime.Now;
        string Conexion = "Server=localhost;Database=INVENTARIO;User ID=root;Password= ;SslMode=none";
        
        using(MySqlConnection conexion1 = new MySqlConnection(Conexion))
        {
            try
            {
                conexion1.Open();
                string consulta = $"INSERT INTO PRODUCTO(Nombre, categoria,Precio,Fecha_ingreso) VALUES(@Nombre, @Categoria,@Precio,@Fecha_Ingreso)";
                
                using(MySqlCommand ejercutarConsulta = new MySqlCommand(consulta,conexion1))
                {
                    ejercutarConsulta.Parameters.AddWithValue("@Nombre",Nombre);
                    ejercutarConsulta.Parameters.AddWithValue("@Categoria",Categoria);
                    ejercutarConsulta.Parameters.AddWithValue("@Precio",Precio);
                    ejercutarConsulta.Parameters.AddWithValue("@Fecha_Ingreso",Fecha_Ingreso);

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio algo inesperado {ex}");
            }
        }
    }

     public static void AnadirProductos(string Nombre, string Precio)
    {
        DateTime Fecha_Ingreso = DateTime.Now;
        string Conexion = "Server=localhost;Database=INVENTARIO;User ID=root;Password= ;SslMode=none";
        
        using(MySqlConnection conexion1 = new MySqlConnection(Conexion))
        {
            try
            {
                conexion1.Open();
                string consulta = $"INSERT INTO PRODUCTO(Nombre, Precio, Fecha_ingreso) VALUES(@Nombre,@Precio,@Fecha_Ingreso)";
                
                using(MySqlCommand ejercutarConsulta = new MySqlCommand(consulta,conexion1))
                {
                    ejercutarConsulta.Parameters.AddWithValue("@Nombre",Nombre);
                    ejercutarConsulta.Parameters.AddWithValue("@Precio",Precio);
                    ejercutarConsulta.Parameters.AddWithValue("@Fecha_Ingreso",Fecha_Ingreso);

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio algo inesperado {ex}");
            }
        }
    }



    public static void VisualizarProductos()
    {
        string Conexion = "Server=localhost;Database=INVENTARIO;User ID=root;Password= ;SslMode=none";

        //es usado para que cuando el objeto o funcion deja de usarse 
        //se cierre una vez terminado el bloque
        using(MySqlConnection conexion1 = new MySqlConnection(Conexion))
        {
            try
            {
                conexion1.Open();
                string consulta = "SELECT Nombre,categoria,Precio,Fecha_ingreso FROM PRODUCTO";
                MySqlCommand ejecutarConsulta = new MySqlCommand(consulta,conexion1);

                using(MySqlDataReader almacenaConsulta = ejecutarConsulta.ExecuteReader())
                {
                    while(almacenaConsulta.Read())
                    {
                       Console.WriteLine($"Nombre:  {almacenaConsulta.GetString(0)}");
                       Console.WriteLine($"Categoria: {almacenaConsulta.GetString(1)}");
                       Console.WriteLine($"Precio: {almacenaConsulta.GetString(2)}");
                       Console.WriteLine($"Fecha de ingreso: {almacenaConsulta.GetString(3)}");
                       Console.WriteLine("\n ");
                    }
                }

            }   
            catch(Exception ex)
            {
                Console.WriteLine($"Ocurrio algo inesperado: {ex}" );
            }     
        }
    }
}



/*
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
*/
// modificar esta clase para que haga la conexion con cualquier dato que entre o sea cambiar todo 