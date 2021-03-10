using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 04
/// Thema: Erstes UI anlegen
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2021 -
/// </summary>
namespace Bzw.Rappi
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPwEingabe());
        }
    }
}
