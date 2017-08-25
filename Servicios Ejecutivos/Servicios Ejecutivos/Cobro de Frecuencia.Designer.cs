namespace Servicios_Ejecutivos
{
    partial class Cobro_de_Frecuencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSaldo = new System.Windows.Forms.CheckBox();
            this.cbxEfectivo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.dtCobro = new System.Windows.Forms.DateTimePicker();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDias = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chbDomingo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSemana = new System.Windows.Forms.CheckBox();
            this.chbLunes = new System.Windows.Forms.CheckBox();
            this.chbMartes = new System.Windows.Forms.CheckBox();
            this.chbMiercoles = new System.Windows.Forms.CheckBox();
            this.chbJueves = new System.Windows.Forms.CheckBox();
            this.chbViernes = new System.Windows.Forms.CheckBox();
            this.chbSabado = new System.Windows.Forms.CheckBox();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.gbDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(101, 42);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(81, 25);
            this.txtUnidad.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(135, 358);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(159, 25);
            this.txtCosto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semana Completa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Concepto";
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Items.AddRange(new object[] {
            "Bono de cooperación",
            "Castigo",
            "Otro pago"});
            this.cbConcepto.Location = new System.Drawing.Point(101, 121);
            this.cbConcepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(208, 28);
            this.cbConcepto.TabIndex = 9;
            this.cbConcepto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cbxSaldo);
            this.groupBox1.Controls.Add(this.cbxEfectivo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.pbxFoto);
            this.groupBox1.Controls.Add(this.dtCobro);
            this.groupBox1.Controls.Add(this.gbDetalle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gbDias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbConcepto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(927, 398);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cobro de Frecuencia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxSaldo
            // 
            this.cbxSaldo.AutoSize = true;
            this.cbxSaldo.Location = new System.Drawing.Point(204, 324);
            this.cbxSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSaldo.Name = "cbxSaldo";
            this.cbxSaldo.Size = new System.Drawing.Size(73, 24);
            this.cbxSaldo.TabIndex = 23;
            this.cbxSaldo.Text = "Saldo";
            this.cbxSaldo.UseVisualStyleBackColor = true;
            this.cbxSaldo.CheckedChanged += new System.EventHandler(this.cbxSaldo_CheckedChanged);
            // 
            // cbxEfectivo
            // 
            this.cbxEfectivo.AutoSize = true;
            this.cbxEfectivo.Location = new System.Drawing.Point(63, 324);
            this.cbxEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEfectivo.Name = "cbxEfectivo";
            this.cbxEfectivo.Size = new System.Drawing.Size(91, 24);
            this.cbxEfectivo.TabIndex = 22;
            this.cbxEfectivo.Text = "Efectivo";
            this.cbxEfectivo.UseVisualStyleBackColor = true;
            this.cbxEfectivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(283, 25);
            this.txtNombre.TabIndex = 21;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(635, 21);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(227, 230);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 20;
            this.pbxFoto.TabStop = false;
            // 
            // dtCobro
            // 
            this.dtCobro.Location = new System.Drawing.Point(343, 121);
            this.dtCobro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCobro.Name = "dtCobro";
            this.dtCobro.Size = new System.Drawing.Size(120, 25);
            this.dtCobro.TabIndex = 19;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.txtDetalles);
            this.gbDetalle.Location = new System.Drawing.Point(20, 171);
            this.gbDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetalle.Size = new System.Drawing.Size(469, 135);
            this.gbDetalle.TabIndex = 18;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            this.gbDetalle.Enter += new System.EventHandler(this.gbDetalle_Enter);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(11, 27);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(435, 85);
            this.txtDetalles.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Servicios_Ejecutivos.Properties.Resources.buy_gain_income_money_pay_payment_icon__19__Custom_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Location = new System.Drawing.Point(398, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 66);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.AutoSize = true;
            this.txtSaldo.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(393, 34);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(89, 30);
            this.txtSaldo.TabIndex = 13;
            this.txtSaldo.Text = "250.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saldo";
            // 
            // gbDias
            // 
            this.gbDias.Controls.Add(this.label13);
            this.gbDias.Controls.Add(this.chbDomingo);
            this.gbDias.Controls.Add(this.label12);
            this.gbDias.Controls.Add(this.cbxSemana);
            this.gbDias.Controls.Add(this.chbLunes);
            this.gbDias.Controls.Add(this.chbMartes);
            this.gbDias.Controls.Add(this.chbMiercoles);
            this.gbDias.Controls.Add(this.chbJueves);
            this.gbDias.Controls.Add(this.chbViernes);
            this.gbDias.Controls.Add(this.chbSabado);
            this.gbDias.Location = new System.Drawing.Point(28, 166);
            this.gbDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDias.Name = "gbDias";
            this.gbDias.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDias.Size = new System.Drawing.Size(453, 146);
            this.gbDias.TabIndex = 11;
            this.gbDias.TabStop = false;
            this.gbDias.Text = "Dias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "20";
            // 
            // chbDomingo
            // 
            this.chbDomingo.AutoSize = true;
            this.chbDomingo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbDomingo.Location = new System.Drawing.Point(349, 70);
            this.chbDomingo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDomingo.Name = "chbDomingo";
            this.chbDomingo.Size = new System.Drawing.Size(96, 24);
            this.chbDomingo.TabIndex = 17;
            this.chbDomingo.Text = "Domingo";
            this.chbDomingo.UseVisualStyleBackColor = true;
            this.chbDomingo.CheckedChanged += new System.EventHandler(this.chbDomingo_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Semana #";
            // 
            // cbxSemana
            // 
            this.cbxSemana.AutoSize = true;
            this.cbxSemana.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSemana.Location = new System.Drawing.Point(5, 21);
            this.cbxSemana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSemana.Name = "cbxSemana";
            this.cbxSemana.Size = new System.Drawing.Size(165, 24);
            this.cbxSemana.TabIndex = 10;
            this.cbxSemana.Text = "Semana Completa";
            this.cbxSemana.UseVisualStyleBackColor = true;
            this.cbxSemana.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbLunes
            // 
            this.chbLunes.AutoSize = true;
            this.chbLunes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbLunes.Location = new System.Drawing.Point(13, 70);
            this.chbLunes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbLunes.Name = "chbLunes";
            this.chbLunes.Size = new System.Drawing.Size(74, 24);
            this.chbLunes.TabIndex = 16;
            this.chbLunes.Text = "Lunes";
            this.chbLunes.UseVisualStyleBackColor = true;
            this.chbLunes.CheckedChanged += new System.EventHandler(this.chbLunes_CheckedChanged);
            // 
            // chbMartes
            // 
            this.chbMartes.AutoSize = true;
            this.chbMartes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbMartes.Location = new System.Drawing.Point(11, 97);
            this.chbMartes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMartes.Name = "chbMartes";
            this.chbMartes.Size = new System.Drawing.Size(82, 24);
            this.chbMartes.TabIndex = 15;
            this.chbMartes.Text = "Martes";
            this.chbMartes.UseVisualStyleBackColor = true;
            this.chbMartes.CheckedChanged += new System.EventHandler(this.chbMartes_CheckedChanged);
            // 
            // chbMiercoles
            // 
            this.chbMiercoles.AutoSize = true;
            this.chbMiercoles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbMiercoles.Location = new System.Drawing.Point(125, 70);
            this.chbMiercoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMiercoles.Name = "chbMiercoles";
            this.chbMiercoles.Size = new System.Drawing.Size(103, 24);
            this.chbMiercoles.TabIndex = 14;
            this.chbMiercoles.Text = "Miercoles";
            this.chbMiercoles.UseVisualStyleBackColor = true;
            this.chbMiercoles.CheckedChanged += new System.EventHandler(this.chbMiercoles_CheckedChanged);
            // 
            // chbJueves
            // 
            this.chbJueves.AutoSize = true;
            this.chbJueves.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbJueves.Location = new System.Drawing.Point(141, 97);
            this.chbJueves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbJueves.Name = "chbJueves";
            this.chbJueves.Size = new System.Drawing.Size(81, 24);
            this.chbJueves.TabIndex = 13;
            this.chbJueves.Text = "Jueves";
            this.chbJueves.UseVisualStyleBackColor = true;
            this.chbJueves.CheckedChanged += new System.EventHandler(this.chbJueves_CheckedChanged);
            // 
            // chbViernes
            // 
            this.chbViernes.AutoSize = true;
            this.chbViernes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbViernes.Location = new System.Drawing.Point(256, 70);
            this.chbViernes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbViernes.Name = "chbViernes";
            this.chbViernes.Size = new System.Drawing.Size(86, 24);
            this.chbViernes.TabIndex = 12;
            this.chbViernes.Text = "Viernes";
            this.chbViernes.UseVisualStyleBackColor = true;
            this.chbViernes.CheckedChanged += new System.EventHandler(this.chbViernes_CheckedChanged);
            // 
            // chbSabado
            // 
            this.chbSabado.AutoSize = true;
            this.chbSabado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbSabado.Location = new System.Drawing.Point(255, 97);
            this.chbSabado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbSabado.Name = "chbSabado";
            this.chbSabado.Size = new System.Drawing.Size(86, 24);
            this.chbSabado.TabIndex = 11;
            this.chbSabado.Text = "Sabado";
            this.chbSabado.UseVisualStyleBackColor = true;
            this.chbSabado.CheckedChanged += new System.EventHandler(this.chbSabado_CheckedChanged);
            // 
            // dgvCobros
            // 
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobros.Location = new System.Drawing.Point(12, 436);
            this.dgvCobros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.RowTemplate.Height = 24;
            this.dgvCobros.Size = new System.Drawing.Size(931, 257);
            this.dgvCobros.TabIndex = 11;
            this.dgvCobros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCobros_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(535, 436);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(404, 252);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar Vales";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 186);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 48);
            this.button5.TabIndex = 10;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(279, 128);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(94, 21);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "Excepcion";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(251, 33);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(48, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 129);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Serie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre de empresa  grande grande en todo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Folio";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 186);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::Servicios_Ejecutivos.Properties.Resources.internet_marketing_circle__Custom_;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(219, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 62);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button6_Click);
            // 
            // Cobro_de_Frecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Servicios_Ejecutivos.Properties.Resources._13879459_146906795746594_7204462386315017966_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 708);
            this.Controls.Add(this.dgvCobros);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cobro_de_Frecuencia";
            this.Text = "Cobro_de_Frecuencia";
            this.Load += new System.EventHandler(this.Cobro_de_Frecuencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbDias.ResumeLayout(false);
            this.gbDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxSemana;
        private System.Windows.Forms.DataGridView dgvCobros;
        private System.Windows.Forms.GroupBox gbDias;
        private System.Windows.Forms.CheckBox chbDomingo;
        private System.Windows.Forms.CheckBox chbLunes;
        private System.Windows.Forms.CheckBox chbMartes;
        private System.Windows.Forms.CheckBox chbMiercoles;
        private System.Windows.Forms.CheckBox chbJueves;
        private System.Windows.Forms.CheckBox chbViernes;
        private System.Windows.Forms.CheckBox chbSabado;
        private System.Windows.Forms.Label txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.DateTimePicker dtCobro;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox cbxSaldo;
        private System.Windows.Forms.CheckBox cbxEfectivo;
        private System.Windows.Forms.Button btnBuscar;
    }
}