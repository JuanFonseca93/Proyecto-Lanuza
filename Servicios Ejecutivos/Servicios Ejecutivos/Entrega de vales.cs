using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Entrega_de_vales : Form
    {
        int FolioI=0, FolioF=0, FolioR = 0;
        DateTime hoy = DateTime.Today;
        public Entrega_de_vales()
        {
            InitializeComponent();
            cbxEmpresa.DataSource = MySqlCon.getEmprs();
            cbxEmpresa.DisplayMember = "Nombre";
            cbxEmpresa.ValueMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vales())
            {
                
                Document doc = new Document(PageSize.LETTER);
                PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"C:\Taxi_Ejecutivo\Docs\"+ cbxEmpresa.SelectedValue.ToString()+"-" + hoy.ToString("D")+".pdf", FileMode.Create));
                doc.AddAuthor("Taxi Ejecutivo");
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Taxi_Ejecutivo\Fotos\logo.png");
                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                Chunk ch = new Chunk("\n\n\nRELACION DE VALES ENTREGADOS A\n\n\n\n", FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.NORMAL));
                Chunk ch1 = new Chunk(cbxEmpresa.SelectedValue.ToString() + "\n\n\n", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                Chunk ch2 = new Chunk("Del Folio "+txtFolioI.Text+" al "+txtFolioF.Text+"\n\n\n", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.NORMAL));
                Chunk ch3= new Chunk("Total de Vales "+FolioR, FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.NORMAL));
                Chunk ch4 = new Chunk("Salamanca Guanajuato al " + hoy.ToString("D"), FontFactory.GetFont("ARIAL", 15, iTextSharp.text.Font.NORMAL));
                doc.AddTitle(cbxEmpresa.SelectedValue.ToString() + "-" + hoy.ToString("D") + ".pdf");
                doc.Open();
                Paragraph p1 = new Paragraph(ch);
                p1.Alignment = Element.ALIGN_CENTER;
                Paragraph p2 = new Paragraph(ch1);
                p2.Alignment = Element.ALIGN_CENTER;
                Paragraph p3 = new Paragraph(ch2);
                p3.Alignment = Element.ALIGN_CENTER;
                Paragraph p4 = new Paragraph(ch3);
                p4.Alignment = Element.ALIGN_CENTER;
                Paragraph p5 = new Paragraph(ch4);
                p5.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);
                doc.Add(new Paragraph(p1));
                doc.Add(new Paragraph(p2));
                doc.Add(new Paragraph(p3));
                doc.Add(new Paragraph(p4));
                doc.Add(new Paragraph(p5));
                doc.Close();
                MessageBox.Show("Vales Registrados");
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = @"C:\Taxi_Ejecutivo\Docs\" + cbxEmpresa.SelectedValue.ToString() + "-" + hoy.ToString("D") + ".pdf";
                proc.Start();
                proc.Close();
            }
        }

        private bool vales()
        {
            try
            {
                FolioI = Int32.Parse(txtFolioI.Text);
                FolioF = Int32.Parse(txtFolioF.Text);
                FolioR = (FolioF - FolioI) + 1;
                while(FolioI<=FolioF)
                {
                    if(MySqlCon.NewVales(cbxEmpresa.SelectedValue.ToString(),txtSerie.Text,FolioI, hoy.ToString("d")))
                    {
                        FolioI++;
                    }
                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
