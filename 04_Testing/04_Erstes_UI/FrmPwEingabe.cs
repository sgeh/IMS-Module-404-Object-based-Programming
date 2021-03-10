using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bzw.Rappi
{
    public partial class FrmPwEingabe : Form
    {
        public FrmPwEingabe()
        {
            InitializeComponent();
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Möchten Sie wirklich abbrechen?", "Eingabe beenden", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
