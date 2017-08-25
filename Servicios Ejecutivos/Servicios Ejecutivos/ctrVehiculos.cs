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
    public partial class ctrVehiculos : Form
    {
        int x = 0;
        public ctrVehiculos()
        {
            InitializeComponent();
            dgvVeh.DataSource = MySqlCon.getveh();
            txtTipo.Enabled = false;
            txtConcesion.Enabled = false;
            txtConcesinario.Enabled = false;
            txtLinea.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtano.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            btnAc.Enabled = false;
            btnPDF.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            txtConcesion.Enabled = true;
            txtConcesinario.Enabled = true;
            txtLinea.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtano.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            btnGuardar.Enabled = true;
            txtTipo.Text = "";
            txtConcesion.Text = "";
            txtConcesinario.Text = "";
            txtLinea.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtano.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void dgvVeh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipo.Text = dgvVeh.CurrentRow.Cells[1].Value.ToString();
            txtConcesion.Text = dgvVeh.CurrentRow.Cells[2].Value.ToString();
            txtConcesinario.Text = dgvVeh.CurrentRow.Cells[3].Value.ToString();
            txtLinea.Text = dgvVeh.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvVeh.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvVeh.CurrentRow.Cells[6].Value.ToString();
            txtMarca.Text = dgvVeh.CurrentRow.Cells[7].Value.ToString();
            txtModelo.Text = dgvVeh.CurrentRow.Cells[8].Value.ToString();
            txtano.Text = dgvVeh.CurrentRow.Cells[9].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                if (MySqlCon.NewVeh(txtTipo.Text,txtConcesion.Text,txtConcesinario.Text,cbLinea.Text,txtDireccion.Text,txtTelefono.Text,txtMarca.Text,txtModelo.Text,txtano.Text))
                {
                    MessageBox.Show("Vehiculo Guardado");
                    txtTipo.Enabled = false;
                    txtConcesion.Enabled = false;
                    txtConcesinario.Enabled = false;
                    txtLinea.Enabled = false;
                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtano.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    btnAc.Enabled = false;
                    btnPDF.Enabled = false;
                    btnGuardar.Enabled = false;
                    dgvVeh.DataSource = MySqlCon.getveh();
                }
            }else
            {
                if (MySqlCon.UpVeh(txtTipo.Text, txtConcesion.Text, txtConcesinario.Text, txtLinea.Text, txtDireccion.Text, txtTelefono.Text, txtMarca.Text, txtModelo.Text, txtano.Text, Int32.Parse(dgvVeh.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Vehiculo Guardado");
                    txtTipo.Enabled = false;
                    txtConcesion.Enabled = false;
                    txtConcesinario.Enabled = false;
                    txtLinea.Enabled = false;
                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtano.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    btnAc.Enabled = false;
                    btnPDF.Enabled = false;
                    btnGuardar.Enabled = false;
                    dgvVeh.DataSource = MySqlCon.getveh();
                }
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(dgvVeh.CurrentRow.Cells[11].Value.ToString())==1)
            {
                if (MySqlCon.upAcVeh(Int32.Parse(dgvVeh.CurrentRow.Cells[0].Value.ToString()), 0))
                {
                    MessageBox.Show("Vehiculo ahora incativo");
                    dgvVeh.DataSource = MySqlCon.getveh();
                }
            }else
            {
                if (MySqlCon.upAcVeh(Int32.Parse(dgvVeh.CurrentRow.Cells[0].Value.ToString()), 1))
                {
                    MessageBox.Show("Vehiculo ahora activo");
                    dgvVeh.DataSource = MySqlCon.getveh();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
            txtTipo.Enabled = true;
            txtConcesion.Enabled = true;
            txtConcesinario.Enabled = true;
            txtLinea.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtano.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            btnAc.Enabled = true;
            btnPDF.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("c:\\Taxi_Ejecutivo\\"+dgvVeh.CurrentRow.Cells[0].Value.ToString()))
            {
                Directory.CreateDirectory("c:\\Taxi_Ejecutivo\\" + dgvVeh.CurrentRow.Cells[0].Value.ToString());
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                String sourcepathx;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sourcepathx = @"" + openFileDialog1.FileName;
                    Console.WriteLine(sourcepathx);
                    File.Copy(sourcepathx, "c:\\Taxi_Ejecutivo\\" + dgvVeh.CurrentRow.Cells[0].Value.ToString() + "\\" + dgvVeh.CurrentRow.Cells[2].Value.ToString() + ".pdf", true);
                }
            }
            else
            {
                try { 
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    String sourcepathx;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                        sourcepathx = @"" + openFileDialog1.FileName;
                        Console.WriteLine(Path.GetFullPath(sourcepathx));
                        File.Copy(Path.GetFullPath(sourcepathx), "c:\\Taxi_Ejecutivo\\" + dgvVeh.CurrentRow.Cells[0].Value.ToString()+"\\"+ dgvVeh.CurrentRow.Cells[2].Value.ToString()+".pdf", true);
                        MessageBox.Show("Archivo Guardado en c:\\Taxi_Ejecutivo");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ctrVehiculos_Load(object sender, EventArgs e)
        {
            ToolTip n = new ToolTip();
            ToolTip n1 = new ToolTip();
            ToolTip n2 = new ToolTip();
            ToolTip n3 = new ToolTip();
            ToolTip n4 = new ToolTip();
            ToolTip n5 = new ToolTip();

            n.SetToolTip(btnNuevo, "Registrar Vehiculo");
            n1.SetToolTip(btnEditar, "Editar Vehiculo");
            n2.SetToolTip(btnGuardar, "Guardar Tarjeta");
            n3.SetToolTip(btnPDF, "Guardar Tarjeta");
            n4.SetToolTip(btnAc, "Activar - Desactivar Vehiculo");
            n5.SetToolTip(btnCancelar, "Cancelar");
            


        }
    }
}
