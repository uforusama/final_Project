using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessclub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new trn());
            //Application.Run(new tfetch());
            //Application.Run(new menu());
            Application.Run(new login());
           // Application.Run(new Pable());
            //Application.Run(new Expencefetch());
            
            

            Trainer trainer1 = new Trainer();
            Expence p1 = new Expence();
            p1.agert(trainer1);

            
           Employee employee1 = new Employee();
           p1.agere(employee1);
           
        }
    }
}
