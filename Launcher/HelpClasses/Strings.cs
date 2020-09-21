namespace Launcher.HelpClasses
{
    internal class Strings
    {
        public class Info
        {
            public static readonly string NOT_SET = "No establecido";

            public static readonly string PATH_CHOOSE = "Selecciona la carpeta con el cliente del juego.";

            public static readonly string INIT = "Inicialización...";

            public static readonly string UPDATE_IN_PROGRESS = "Actualización en progreso...";
            public static readonly string UPDATE_DONE = "Juego actualizado";
        }

        public class Error
        {
            public static readonly string CONNECTION_ERROR = "Error de conexión";
            public static readonly string CONNECTION_ERROR_EXPLAIN = "No se puede conectar a Internet, verifique su conexión e intente nuevamente";

            public static readonly string PATH_ERROR = "Error de ubicación";
            public static readonly string PATH_ERROR_EXPLAIN = "Expediente \"Wow.exe\" extraviado!\nMueva el programa a la carpeta del juego o especifique la ruta a la carpeta del juego!\nMuestre el camino ahora?";

            public static readonly string PATH_CHOOSE_ERROR = "Error de selección de carpeta";
            public static readonly string PATH_CHOOSE_ERROR_EXPLAIN = "В Archivo de carpeta seleccionado \"Wow.exe\" extraviado!\n¡Selecciona la carpeta correcta con el juego! \nIntenta seleccionar de nuevo?";
        }

    }
}