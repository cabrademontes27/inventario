using System;
using Productos;
using Conexion;
namespace LogicaMenu;


public static class LogicaDelMenu
{
    public static void ConsultarInventaraio()
    {
        conexionSQL.VisualizarProductos();
        UIMenu.UIMenuPrincipal();
    }

    public static void ingresarProducto()
    {

    }
    public static void EliminarProducto()
    {

    }
    public static void Salir()
    {

    }
}
