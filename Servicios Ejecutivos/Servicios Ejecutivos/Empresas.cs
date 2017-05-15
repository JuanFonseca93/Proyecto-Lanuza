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
    public partial class Empresas : Form
    {
        int x = 0;
        public Empresas()
        {
            InitializeComponent();
            dgvEmpresas.DataSource = MySqlCon.getEmps();
            deshabilitar(false);
            
        }

        public void deshabilitar(bool status)
        {
            txtNombre.Enabled = status;
            txtCiudad.Enabled = status;
            txtContacto.Enabled =status;
            txtCorreo.Enabled = status;
            txtDireccion.Enabled = status;
            txtEstado.Enabled = status;
            txtRazonSc.Enabled = status;
            txtRFC.Enabled = status;
            txtTelCont.Enabled = status;
            txtTelefono.Enabled = status;
            btnG.Enabled = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deshabilitar(true);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (x==0)
            {
                if (MySqlCon.NewEmpr(txtNombre.Text,txtRazonSc.Text, txtRFC.Text,txtDireccion.Text,txtTelefono.Text,txtContacto.Text,txtTelCont.Text,txtCorreo.Text,txtEstado.Text,txtCiudad.Text))
                {
                    deshabilitar(false);
                    dgvEmpresas.DataSource = MySqlCon.getEmps();
                    MessageBox.Show("Empresas Guardada");
                }
            }else
            {
                if (MySqlCon.UpEmpr(txtNombre.Text, txtRazonSc.Text, txtRFC.Text, txtDireccion.Text, txtTelefono.Text, txtContacto.Text, txtTelCont.Text, txtCorreo.Text, txtEstado.Text, txtCiudad.Text,Int32.Parse(dgvEmpresas.CurrentRow.Cells[0].Value.ToString())))
                {
                    deshabilitar(false);
                    dgvEmpresas.DataSource = MySqlCon.getEmps();
                    MessageBox.Show("Empresas Actualizada");
                }
            }
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvEmpresas.CurrentRow.Cells[1].Value.ToString();
            txtRazonSc.Text= dgvEmpresas.CurrentRow.Cells[2].Value.ToString();
            txtRFC.Text = dgvEmpresas.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgvEmpresas.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvEmpresas.CurrentRow.Cells[5].Value.ToString();
            txtContacto.Text = dgvEmpresas.CurrentRow.Cells[6].Value.ToString();
            txtTelCont.Text = dgvEmpresas.CurrentRow.Cells[7].Value.ToString();
            txtCorreo.Text = dgvEmpresas.CurrentRow.Cells[8].Value.ToString();
            txtEstado.Text = dgvEmpresas.CurrentRow.Cells[9].Value.ToString();
            txtCiudad.Text = dgvEmpresas.CurrentRow.Cells[10].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar(true);
            x = 1;
        }
    }
}
