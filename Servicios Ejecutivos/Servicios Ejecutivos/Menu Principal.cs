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
    public partial class Menu_Principal : Form
    {
        int ID_USER;
        public Menu_Principal(int ID_USER)
        {
            InitializeComponent();
            this.ID_USER = ID_USER;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
          //  FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CtrolUser open = new CtrolUser();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Empleados open = new Empleados();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Cobro_de_Frecuencia open = new Cobro_de_Frecuencia();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Empleados open = new Empleados();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Cobro_de_Frecuencia open = new Cobro_de_Frecuencia();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CtrolUser open = new CtrolUser();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ctrVehiculos open = new ctrVehiculos();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ctrVehiculos open = new ctrVehiculos();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            btnFoto op = new btnFoto();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            btnFoto op = new btnFoto();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            Empresas op = new Empresas();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            Empresas op = new Empresas();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Entrega_de_vales op = new Entrega_de_vales(ID_USER);
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Entrega_de_vales op = new Entrega_de_vales(ID_USER);
            op.MdiParent = this;
            op.Show();

        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
