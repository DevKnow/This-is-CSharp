using System;
using System.Windows.Forms;

namespace _20장_UsingApplication_706page
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click+= new EventHandler((sender, eventArgs) =>
            {
                Console.WriteLine("Closing Window...");
                Application.Exit();
            });

            Console.WriteLine("Starting Window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
        }
    }
}
