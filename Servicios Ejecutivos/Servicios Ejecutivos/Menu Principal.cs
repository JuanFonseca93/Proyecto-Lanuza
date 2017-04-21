using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Ejecutivos
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CtrolUser open = new CtrolUser();
            open.MdiParent = this;
            open.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
