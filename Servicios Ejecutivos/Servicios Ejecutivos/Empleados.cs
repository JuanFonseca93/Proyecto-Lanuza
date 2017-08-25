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
          //  btnAct.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
          //  btnAct.Visible = false;
         
            btnGuardar.Visible = false;
            btnEditar.Enabled = false;

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
                       // btnAct.Enabled = false;
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
                     //   btnAct.Enabled = false;
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
            gbEmpleados.Enabled = true;
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
            btnEditar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbEmpleados.Enabled = true;
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmpresa.Enabled = true;
            txtPuesto.Enabled = true;
            // btnAct.Enabled = true;
            btnGuardar.Visible = true;
            btnAgregar.Visible = false;
            btnGuardar.Enabled = true;
            x = 1;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            txtNombre.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtEmpresa.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtPuesto.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
          /*  if (Int32.Parse(dtgUsers.CurrentRow.Cells[7].Value.ToString())==1)
            {
                if (MySqlCon.upAcEmp(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()),0))
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
                if(MySqlCon.upAcEmp(Int32.Parse(dtgUsers.CurrentRow.Cells[0].Value.ToString()), 1))
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
            }*/

        }

        private void btnfoto0_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbEmpleados.Enabled = false;
            
            txtDireccion.ResetText();
            txtEmpresa.ResetText();
            txtNombre.ResetText();
            txtPuesto.ResetText();
            txtTelefono.ResetText();
            btnAgregar.Visible = true;
            btnEditar.Enabled = false;
            btnGuardar.Visible = false;

            
        }
    }
}
