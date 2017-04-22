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

namespace Servicios_Ejecutivos
{
    public partial class Cobro_de_Frecuencia : Form
    {
        public Cobro_de_Frecuencia()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cobro_de_Frecuencia_Load(object sender, EventArgs e)
        {
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
            dias();

        }
        public void dias()
        {
            if (checkBox1.Checked)
            {
                chbLunes.Checked = true;
                chbMartes.Checked = true;
                chbMiercoles.Checked = true;
                chbJueves.Checked = true;
                chbViernes.Checked = true;
                chbSabado.Checked = true;
                chbDomingo.Checked = true;
                txtDetales.Text = ("");
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

        private void txtDetales_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLunes.Checked)
            {
                txtDetales.Text = ("Lunes ");
            }
        }

        private void chbMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMartes.Checked)
            {
                txtDetales.Text = ("Martes ");
            }
        }

        private void dtCobro_ValueChanged(object sender, EventArgs e)
        {
           
        }


      
  
    }
    }
