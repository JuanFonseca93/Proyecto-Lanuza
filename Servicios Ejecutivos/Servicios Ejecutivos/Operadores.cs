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
    public partial class Operadores : Form
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            estatus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Unidad_Click(object sender, EventArgs e)
        {

        }
        public void estatus()
        {
            if(checkBox1.Checked == true){
                MessageBox.Show("usuario activo");
                btncolor.BackColor = Color.LightGreen;

            }else
            {
                MessageBox.Show("usuario inactivo");
                btncolor.BackColor = Color.Red;
            }
            
        }

        private void Operadores_Load(object sender, EventArgs e)
        {

        }
    }
}
