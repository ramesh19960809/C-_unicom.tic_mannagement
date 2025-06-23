using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseManager.InitializeDatabase();

            Application.Run(new LoginForm());
        }

    }
}
