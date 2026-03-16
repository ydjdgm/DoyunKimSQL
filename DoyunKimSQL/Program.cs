namespace DoyunKimSQL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IModel model = new Model();
            IController controller = new Controller();
            Form1 view = new Form1();

            model.View = view;
            model.Controller = controller;
            view.Model = model;
            view.Controller = controller;
            controller.Model = model;
            controller.View = view;
            view.SetGridData();

            Application.Run(view);
        }
    }
}