using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Servicios_Ejecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("c:\\Taxi_Ejecutivo"))
            {
                Directory.CreateDirectory("c:\\Taxi_Ejecutivo");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            iniciar_sesion();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
          //  txtPass.Clear();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            txtPass.ForeColor = Color.Black;
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }

            //txtPass.UseSystemPasswordChar = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUser.ForeColor = Color.Black;
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        public void iniciar_sesion()
        {
            try
            {
                DataTable dt = MySqlCon.checkUser(txtUser.Text, txtPass.Text);
                DataRow rw = dt.Rows[0];
                if (rw["Alias"].ToString().Equals(txtUser.Text) && rw["Pass"].ToString().Equals(txtPass.Text))
                {
                    Menu_Principal OP = new Menu_Principal(Int32.Parse(rw["Id_Usuario"].ToString()));
                    OP.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar_sesion();
            }
            else{


            }
        }


    }
}
