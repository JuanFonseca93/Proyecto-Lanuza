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
        string id;
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
                if (cbxNivel.SelectedIndex > 0 && !txtNombre.Text.Equals("") && !txtDireccion.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtUser.Text.Equals("") && !txtPass.Text.Equals(""))
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
                if (cbxNivel.SelectedIndex > 0 && !txtNombre.Text.Equals("") && !txtDireccion.Text.Equals("") && !txtTelefono.Text.Equals("")  && !txtUser.Text.Equals("") && !txtPass.Text.Equals(""))
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

                des();

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
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cbxNivel.SelectedIndex = 0;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n;
            txtNombre.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            txtUser.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            id = dtgUsers.CurrentRow.Cells[0].Value.ToString();
            n = Int32.Parse(dtgUsers.CurrentRow.Cells[6].Value.ToString());
            btnEdit.Enabled = true;
            btnEliminar.Enabled = true;
            if (n == 0)
            {
                cbxNivel.Text = "Administrador";
            }
            else
            {
                cbxNivel.Text = "Usuario";
            }


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
            this.dtgUsers.Columns[0].Visible = false;
            this.dtgUsers.Columns[6].Visible = false;
            btnEdit.Enabled = false;
            btnGuardar.Enabled = false;
            alternarcolor(dtgUsers);
            ToolTip n = new ToolTip();
            ToolTip n1 = new ToolTip();
            ToolTip n2 = new ToolTip();
            ToolTip n3 = new ToolTip();
            ToolTip n4 = new ToolTip();
            n.SetToolTip(btnGuardar,"Guardar");
            n2.SetToolTip(btnGuardar, "Eliminar");
            n3.SetToolTip(btnAgregar, "Registrar nuevo");
            n4.SetToolTip(btnCancelar, "Cancelar");
            n1.SetToolTip(btnEdit, "Editar");
            btnEliminar.Enabled = false;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
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

        public void alternarcolor(DataGridView dgv)
        {

            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            des();
           
        }

        public void des()
        {
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            cbxNivel.Enabled = false;
            btnGuardar.Enabled = false;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cbxNivel.SelectedIndex = 0;
            btnEdit.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que desea eliminar el usuario?","salir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MySqlCon.delclient(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Usuario eliminado");
                dtgUsers.DataSource = MySqlCon.getUser();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }

           
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
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
    }
}
