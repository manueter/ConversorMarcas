namespace ConversorMarcas_Forms
{
    using ConversorMarcas.Procesos;
    internal static class Program
    {
        static Sesion sesion;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IniciarSesion();
            Application.Run(new Inicio(sesion));
        }

        public static bool IniciarSesion() 
        {
            sesion = new Sesion();
            return true;
        }
    }
}