
namespace Lab01_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimpiarSum = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.restSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sumar = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LimpiarRest = new System.Windows.Forms.Button();
            this.txtNumX = new System.Windows.Forms.TextBox();
            this.restResta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Restar = new System.Windows.Forms.Button();
            this.txtNumY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LimpiarMult = new System.Windows.Forms.Button();
            this.txtNumF = new System.Windows.Forms.TextBox();
            this.restMult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Multpl = new System.Windows.Forms.Button();
            this.txtNumH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LimpiarDiv = new System.Windows.Forms.Button();
            this.txtNumT = new System.Windows.Forms.TextBox();
            this.restDiv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Dividir = new System.Windows.Forms.Button();
            this.txtNumP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LimpCelc = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.ConvCelc = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LimpFarenheit = new System.Windows.Forms.Button();
            this.txtCelc = new System.Windows.Forms.TextBox();
            this.convFarenheit = new System.Windows.Forms.Button();
            this.txtFaren = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(510, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones matematicas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LimpiarSum);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.restSuma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sumar);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suma";
            // 
            // LimpiarSum
            // 
            this.LimpiarSum.Location = new System.Drawing.Point(9, 114);
            this.LimpiarSum.Name = "LimpiarSum";
            this.LimpiarSum.Size = new System.Drawing.Size(75, 23);
            this.LimpiarSum.TabIndex = 8;
            this.LimpiarSum.Text = "Limpiar";
            this.LimpiarSum.UseVisualStyleBackColor = true;
            this.LimpiarSum.Click += new System.EventHandler(this.LimpiarSum_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(103, 22);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 7;
            // 
            // restSuma
            // 
            this.restSuma.Enabled = false;
            this.restSuma.Location = new System.Drawing.Point(103, 77);
            this.restSuma.Name = "restSuma";
            this.restSuma.Size = new System.Drawing.Size(100, 20);
            this.restSuma.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado:";
            // 
            // Sumar
            // 
            this.Sumar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sumar.ForeColor = System.Drawing.SystemColors.Control;
            this.Sumar.Location = new System.Drawing.Point(113, 113);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(78, 24);
            this.Sumar.TabIndex = 4;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = false;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(103, 49);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Segundo numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Primer numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LimpiarRest);
            this.groupBox2.Controls.Add(this.txtNumX);
            this.groupBox2.Controls.Add(this.restResta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Restar);
            this.groupBox2.Controls.Add(this.txtNumY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(264, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resta";
            // 
            // LimpiarRest
            // 
            this.LimpiarRest.Location = new System.Drawing.Point(9, 114);
            this.LimpiarRest.Name = "LimpiarRest";
            this.LimpiarRest.Size = new System.Drawing.Size(75, 23);
            this.LimpiarRest.TabIndex = 8;
            this.LimpiarRest.Text = "Limpiar";
            this.LimpiarRest.UseVisualStyleBackColor = true;
            this.LimpiarRest.Click += new System.EventHandler(this.LimpiarRest_Click);
            // 
            // txtNumX
            // 
            this.txtNumX.Location = new System.Drawing.Point(103, 22);
            this.txtNumX.Name = "txtNumX";
            this.txtNumX.Size = new System.Drawing.Size(100, 20);
            this.txtNumX.TabIndex = 7;
            // 
            // restResta
            // 
            this.restResta.Enabled = false;
            this.restResta.Location = new System.Drawing.Point(103, 77);
            this.restResta.Name = "restResta";
            this.restResta.Size = new System.Drawing.Size(100, 20);
            this.restResta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Resultado:";
            // 
            // Restar
            // 
            this.Restar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Restar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restar.ForeColor = System.Drawing.SystemColors.Control;
            this.Restar.Location = new System.Drawing.Point(113, 113);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(78, 24);
            this.Restar.TabIndex = 4;
            this.Restar.Text = "Restar";
            this.Restar.UseVisualStyleBackColor = false;
            this.Restar.Click += new System.EventHandler(this.Restar_Click);
            // 
            // txtNumY
            // 
            this.txtNumY.Location = new System.Drawing.Point(103, 49);
            this.txtNumY.Name = "txtNumY";
            this.txtNumY.Size = new System.Drawing.Size(100, 20);
            this.txtNumY.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Segundo numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Primer numero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LimpiarMult);
            this.groupBox3.Controls.Add(this.txtNumF);
            this.groupBox3.Controls.Add(this.restMult);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Multpl);
            this.groupBox3.Controls.Add(this.txtNumH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(23, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Multiplicación";
            // 
            // LimpiarMult
            // 
            this.LimpiarMult.Location = new System.Drawing.Point(9, 114);
            this.LimpiarMult.Name = "LimpiarMult";
            this.LimpiarMult.Size = new System.Drawing.Size(75, 23);
            this.LimpiarMult.TabIndex = 8;
            this.LimpiarMult.Text = "Limpiar";
            this.LimpiarMult.UseVisualStyleBackColor = true;
            this.LimpiarMult.Click += new System.EventHandler(this.LimpiarMult_Click);
            // 
            // txtNumF
            // 
            this.txtNumF.Location = new System.Drawing.Point(103, 22);
            this.txtNumF.Name = "txtNumF";
            this.txtNumF.Size = new System.Drawing.Size(100, 20);
            this.txtNumF.TabIndex = 7;
            // 
            // restMult
            // 
            this.restMult.Enabled = false;
            this.restMult.Location = new System.Drawing.Point(103, 77);
            this.restMult.Name = "restMult";
            this.restMult.Size = new System.Drawing.Size(100, 20);
            this.restMult.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Resultado:";
            // 
            // Multpl
            // 
            this.Multpl.BackColor = System.Drawing.Color.DodgerBlue;
            this.Multpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multpl.ForeColor = System.Drawing.SystemColors.Control;
            this.Multpl.Location = new System.Drawing.Point(113, 113);
            this.Multpl.Name = "Multpl";
            this.Multpl.Size = new System.Drawing.Size(78, 24);
            this.Multpl.TabIndex = 4;
            this.Multpl.Text = "Multiplicar";
            this.Multpl.UseVisualStyleBackColor = false;
            this.Multpl.Click += new System.EventHandler(this.Multpl_Click);
            // 
            // txtNumH
            // 
            this.txtNumH.Location = new System.Drawing.Point(103, 49);
            this.txtNumH.Name = "txtNumH";
            this.txtNumH.Size = new System.Drawing.Size(100, 20);
            this.txtNumH.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Segundo numero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Primer numero:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LimpiarDiv);
            this.groupBox4.Controls.Add(this.txtNumT);
            this.groupBox4.Controls.Add(this.restDiv);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.Dividir);
            this.groupBox4.Controls.Add(this.txtNumP);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(264, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 152);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "División";
            // 
            // LimpiarDiv
            // 
            this.LimpiarDiv.Location = new System.Drawing.Point(9, 114);
            this.LimpiarDiv.Name = "LimpiarDiv";
            this.LimpiarDiv.Size = new System.Drawing.Size(75, 23);
            this.LimpiarDiv.TabIndex = 8;
            this.LimpiarDiv.Text = "Limpiar";
            this.LimpiarDiv.UseVisualStyleBackColor = true;
            this.LimpiarDiv.Click += new System.EventHandler(this.LimpiarDiv_Click);
            // 
            // txtNumT
            // 
            this.txtNumT.Location = new System.Drawing.Point(103, 22);
            this.txtNumT.Name = "txtNumT";
            this.txtNumT.Size = new System.Drawing.Size(100, 20);
            this.txtNumT.TabIndex = 7;
            // 
            // restDiv
            // 
            this.restDiv.Enabled = false;
            this.restDiv.Location = new System.Drawing.Point(103, 77);
            this.restDiv.Name = "restDiv";
            this.restDiv.Size = new System.Drawing.Size(100, 20);
            this.restDiv.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Resultado:";
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.Color.DodgerBlue;
            this.Dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dividir.ForeColor = System.Drawing.SystemColors.Control;
            this.Dividir.Location = new System.Drawing.Point(113, 113);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(78, 24);
            this.Dividir.TabIndex = 4;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // txtNumP
            // 
            this.txtNumP.Location = new System.Drawing.Point(103, 49);
            this.txtNumP.Name = "txtNumP";
            this.txtNumP.Size = new System.Drawing.Size(100, 20);
            this.txtNumP.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Segundo numero:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Primer numero:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.LimpCelc);
            this.groupBox5.Controls.Add(this.txtF);
            this.groupBox5.Controls.Add(this.ConvCelc);
            this.groupBox5.Controls.Add(this.txtC);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.LimpFarenheit);
            this.groupBox5.Controls.Add(this.txtCelc);
            this.groupBox5.Controls.Add(this.convFarenheit);
            this.groupBox5.Controls.Add(this.txtFaren);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(23, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 148);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conversion temperaturas";
            // 
            // LimpCelc
            // 
            this.LimpCelc.Location = new System.Drawing.Point(239, 98);
            this.LimpCelc.Name = "LimpCelc";
            this.LimpCelc.Size = new System.Drawing.Size(75, 23);
            this.LimpCelc.TabIndex = 14;
            this.LimpCelc.Text = "Limpiar";
            this.LimpCelc.UseVisualStyleBackColor = true;
            this.LimpCelc.Click += new System.EventHandler(this.LimpCelc_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(307, 29);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 20);
            this.txtF.TabIndex = 13;
            // 
            // ConvCelc
            // 
            this.ConvCelc.BackColor = System.Drawing.Color.DodgerBlue;
            this.ConvCelc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvCelc.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvCelc.Location = new System.Drawing.Point(330, 98);
            this.ConvCelc.Name = "ConvCelc";
            this.ConvCelc.Size = new System.Drawing.Size(78, 24);
            this.ConvCelc.TabIndex = 12;
            this.ConvCelc.Text = "Convertir";
            this.ConvCelc.UseVisualStyleBackColor = false;
            this.ConvCelc.Click += new System.EventHandler(this.ConvCelc_Click);
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(307, 56);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Farenheit:";
            // 
            // LimpFarenheit
            // 
            this.LimpFarenheit.Location = new System.Drawing.Point(22, 98);
            this.LimpFarenheit.Name = "LimpFarenheit";
            this.LimpFarenheit.Size = new System.Drawing.Size(75, 23);
            this.LimpFarenheit.TabIndex = 8;
            this.LimpFarenheit.Text = "Limpiar";
            this.LimpFarenheit.UseVisualStyleBackColor = true;
            this.LimpFarenheit.Click += new System.EventHandler(this.LimpFarenheit_Click);
            // 
            // txtCelc
            // 
            this.txtCelc.Location = new System.Drawing.Point(90, 29);
            this.txtCelc.Name = "txtCelc";
            this.txtCelc.Size = new System.Drawing.Size(100, 20);
            this.txtCelc.TabIndex = 7;
            // 
            // convFarenheit
            // 
            this.convFarenheit.BackColor = System.Drawing.Color.DodgerBlue;
            this.convFarenheit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convFarenheit.ForeColor = System.Drawing.SystemColors.Control;
            this.convFarenheit.Location = new System.Drawing.Point(113, 98);
            this.convFarenheit.Name = "convFarenheit";
            this.convFarenheit.Size = new System.Drawing.Size(78, 24);
            this.convFarenheit.TabIndex = 4;
            this.convFarenheit.Text = "Convertir";
            this.convFarenheit.UseVisualStyleBackColor = false;
            this.convFarenheit.Click += new System.EventHandler(this.convFarenheit_Click);
            // 
            // txtFaren
            // 
            this.txtFaren.Enabled = false;
            this.txtFaren.Location = new System.Drawing.Point(90, 56);
            this.txtFaren.Name = "txtFaren";
            this.txtFaren.Size = new System.Drawing.Size(100, 20);
            this.txtFaren.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Farenheit:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Celcius:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(247, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Celcius:";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.DodgerBlue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(-4, 410);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(10);
            this.label18.Size = new System.Drawing.Size(510, 50);
            this.label18.TabIndex = 6;
            this.label18.Text = "Temperaturas";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 671);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox restSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button LimpiarSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LimpiarRest;
        private System.Windows.Forms.TextBox txtNumX;
        private System.Windows.Forms.TextBox restResta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Restar;
        private System.Windows.Forms.TextBox txtNumY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LimpiarMult;
        private System.Windows.Forms.TextBox txtNumF;
        private System.Windows.Forms.TextBox restMult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Multpl;
        private System.Windows.Forms.TextBox txtNumH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button LimpiarDiv;
        private System.Windows.Forms.TextBox txtNumT;
        private System.Windows.Forms.TextBox restDiv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.TextBox txtNumP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button LimpFarenheit;
        private System.Windows.Forms.TextBox txtCelc;
        private System.Windows.Forms.Button convFarenheit;
        private System.Windows.Forms.TextBox txtFaren;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button LimpCelc;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button ConvCelc;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

