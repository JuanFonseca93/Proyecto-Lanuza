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
        int x = 0;
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
                if (MySqlCon.upAcOper(Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString()), false))
                {
                    
                    btncolor.BackColor = Color.LightGreen;
                    dgvOperadores.DataSource = MySqlCon.getOp();
                    MessageBox.Show("usuario activo");
                }


            }else
            {
                if (MySqlCon.upAcOper(Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString()), true))
                {
                    btncolor.BackColor = Color.Red;
                    dgvOperadores.DataSource = MySqlCon.getOp();
                    MessageBox.Show("usuario inactivo");
                }
            }
            
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
            if(!txtDireccion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtSaldo.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtUnidad.Text.Equals(""))
            {
                if (x == 0)
                {
                    if (MySqlCon.NewOper(txtUnidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, hoy.ToString("d"),  null, "1", cbxVehiculo.SelectedIndex.ToString()))
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
                } else
                {
                    
                    if (MySqlCon.UpOper(txtUnidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, hoy.ToString("d"), imagen, "1" , cbxVehiculo.SelectedIndex.ToString(), Int32.Parse(dgvOperadores.CurrentRow.Cells[0].Value.ToString())))
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
            }else
            {
                MessageBox.Show("llene todos los campos");
            }
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

        private void dgvOperadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnidad.Text = dgvOperadores.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvOperadores.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvOperadores.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvOperadores.CurrentRow.Cells[4].Value.ToString();
            txtSaldo.Text = dgvOperadores.CurrentRow.Cells[5].Value.ToString();
            if(!dgvOperadores.CurrentRow.Cells[6].Value.ToString().Equals(null) && !dgvOperadores.CurrentRow.Cells[9].Value.ToString().Equals("") && !dgvOperadores.CurrentRow.Cells[9].Value.ToString().Equals("null"))
            {
                pbxFoto.Image = Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\"+dgvOperadores.CurrentRow.Cells[6].Value.ToString());
            }
            cbxVehiculo.SelectedIndex = Int32.Parse(dgvOperadores.CurrentRow.Cells[9].Value.ToString());

            if (Int32.Parse(dgvOperadores.CurrentRow.Cells[7].Value.ToString()) == 1)
            {
                checkBox1.Checked = true;
                btncolor.BackColor = Color.LightGreen;
            }else
            {
                checkBox1.Checked = false;
                btncolor.BackColor = Color.Red;
            }

        }
        
    }
}
