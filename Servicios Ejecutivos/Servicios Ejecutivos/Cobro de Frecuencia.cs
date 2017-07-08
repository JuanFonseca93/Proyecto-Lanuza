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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Servicios_Ejecutivos
{
    public partial class Cobro_de_Frecuencia : Form
    {
        DataTable datos = new DataTable();
        ArrayList dias1 = new ArrayList();
        DateTime hoy = DateTime.Today;

        int ID_USER;

        public Cobro_de_Frecuencia(int ID_USER)
        {
            InitializeComponent();
            dgvCobros.DataSource = MySqlCon.getCobros(hoy.ToString("d"));
            cbxEfectivo.Checked = true;
            this.ID_USER = ID_USER;
            if (!Directory.Exists("c:\\Taxi_Ejecutivo\\Recibo_Cobro"))
            {
                Directory.CreateDirectory("c:\\Taxi_Ejecutivo\\Recibo_Cobro");
            }

        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void lista()
        {
            if(cbxSemana.Checked == true)
            {
                chbLunes.Checked = false;
                chbMartes.Checked = false;
                chbMiercoles.Checked = false;
                chbJueves.Checked = false;
                chbViernes.Checked = false;
                chbSabado.Checked = false;
                chbDomingo.Checked = false;
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
            }
            if (cbxSemana.Checked == false)
            {
                chbLunes.Checked = false;
                chbMartes.Checked = false;
                chbMiercoles.Checked = false;
                chbJueves.Checked = false;
                chbViernes.Checked = false;
                chbSabado.Checked = false;
                chbDomingo.Checked = false;
                dias1 = new ArrayList();
                txtDetalles.Text = "";
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

            cobro();
        }

        public void cobro()
        {
            try
            {
                datos = MySqlCon.CobFrec(txtUnidad.Text);
                DataRow row = datos.Rows[0];
                txtNombre.Text = row["Nombre_U"].ToString();
                if (row["Foto_O"].ToString().Equals(null) && row["Foto_O"].ToString().Equals("") && row["Foto_O"].ToString().Equals("null"))
                {
                    pbxFoto.Image = System.Drawing.Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Default.jpg");
                }
                else
                {
                    pbxFoto.Image = System.Drawing.Image.FromFile("c:\\Taxi_Ejecutivo\\Fotos\\Operadores\\" + row["Foto_O"].ToString());
                }
                txtSaldo.Text = row["Saldo"].ToString();
                dgvCobros.DataSource = MySqlCon.getCobros(hoy.ToString("d"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unidad no encontrada");
            }
        }

        private void chbLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLunes.Checked == true)
            {
                dias1.Add("Lunes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbLunes.Checked == false)
            {
                int w = dias1.BinarySearch("Lunes");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMiercoles.Checked == true)
            {
                dias1.Add("Miercoles");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbMiercoles.Checked == false)
            {
                int w = dias1.BinarySearch("Miercoles");
                dias1.RemoveAt(w);
                txtDetalles.Text = dias1.ToString();
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbViernes.Checked == true)
            {
                dias1.Add("Viernes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbViernes.Checked == false)
            {
                int w = dias1.BinarySearch("Viernes");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbDomingo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDomingo.Checked == true)
            {
                dias1.Add("Domingo");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbDomingo.Checked == false)
            {
                int w = dias1.BinarySearch("Domingo");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMartes.Checked == true)
            {
                dias1.Add("Martes");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbMartes.Checked == false)
            {
                int w = dias1.BinarySearch("Martes");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (chbJueves.Checked == true)
            {
                dias1.Add("Jueves");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbJueves.Checked == false)
            {
                int w = dias1.BinarySearch("Jueves");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void chbSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSabado.Checked == true)
            {
                dias1.Add("Sabado");
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }else
            if (chbSabado.Checked == false)
            {
                int w = dias1.BinarySearch("Sabado");
                dias1.RemoveAt(w);
                txtDetalles.Text = "";
                foreach (String Dias in dias1)
                {
                    txtDetalles.AppendText(Dias);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Recibo()
        {
            DateTime hoy = DateTime.Today;
            DataTable dt = MySqlCon.getidcob();
            DataRow rw = dt.Rows[0];
            Document doc = new Document(PageSize.A5);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"C:\Taxi_Ejecutivo\Recibo_Cobro\" + txtUnidad.Text + "-ID" + rw["Id_Cobro"].ToString() + "-" + hoy.ToString("D") + ".pdf", FileMode.Create));
            doc.AddAuthor("Taxi Ejecutivo");
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Taxi_Ejecutivo\Fotos\logoA5.jpg");
            logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            Chunk ch00 = new Chunk("RECIBO DE COBRO", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch = new Chunk("\nFolio: " + rw["Id_Cobro"].ToString() + "                                                  Fecha: " + hoy.ToString("d") + "\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch0 = new Chunk("Unidad: " +txtUnidad.Text + "                     Nombre: " + txtNombre.Text + "\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch1 = new Chunk("Concepto: " + cbConcepto.SelectedItem.ToString() + "\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch2 = new Chunk("Observaciones: " + txtDetalles.Text + "\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch3 = new Chunk("Total: $" + txtCosto.Text + "\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch4 = new Chunk("___________________________________"  , FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            DataTable dt1 = MySqlCon.getUserdt(ID_USER);
            DataRow rw1 = dt1.Rows[0];
            Chunk ch5 = new Chunk("Firma: " +rw1["Nombre_Usurio"].ToString() +"\n", FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.NORMAL));
            Chunk ch6 = new Chunk("Original\n\n\n\n", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.NORMAL));
            Chunk ch7 = new Chunk("Copia", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.NORMAL));

            doc.AddTitle(txtUnidad.Text + "-ID: " + rw["Id_Cobro"].ToString() +"-"+ hoy.ToString("D") + ".pdf");
            doc.Open();
            Paragraph p00 = new Paragraph(ch00);
            p00.Alignment = Element.ALIGN_CENTER;
            Paragraph p = new Paragraph(ch);
            Paragraph p0 = new Paragraph(ch0);
            Paragraph p1 = new Paragraph(ch1);
            Paragraph p2 = new Paragraph(ch2);
            Paragraph p3 = new Paragraph(ch3);
            Paragraph p4 = new Paragraph(ch4);

            Paragraph p5 = new Paragraph(ch5);
            Paragraph p6 = new Paragraph(ch6);
            Paragraph p7 = new Paragraph(ch7);
            p4.Alignment = Element.ALIGN_CENTER;
            p5.Alignment = Element.ALIGN_CENTER;

            doc.Add(new Paragraph(p00));
            doc.Add(logo);
            doc.Add(new Paragraph(p));
            doc.Add(new Paragraph(p0));
            doc.Add(new Paragraph(p1));
            doc.Add(new Paragraph(p2));
            doc.Add(new Paragraph(p3));
            doc.Add(new Paragraph(p4));
            doc.Add(new Paragraph(p5));
            doc.Add(new Paragraph(p6));
            
            doc.Add(logo);
            doc.Add(new Paragraph(p));
            doc.Add(new Paragraph(p0));
            doc.Add(new Paragraph(p1));
            doc.Add(new Paragraph(p2));
            doc.Add(new Paragraph(p3));
            doc.Add(new Paragraph(p4));
            doc.Add(new Paragraph(p5));
            doc.Add(new Paragraph(p7));
            doc.Close();

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = @"C:\Taxi_Ejecutivo\Recibo_Cobro\" + txtUnidad.Text + "-ID" + rw["Id_Cobro"].ToString() + "-" + hoy.ToString("D") + ".pdf";
            proc.Start();
            proc.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(cbxSaldo.Checked == true)
            {
                if(Int32.Parse(txtSaldo.Text) < Int32.Parse(txtCosto.Text))
                {
                    if (MessageBox.Show("¿Desea cobrar lo restante con efectivo?" , "Saldo Insuficiente...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Se necesitan : $" + (Int32.Parse(txtCosto.Text)- Int32.Parse(txtSaldo.Text)) + " en efectivo, precione aceptar para generar el pago", "Generar pago...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            datos = MySqlCon.CobFrec(txtUnidad.Text);
                            DataRow row = datos.Rows[0];
                            if (MySqlCon.NewFrec(cbConcepto.SelectedItem.ToString(),Int32.Parse(txtCosto.Text),txtDetalles.Text,hoy.ToString("d"),0,Int32.Parse(row["Id_Operador"].ToString()),ID_USER))
                            {
                                if (MySqlCon.UPSALDO(Int32.Parse(row["Id_Operador"].ToString()), 0))
                                {
                                    cobro();
                                    MessageBox.Show("El cobro se realizo con exito");
                                    Recibo();
                                }
                                
                            }
                        }
                    }
                }else
                {
                    datos = MySqlCon.CobFrec(txtUnidad.Text);
                    DataRow row = datos.Rows[0];
                    if (MySqlCon.NewFrec(cbConcepto.SelectedItem.ToString(), Int32.Parse(txtCosto.Text), txtDetalles.Text, hoy.ToString("d"), 0, Int32.Parse(row["Id_Operador"].ToString()), ID_USER))
                    {
                        if (MySqlCon.UPSALDO(Int32.Parse(row["Id_Operador"].ToString()), (Int32.Parse(txtSaldo.Text)- Int32.Parse(txtCosto.Text))))
                        {
                            cobro();
                            MessageBox.Show("El cobro se realizo con exito");
                            Recibo();
                        }
                    }
                }
            }else
            {
                if (MessageBox.Show("El cobro se realizara en efectivo", "Cobro...", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    datos = MySqlCon.CobFrec(txtUnidad.Text);
                    DataRow row = datos.Rows[0];
                    if (MySqlCon.NewFrec(cbConcepto.SelectedItem.ToString(), Int32.Parse(txtCosto.Text), txtDetalles.Text, hoy.ToString("d"), 0, Int32.Parse(row["Id_Operador"].ToString()), ID_USER))
                    {
                        cobro();
                        MessageBox.Show("El cobro se realizo con exito");
                        Recibo();
                    }
                }
            }
        }

        private void gbDetalle_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxEfectivo.Checked==true)
            {
                cbxSaldo.Checked = false;
            }
        }

        private void cbxSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSaldo.Checked == true)
            {
                cbxEfectivo.Checked = false;
            }
        }
    }
    }
