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
            txtEstado.Enabled = false;
            txtMunicipio.Enabled = false;
            cbxNivel.Enabled = false;

            btnGuardar.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals(txtRC.Text))
            {
                if (x == 0)
                {
                    if (cbxNivel.SelectedIndex > 0 || !txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtMunicipio.Text.Equals("") || !txtEstado.Text.Equals("") || !txtUser.Text.Equals("") || !txtPass.Text.Equals(""))
                    {
                        if (MySqlCon.NewClient(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtMunicipio.Text, txtMunicipio.Text, txtUser.Text, txtPass.Text, cbxNivel.SelectedIndex))
                        {
                            MessageBox.Show("Usuario Guardado");
                            dtgUsers.DataSource = MySqlCon.getUser();
                            txtDireccion.Enabled = false;
                            txtNombre.Enabled = false;
                            txtTelefono.Enabled = false;
                            txtUser.Enabled = false;
                            txtPass.Enabled = false;
                            txtEstado.Enabled = false;
                            txtMunicipio.Enabled = false;
                            cbxNivel.Enabled = false;
                            btnGuardar.Visible = false;
                            btnCancelar.Visible = false;
                            btnNuevo.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Rango y llene los campos antes de continuar");
                    }
                }
                else
                {
                    if (cbxNivel.SelectedIndex > 0 || !txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtMunicipio.Text.Equals("") || !txtEstado.Text.Equals("") || !txtUser.Text.Equals("") || !txtPass.Text.Equals(""))
                    {
                        if (MySqlCon.upclient(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtMunicipio.Text, txtMunicipio.Text, txtUser.Text, txtPass.Text, cbxNivel.SelectedIndex))
                        {
                            MessageBox.Show("Usuario Guardado");
                            dtgUsers.DataSource = MySqlCon.getUser();
                            txtDireccion.Enabled = false;
                            txtNombre.Enabled = false;
                            txtTelefono.Enabled = false;
                            txtUser.Enabled = false;
                            txtPass.Enabled = false;
                            txtEstado.Enabled = false;
                            txtMunicipio.Enabled = false;
                            cbxNivel.Enabled = false;
                            btnGuardar.Visible = false;
                            btnCancelar.Visible = false;
                            btnNuevo.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Rango y llene los campos antes de continuar");
                    }
                }

                }else
            {




            

                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEstado.Enabled = true;
            txtMunicipio.Enabled = true;
            cbxNivel.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombre.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cbxNivel.SelectedIndex = 0;
            txtRC.Visible = true;
            lblRC.Visible = true;
            dtgUsers.Enabled = false;
            btnGuardar.Visible = true;
          //  btnEditar.Visible = false;
            btnCancelar.Visible = true;
            btnNuevo.Visible = false;
            x = 0;




        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgUsers.Visible = true;
            txtNombre.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            txtEstado.Text = dtgUsers.CurrentRow.Cells[6].Value.ToString();
            txtMunicipio.Text = dtgUsers.CurrentRow.Cells[7].Value.ToString();
            txtUser.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            cbxNivel.SelectedIndex = Int32.Parse(dtgUsers.CurrentRow.Cells[8].Value.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEstado.Enabled = true;
            txtMunicipio.Enabled = true;
            cbxNivel.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnNuevo.Visible = false;
            x = 1;
        }

        private void CtrolUser_Load(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            txtRC.Visible = false;
            lblRC.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtgUsers.Enabled = true;
            limpiar();
            block();
            btnGuardar.Visible = false;
            btnNuevo.Visible = true;
          //  btnEditar.Visible = true;
            btnCancelar.Visible = false;

        }


        public void limpiar()
        {
            txtDireccion.Clear();
            txtEstado.Clear();
            txtMunicipio.Clear();
            txtNombre.Clear();
            txtPass.Clear();
            txtRC.Clear();
            txtTelefono.Clear();
            txtUser.Clear();
            


        }
        public void block()
        {
            txtDireccion.Enabled = false;
            txtEstado.Enabled = false;
            txtMunicipio.Enabled = false;
            txtNombre.Enabled = false;
            txtPass.Enabled = false;
            txtRC.Enabled = false;
            txtTelefono.Enabled = false;
            txtUser.Enabled = false;
            cbxNivel.Enabled = false;

        }

        private void dtgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEstado.Enabled = true;
            txtMunicipio.Enabled = true;
            cbxNivel.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnNuevo.Visible = false;
            x = 1;
        }
    }
}
