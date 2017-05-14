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
    public partial class Empleados : Form
    {
        int x = 0;
        public Empleados()
        {
            InitializeComponent();
            dtgUsers.DataSource = MySqlCon.getEmp();
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmpresa.Enabled = false;
            txtPuesto.Enabled = false;
            btnAct.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                if (!txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtEmpresa.Text.Equals("") || !txtPuesto.Text.Equals(""))
                {
                    if (MySqlCon.NewEmp(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmpresa.Text, txtPuesto.Text,null))
                    {
                        MessageBox.Show("Empleado Guardado");
                        dtgUsers.DataSource = MySqlCon.getEmp();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmpresa.Enabled = false;
                        txtPuesto.Enabled = false;
                        btnAct.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Rango y llene los campos antes de continuar");
                }
            }
            else
            {
                if (!txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtEmpresa.Text.Equals("") || !txtPuesto.Text.Equals(""))
                {
                    if (MySqlCon.upEmp(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmpresa.Text, txtPuesto.Text, null))
                    {
                        MessageBox.Show("Empleado Editado");
                        dtgUsers.DataSource = MySqlCon.getEmp();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmpresa.Enabled = false;
                        txtPuesto.Enabled = false;
                        btnAct.Enabled = false;
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
            txtEmpresa.Enabled = true;
            txtPuesto.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmpresa.Text = "";
            txtPuesto.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmpresa.Enabled = true;
            txtPuesto.Enabled = true;
            btnAct.Enabled = true;
            btnGuardar.Enabled = true;
            x = 1;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtEmpresa.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtPuesto.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(dtgUsers.CurrentRow.Cells[7].Value.ToString())==1)
            {
                if (MySqlCon.upAcEmp(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()),false))
                {
                    MessageBox.Show("Empleado Guardado");
                    dtgUsers.DataSource = MySqlCon.getEmp();
                    txtDireccion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtEmpresa.Enabled = false;
                    txtPuesto.Enabled = false;
                    btnAct.Enabled = false;
                    btnGuardar.Enabled = false;
                }
            }else
            {
                if(MySqlCon.upAcEmp(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()), true))
                {
                    MessageBox.Show("Empleado Guardado");
                    dtgUsers.DataSource = MySqlCon.getEmp();
                    txtDireccion.Enabled = false;
                    txtNombre.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtEmpresa.Enabled = false;
                    txtPuesto.Enabled = false;
                    btnAct.Enabled = false;
                    btnGuardar.Enabled = false;
                }
            }
        }
    }
}
