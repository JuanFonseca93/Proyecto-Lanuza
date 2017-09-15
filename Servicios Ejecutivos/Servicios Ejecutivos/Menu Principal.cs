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
    public partial class Menu : Form
    {
        int ID_USER;
        public Menu(int ID_USER)
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
            
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Empleados open = new Empleados();
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Cobro_de_Frecuencia open = new Cobro_de_Frecuencia(ID_USER);
            open.MdiParent = this;
            open.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            Empresas op = new Empresas();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
           
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

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.F1))
            {
                tsAdmin.ShowDropDown();
            }else if (e.KeyChar == Convert.ToChar(Keys.F2))
            {
                tsTE.ShowDropDown();
            }else if (e.KeyChar == Convert.ToChar(Keys.F3))
            {
                tsFG.ShowDropDown();
            }else if (e.KeyChar == Convert.ToChar(Keys.F4))
            {
                tsEmpresas.ShowDropDown();
            }
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (keyData == Keys.F2)
            {
                 tsTE.ShowDropDown();
                
            }
             else if (keyData == Keys.F1)
            {
                tsAdmin.ShowDropDown();
                   
               
            }   
            else if (keyData == Keys.F3)
            {
                tsFG.ShowDropDown();
            }
            else if (keyData == Keys.F4)
            {
                tsEmpresas.ShowDropDown();
            }

            
            return true;
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Recepcion_de_vales op = new Recepcion_de_vales();
            op.MdiParent = this;
            op.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            tsAdmin.ShowDropDown();
        }

        private void toolStripSplitButton1toolStripSplitButton1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrolUser open = new CtrolUser();
            open.MdiParent = this;
            open.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados open = new Empleados();
            open.MdiParent = this;
            open.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrVehiculos open = new ctrVehiculos();
            open.MdiParent = this;
            open.Show();
        }

        private void bonoDeCooperciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobro_de_Frecuencia open = new Cobro_de_Frecuencia(ID_USER);
            open.MdiParent = this;
            open.Show();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ctrVehiculos open = new ctrVehiculos();
            open.MdiParent = this;
            open.Show();
        }

        private void operadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFoto op = new btnFoto();
            op.MdiParent = this;
            op.Show();
        }

        private void tsTE_ButtonClick(object sender, EventArgs e)
        {
            tsTE.ShowDropDown();
        }

        private void tsFG_ButtonClick(object sender, EventArgs e)
        {
            tsFG.ShowDropDown();
        }

        private void tsEmpresas_ButtonClick(object sender, EventArgs e)
        {
            tsEmpresas.ShowDropDown();
        }

        private void vehiculosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ctrVehiculos open = new ctrVehiculos();
            open.MdiParent = this;
            open.Show();
        }

        private void catalogoDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresas op = new Empresas();
            op.MdiParent = this;
            op.Show();
        }

        private void entregaDeValesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrega_de_vales op = new Entrega_de_vales(ID_USER);
            op.MdiParent = this;
            op.Show();
        }

        private void recepcionDeValesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_de_vales op = new Recepcion_de_vales();
            op.MdiParent = this;
            op.Show();
        }
    }
}
