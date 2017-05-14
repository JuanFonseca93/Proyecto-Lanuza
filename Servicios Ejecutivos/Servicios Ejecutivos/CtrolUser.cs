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
    
    public partial class CtrolUser : Form
    {
        int x=0;
        public CtrolUser()
        {
            
            InitializeComponent();
            dtgUsers.DataSource = MySqlCon.getUser();
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            cbxNivel.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x==0)
            {
                if (cbxNivel.SelectedIndex > 0 || !txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtUser.Text.Equals("") || !txtPass.Text.Equals(""))
                {
                    if (MySqlCon.NewClient(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtUser.Text, txtPass.Text, cbxNivel.SelectedIndex))
                    {
                        MessageBox.Show("Usuario Guardado");
                        dtgUsers.DataSource = MySqlCon.getUser();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtUser.Enabled = false;
                        txtPass.Enabled = false;
                        cbxNivel.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }else
                {
                    MessageBox.Show("Seleccione un Rango y llene los campos antes de continuar");
                }
            }else
            {
                if (cbxNivel.SelectedIndex > 0 || !txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("")  || !txtUser.Text.Equals("") || !txtPass.Text.Equals(""))
                {
                    if (MySqlCon.upclient(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()) ,txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtUser.Text, txtPass.Text, cbxNivel.SelectedIndex))
                    {
                        MessageBox.Show("Usuario Guardado");
                        dtgUsers.DataSource = MySqlCon.getUser();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtUser.Enabled = false;
                        txtPass.Enabled = false;
                        cbxNivel.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Rango y llene los campos antes de continuar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            cbxNivel.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombre.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cbxNivel.SelectedIndex = 0;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            txtUser.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            cbxNivel.SelectedIndex = Int32.Parse(dtgUsers.CurrentRow.Cells[6].Value.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            cbxNivel.Enabled = true;
            btnGuardar.Enabled = true;
            x = 1;
        }

        private void CtrolUser_Load(object sender, EventArgs e)
        {

        }
        
    }
}
