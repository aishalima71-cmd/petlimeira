using PetLimeira.Forms;

namespace PetLimeira
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // obter a resposta do formulario de login para determinar
            // se abre o sistema ou não.
            var login = new loginForm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}