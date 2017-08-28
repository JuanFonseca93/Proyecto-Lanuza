using iTextSharp.text;
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
using System.Data.SqlClient;

namespace Servicios_Ejecutivos
{
    public partial class Empleados : Form
    {
        public SqlConnection conexionConBD;
        public SqlCommand comando;
        public DataTable dt;
        public SqlDataAdapter adaptador;
        public SqlDataReader dr;


        int x = 0;
        public Empleados()
        {

           


            InitializeComponent();
            dtgEmpleados.DataSource = MySqlCon.getEmp();
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmpresa.Enabled = false;
            txtPuesto.Enabled = false;
            btnColor.Enabled = false;
            btnGuardar.Enabled = false;
            btnfoto0.Enabled = false;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
           
            alternarcolor(dtgEmpleados);
            this.dtgEmpleados.Columns[0].Visible = false;
            this.dtgEmpleados.Columns[6].Visible = false;
            this.dtgEmpleados.Columns[7].Visible = false;
            ToolTip n = new ToolTip();
            ToolTip n2 = new ToolTip();
            ToolTip n3 = new ToolTip();
            ToolTip n4 = new ToolTip();
            ToolTip n5 = new ToolTip();
            ToolTip n6 = new ToolTip();

            n.SetToolTip(btnAgregar, "Agregar nuevo empleado");
            n2.SetToolTip(btnEditar, "Editar datos");
            n3.SetToolTip(btnfoto0, "Agregar foto");
            n4.SetToolTip(btnGuardar, "Guardar");
            n5.SetToolTip(btnAct1, "Activar/Desactivar empleado");
            n6.SetToolTip(btnCancelar, "Cancelar");

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
                        dtgEmpleados.DataSource = MySqlCon.getEmp();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmpresa.Enabled = false;
                        txtPuesto.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Asegurece de llenar los campos antes de continuar");
                }
            }
            else
            {
                if (!txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtEmpresa.Text.Equals("") || !txtPuesto.Text.Equals(""))
                {
                    if (MySqlCon.upEmp(Int32.Parse(dtgEmpleados.CurrentRow.Cells[0].Value.ToString()), txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtEmpresa.Text, txtPuesto.Text, null))
                    {
                        MessageBox.Show("Empleado Editado");
                        dtgEmpleados.DataSource = MySqlCon.getEmp();
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtEmpresa.Enabled = false;
                        txtPuesto.Enabled = false;
                        btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Asegurece de llenar los campos antes de continuar");
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
            btnGuardar.Visible = true;
            btnAgregar.Visible = false;
            btnGuardar.Enabled = true;
            btnfoto0.Enabled = true;
            x = 1;
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnEditar.Enabled = true;
            txtNombre.Text = dtgEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dtgEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtgEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtEmpresa.Text = dtgEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtPuesto.Text = dtgEmpleados.CurrentRow.Cells[5].Value.ToString();
            btnAct1.Enabled = true;
            if (Int32.Parse(dtgEmpleados.CurrentRow.Cells[7].Value.ToString()) ==1 )
            {
                btnColor.BackColor = Color.Green;
                btnColor.Text = "A";
            }else
            {
                btnColor.BackColor = Color.Red;
                btnColor.Text = "I";
            }
            if (!dtgEmpleados.CurrentRow.Cells[6].Value.ToString().Equals(null) && !dtgEmpleados.CurrentRow.Cells[6].Value.ToString().Equals("") && !dtgEmpleados.CurrentRow.Cells[6].Value.ToString().Equals("null"))
            {
                pbxFoto.Image = System.Drawing.Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + dtgEmpleados.CurrentRow.Cells[6].Value.ToString());
            }
            else
            {
                pbxFoto.Image = System.Drawing.Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Default.jpg");
            }

        }

        
        private void btnfoto0_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String imagen = openFileDialog1.FileName;
                pbxFoto.Image = System.Drawing.Image.FromFile(imagen);

                if (!Directory.Exists("c:\\Taxi_Ejecutivo\\Fotos\\Empleados"))
                {
                    Directory.CreateDirectory("c:\\Taxi_Ejecutivo\\Fotos\\Empleados\\");
                    File.Copy(imagen, "c:\\Taxi_Ejecutivo\\Fotos\\Empleados\\" + txtNombre.Text + ".jpg", true);
                    imagen = Path.GetFileName("c:\\Taxi_Ejecutivo\\Fotos\\Empleados\\" + txtNombre.Text + ".jpg");
                }
                else
                {
                    File.Copy(imagen, "c:\\Taxi_Ejecutivo\\Fotos\\Empleados\\" + txtNombre.Text + ".jpg", true);
                    imagen = Path.GetFileName("c:\\Taxi_Ejecutivo\\Fotos\\Empleados\\" + txtNombre.Text + ".jpg");
                }
            }
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
            btnEditar.Visible = true;

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              if (Int32.Parse(dtgEmpleados.CurrentRow.Cells[7].Value.ToString())==1)
             {
                 if (MySqlCon.upAcEmp(Int32.Parse(dtgEmpleados.CurrentRow.Cells[0].Value.ToString()),0))
                 {
                     MessageBox.Show("Empleado Inactivo");
                     dtgEmpleados.DataSource = MySqlCon.getEmp();
                     txtDireccion.Enabled = false;
                     txtNombre.Enabled = false;
                     txtTelefono.Enabled = false;
                     txtEmpresa.Enabled = false;
                     txtPuesto.Enabled = false;
                     btnAct1.Enabled = false;
                     btnGuardar.Enabled = false;
                 }
             }else
             {
                 if(MySqlCon.upAcEmp(Int32.Parse(dtgEmpleados.CurrentRow.Cells[0].Value.ToString()), 1))
                 {
                     MessageBox.Show("Empleado Inactivo");
                     dtgEmpleados.DataSource = MySqlCon.getEmp();
                     txtDireccion.Enabled = false;
                     txtNombre.Enabled = false;
                     txtTelefono.Enabled = false;
                     txtEmpresa.Enabled = false;
                     txtPuesto.Enabled = false;
                     btnAct1.Enabled = false;
                     btnGuardar.Enabled = false;
                 }
             }
        }

        private void gbEmpleados_Enter(object sender, EventArgs e)
        {

        }

        public void alternarcolor(DataGridView dgv)
        {

            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }




        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

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
    }
}
