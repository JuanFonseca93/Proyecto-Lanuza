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

namespace Servicios_Ejecutivos
{
    public partial class btnFoto : Form
    {
        int x = 0, y = 0;
        DateTime hoy = DateTime.Today;
        String imagen;
        public btnFoto()
        {
            InitializeComponent();
            dgvOperadores.DataSource = MySqlCon.getOp();
            cbxVehiculo.DataSource = MySqlCon.getIDveh();
            cbxVehiculo.DisplayMember = "Id_Vehiculo";
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtUnidad.Enabled = false;
            btnGuardar.Enabled = false;
            cbxVehiculo.Enabled = false;
            btnfoto0.Enabled = false;
            DateTime hoy = DateTime.Today;
            if (!Directory.Exists("c:\\Taxi_Ejecutivo\\Fotos\\Operadores"))
            {
                Directory.CreateDirectory("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Unidad_Click(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUnidad.Enabled = true;
            btnGuardar.Enabled = true;
            cbxVehiculo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
        
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUnidad.Enabled = true;
            btnGuardar.Enabled = true;
            cbxVehiculo.Enabled = true;
            btnfoto0.Enabled = true;
            x = 1;
        }

        private void btnfoto0_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagen = openFileDialog1.FileName;
                pbxFoto.Image = Image.FromFile(imagen);

                if (!Directory.Exists("c:\\Taxi_Ejecutivo\\Fotos\\Operadores"))
                {
                    Directory.CreateDirectory("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\");
                    File.Copy(imagen, "c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + txtNombre.Text + ".jpg", true);
                    imagen = Path.GetFileName("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + txtNombre.Text + ".jpg");
                    Console.WriteLine(imagen);
                }
                else
                {
                    File.Copy(imagen, "c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + txtNombre.Text + ".jpg", true);
                    imagen = Path.GetFileName("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + txtNombre.Text + ".jpg");
                    Console.WriteLine(imagen);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFoto_Load(object sender, EventArgs e)
        {
            ToolTip n = new ToolTip();
            ToolTip n1 = new ToolTip();
            ToolTip n2 = new ToolTip();
            ToolTip n3 = new ToolTip();
            ToolTip n4 = new ToolTip();
            ToolTip n5 = new ToolTip();
            ToolTip n6 = new ToolTip();
            ToolTip n7 = new ToolTip();
            ToolTip n8 = new ToolTip();

            n.SetToolTip(btnGuardar, "Guardar");
            n1.SetToolTip(btnfoto0, "Agregar foto");
            n2.SetToolTip(btnEdit, "Editar Operador");
            n3.SetToolTip(btnAc, "Activar/Desactivar");
            n4.SetToolTip(btnBuscar, "Buscar Operador");
            n5.SetToolTip(txtUnidad, "U-000/R-000");
            n6.SetToolTip(btnAgregar, "Agregar Operador");
            n7.SetToolTip(btnCancelar, "Cancelar todo");
//n8.SetToolTip(txtUnidad, "U-000/R-000");


            btncolor.Visible = false;
            this.dgvOperadores.Columns[0].Visible = false;
            this.dgvOperadores.Columns[7].Visible = false;
            this.dgvOperadores.Columns[8].Visible = false;
            this.dgvOperadores.Columns[10].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUnidad.Enabled = true;
            btnGuardar.Enabled = true;
            cbxVehiculo.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDireccion.Enabled = true;

            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtUnidad.Enabled = true;
            btnGuardar.Enabled = true;
            cbxVehiculo.Enabled = true;
            btnfoto0.Enabled = true;
            x = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!txtDireccion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtUnidad.Text.Equals(""))
            {
                if (x == 0)
                {
                    if (MySqlCon.NewOper(txtUnidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, hoy.ToString("d"),null, txtOb.Text, "1", Int32.Parse(cbxVehiculo.SelectedIndex.ToString()) + 1))
                    {
                        dgvOperadores.DataSource = MySqlCon.getOp();
                        MessageBox.Show("Operador Guardado");
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtUnidad.Enabled = false;
                        btnGuardar.Enabled = false;
                        cbxVehiculo.Enabled = false;
                        btnfoto0.Enabled = false;
                    }
                }
                else
                {

                    if (MySqlCon.UpOper(txtUnidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, hoy.ToString("d"), imagen, "1",txtOb.Text, Int32.Parse(cbxVehiculo.SelectedIndex.ToString() + 1), Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString())))
                    {
                        dgvOperadores.DataSource = MySqlCon.getOp();
                        MessageBox.Show("Operador Actualizado");
                        txtDireccion.Enabled = false;
                        txtNombre.Enabled = false;
                        txtTelefono.Enabled = false;
                        txtUnidad.Enabled = false;
                        btnGuardar.Enabled = false;
                        cbxVehiculo.Enabled = false;
                        btnfoto0.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("llene todos los campos");
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(dgvOperadores.CurrentRow.Cells[8].Value.ToString()) == 1)
            {
                if (MySqlCon.upAcOper(Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString()), 0))
                {

                    btnActividad.BackgroundImage = Image.FromFile(@"C:\Users\Cortana\Documents\Visual Studio 2015\Projects\Proyecto-Lanuza\Servicios Ejecutivos\Servicios Ejecutivos\Resources\Bullet-green (Custom).png");

                    dgvOperadores.DataSource = MySqlCon.getOp();
                    MessageBox.Show("usuario inactivo");
                }


            }
            else
            {
                if (MySqlCon.upAcOper(Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString()), 1))
                {


                    btnActividad.BackgroundImage = Image.FromFile(@"C:\Users\Cortana\Documents\Visual Studio 2015\Projects\Proyecto-Lanuza\Servicios Ejecutivos\Servicios Ejecutivos\Resources\Bullet-red (Custom).png");

                    dgvOperadores.DataSource = MySqlCon.getOp();
                    MessageBox.Show("usuario activo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            txtDireccion.ResetText();
            txtNombre.ResetText();
            txtSaldo.ResetText();
            txtTelefono.ResetText();
            txtUnidad.ResetText();
            btnGuardar.Visible = false;

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtUnidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidad_Click(object sender, EventArgs e)
        {
          
        }

        private void txtUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgvOperadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnidad.Text = dgvOperadores.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvOperadores.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvOperadores.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvOperadores.CurrentRow.Cells[5].Value.ToString();
            txtSaldo.Text = dgvOperadores.CurrentRow.Cells[6].Value.ToString();
            if(!dgvOperadores.CurrentRow.Cells[7].Value.ToString().Equals(null) && !dgvOperadores.CurrentRow.Cells[7].Value.ToString().Equals("") && !dgvOperadores.CurrentRow.Cells[7].Value.ToString().Equals("null"))
            {
                pbxFoto.Image = Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\"+dgvOperadores.CurrentRow.Cells[7].Value.ToString());
            }else
            {
                pbxFoto.Image = Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Default.jpg");
            }
            cbxVehiculo.SelectedIndex = Int32.Parse(dgvOperadores.CurrentRow.Cells[10].Value.ToString())-1;

            if (Int32.Parse(dgvOperadores.CurrentRow.Cells[8].Value.ToString()) == 1)
            {
                btncolor.BackColor = Color.LightGreen;
                btnActividad.BackgroundImage = Image.FromFile(@"C:\Users\Cortana\Documents\Visual Studio 2015\Projects\Proyecto-Lanuza\Servicios Ejecutivos\Servicios Ejecutivos\Resources\Bullet-green (Custom).png");

            }
            else
            {
                btncolor.BackColor = Color.Red;
                btnActividad.BackgroundImage = Image.FromFile(@"C:\Users\Cortana\Documents\Visual Studio 2015\Projects\Proyecto-Lanuza\Servicios Ejecutivos\Servicios Ejecutivos\Resources\Bullet-red (Custom).png");

            }

        }
        
    }
}
