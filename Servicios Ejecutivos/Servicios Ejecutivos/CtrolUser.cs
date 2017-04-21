﻿using System;
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
    
    public partial class CtrolUser : Form
    {
        int x=0;
        public CtrolUser()
        {
            
            InitializeComponent();
            dtgUsers.DataSource = MySqlCon.getUser();
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            txtEstado.Enabled = false;
            txtMunicipio.Enabled = false;
            cbxNivel.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x==0)
            {
                if (cbxNivel.SelectedIndex > 0 || !txtNombre.Text.Equals("") || !txtDireccion.Text.Equals("") || !txtTelefono.Text.Equals("") || !txtMunicipio.Text.Equals("") || !txtEstado.Text.Equals("") || !txtUser.Text.Equals("") || !txtPass.Text.Equals(""))
                {
                    if (MySqlCon.NewClient(txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtMunicipio.Text, txtMunicipio.Text, txtUser.Text, txtPass.Text, cbxNivel.SelectedIndex))
                    {
                        MessageBox.Show("Usuario Guardado");
                    }
                }else
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
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            txtEstado.Enabled = true;
            txtMunicipio.Enabled = true;
            cbxNivel.Enabled = true;
            txtNombre.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cbxNivel.SelectedIndex = 0;
        }

        private void dtgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dtgUsers.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dtgUsers.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dtgUsers.CurrentRow.Cells[5].Value.ToString();
            txtEstado.Text = dtgUsers.CurrentRow.Cells[6].Value.ToString();
            txtMunicipio.Text = dtgUsers.CurrentRow.Cells[7].Value.ToString();
            txtUser.Text = dtgUsers.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text = dtgUsers.CurrentRow.Cells[2].Value.ToString();
            cbxNivel.SelectedIndex = Int32.Parse(dtgUsers.CurrentRow.Cells[8].Value.ToString());

        }
    }
}
