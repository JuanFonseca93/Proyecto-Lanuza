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
    public partial class Recepcion_de_vales : Form
    {
        String Ganancia = "", TipoV = "", TipoT = "";
        DateTime hoy = DateTime.Today;
        public Recepcion_de_vales()
        {

            InitializeComponent();
            cbxUnidad.DataSource = MySqlCon.getuni();
            cbxUnidad.DisplayMember = "Unidad";
            cbxUnidad.ValueMember = "Unidad";
            comp(false);

        }
        public void comp(bool com)
        {
            txtCosto.Enabled = com;
            txtDestino.Enabled = com;
            txtNombres.Enabled = com;
            cbxExcep.Enabled = com;
            cbxForaneo.Enabled = com;
            cbxIda.Enabled = com;
            cbxIdaV.Enabled = com;
            cbxLocal.Enabled = com;
            cbxUnidad.Enabled = com;
            btxAgregar.Enabled = com;
            btnPagar.Enabled = com;
        }
        private void Recepcion_de_vales_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MySqlCon.getvales(txtFolio.Text);
            DataRow rw = dt.Rows[0];
            txtFechaEM.Text = rw["Fecha_Emision"].ToString();
            DataTable dte = new DataTable();
            dte = MySqlCon.getEmpresaNom(Int32.Parse(rw["Id_Empresa"].ToString()));
            DataRow nrw = dte.Rows[0];
            txtEmpresa.Text = nrw["Nombre"].ToString();
            if (rw["Estado_Vale"].Equals("Recivido") || rw["Estado_Vale"].Equals("Pagado"))
            {
                MessageBox.Show("El Vale ya fue resivido ateriormente");
            }else
            {
                comp(true);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxUnidad_SelectedIndex(object sender, EventArgs e)
        {
            try { 
                DataTable dt = new DataTable();
                dt = MySqlCon.CobFrec(cbxUnidad.SelectedValue.ToString());
                DataRow rw = dt.Rows[0];
                txtNombreO.Text = rw["Nombre_U"].ToString();
                txtSaldoO.Text = rw["Saldo"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los campos de acuerdo al VALE resivido");
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLocal.Checked == true)
            {
                TipoV = "Local";
                cbxForaneo.Checked = false;
            }
        }

        private void cbxForaneo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxForaneo.Checked == true)
            {
                TipoV = "Foraneo";
                cbxLocal.Checked = false;
            }
        }

        private void cbxIda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIda.Checked == true)
            {
                TipoT = "Ida";
                cbxIdaV.Checked = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MySqlCon.getOpdata(cbxUnidad.SelectedValue.ToString());
            DataRow drw = dt.Rows[0];
            if (cbxExcep.Checked == true)
            {
                Ganancia = "0";
               
            }
            else
            {

                Double gan = Int32.Parse(txtCosto.Text) * (0.15);
                Ganancia = Convert.ToString(gan);
                
            }

            if (MySqlCon.UPVale(txtNombres.Text, txtDestino.Text, txtCosto.Text, Ganancia, hoy.ToString("d"), TipoV, TipoT, Int32.Parse(drw["Id_Operador"].ToString()), txtFolio.Text, "Pagado"))
            {
                MessageBox.Show("Vale Actualizado");
                comp(false);
            }
        }

        private void cbxIdaV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIdaV.Checked == true)
            {
                TipoT = "Ida-Vuelta";
                cbxIda.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = MySqlCon.getOpdata(cbxUnidad.SelectedValue.ToString());
            DataRow drw = dt.Rows[0];
            if (cbxExcep.Checked == true)
            {
                Ganancia = "0";
                double saldo = Double.Parse(txtSaldoO.Text) + Int32.Parse(txtCosto.Text);
                MySqlCon.UPSALDO(Int32.Parse(drw["Id_Operador"].ToString()), saldo);  
            }else
            {

                Double gan = Int32.Parse(txtCosto.Text) * (0.15);
                Ganancia = Convert.ToString(gan);
                double saldo = Double.Parse(txtSaldoO.Text) + (Int32.Parse(txtCosto.Text) - gan);
                MySqlCon.UPSALDO(Int32.Parse(drw["Id_Operador"].ToString()), saldo);
            }
            
            if (MySqlCon.UPVale(txtNombres.Text,txtDestino.Text,txtCosto.Text,Ganancia,hoy.ToString("d"),TipoV, TipoT, Int32.Parse(drw["Id_Operador"].ToString()), txtFolio.Text, "Recivido"))
            {
                MessageBox.Show("Vale Actualizado");
                comp(false);
            }
        }
    }
}
