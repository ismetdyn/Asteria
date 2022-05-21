using Asteria.Entity;
using Asteria.Presentation.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteria.Presentation
{
    static class Program
    {
        public static Kullanici kullanici;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(InitializeForm.Current);
        }
    }
}
