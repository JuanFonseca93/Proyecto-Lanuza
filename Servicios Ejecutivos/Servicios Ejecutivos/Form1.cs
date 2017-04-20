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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( MySqlCon.checkUser(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Bienvenido");
                Menu_Principal open = new Menu_Principal();
                open.Visible = true;
                this.Visible = false;
            }else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
