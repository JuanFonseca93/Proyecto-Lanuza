﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Servicios_Ejecutivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists("c:\\Taxi_Ejecutivo"))
            {
                Directory.CreateDirectory("c:\\Taxi_Ejecutivo");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iniciar_sesion();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            iniciar_sesion();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPass.ForeColor = Color.Black;
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUser.ForeColor = Color.Black;
        }

        public void iniciar_sesion()
        {
            if (MySqlCon.checkUser(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Bienvenido");
                Menu_Principal open = new Menu_Principal();
                open.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }


        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar_sesion();
            }
            else{


            }
        }


    }
}
