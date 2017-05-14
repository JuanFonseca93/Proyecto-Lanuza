using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace Servicios_Ejecutivos
{
    public partial class Cobro_de_Frecuencia : Form
    {
        DataTable datos = new DataTable();
        ArrayList dias1 = new ArrayList();

        public Cobro_de_Frecuencia()
        {
            InitializeComponent();
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void lista()
        {
            if(cbxSemana.Checked == true)
            {
                dias1.Add("Lunes");
                dias1.Add("Martes");
                dias1.Add("Miercoles");
                dias1.Add("Jueves");
                dias1.Add("Viernes");
                dias1.Add("Sabado");
                dias1.Add("Domingo");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else if (cbxSemana.Checked == false)
            {
                dias1.Clear();
                txtDetalles.Text = "";
            }
            else if (chbLunes.Checked==true)
            {
                dias1.Add("Lunes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Lunes");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Martes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Martes");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Miercoles");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Miercoles");
                dias1.Remove(w);
                txtDetalles.Text = dias1.ToString();
                    txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Jueves");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Jueves");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Viernes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Viernes");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Sabado");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Sabado");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == true)
            {
                dias1.Add("Domingo");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
            else if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Domingo");
                dias1.Remove(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cobro_de_Frecuencia_Load(object sender, EventArgs e)
        {
             object index = DateTime.Now;

            gbDias.Visible = false;
            gbDetalle.Visible = false;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cbConcepto.Text.Equals("Bono de cooperación"))
            {
                gbDias.Visible = true;
                gbDetalle.Visible = false;

            } else if(cbConcepto.Text.Equals("Castigo"))
            {
                gbDetalle.Visible = true;
                gbDias.Visible = false;

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //dias();
            lista();

        }
       /* public void dias()
        {
            if (cbxSemana.Checked)
            {
                chbLunes.Checked = true;
                chbMartes.Checked = true;
                chbMiercoles.Checked = true;
                chbJueves.Checked = true;
                chbViernes.Checked = true;
                chbSabado.Checked = true;
                chbDomingo.Checked = true;
            }
            else{
                chbLunes.Checked = false;
                chbMartes.Checked = false;
                chbMiercoles.Checked = false;
                chbJueves.Checked = false;
                chbViernes.Checked = false;
                chbSabado.Checked = false;
                chbDomingo.Checked = false;
            }


        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos = MySqlCon.CobFrec(txtUnidad.Text);
                DataRow row = datos.Rows[0];
                txtNombre.Text = row["Nombre_U"].ToString();
                if (row["Foto_O"].ToString().Equals(null) && row["Foto_O"].ToString().Equals("") && row["Foto_O"].ToString().Equals("null"))
                {
                    pbxFoto.Image = Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Default.jpg");
                }
                else
                {
                    pbxFoto.Image = Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + row["Foto_O"].ToString());
                }
                txtSaldo.Text = row["Saldo"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unidad no encontrada");
            }

        }

        private void chbLunes_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbViernes_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbDomingo_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbMartes_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbJueves_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void chbSabado_CheckedChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
