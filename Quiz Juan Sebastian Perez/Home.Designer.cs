﻿
namespace Quiz_Juan_Sebastian_Perez
{
    partial class Home
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
            this.txtNombreclient = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Lblpago = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.Lbltelcontact = new System.Windows.Forms.Label();
            this.Lblemail = new System.Windows.Forms.Label();
            this.LblDirección = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtemailclient = new System.Windows.Forms.TextBox();
            this.Lblentrega = new System.Windows.Forms.Label();
            this.Lblintro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbtnPagoE = new System.Windows.Forms.RadioButton();
            this.rdbtnPagoL = new System.Windows.Forms.RadioButton();
            this.rdbtnEntregaD = new System.Windows.Forms.RadioButton();
            this.rdbtnEntregaR = new System.Windows.Forms.RadioButton();
            this.rhtxtboxreporte = new System.Windows.Forms.RichTextBox();
            this.Datefecha = new System.Windows.Forms.DateTimePicker();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtguardado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreclient
            // 
            this.txtNombreclient.Location = new System.Drawing.Point(118, 79);
            this.txtNombreclient.Name = "txtNombreclient";
            this.txtNombreclient.Size = new System.Drawing.Size(302, 20);
            this.txtNombreclient.TabIndex = 2;
            this.txtNombreclient.TextChanged += new System.EventHandler(this.txtNombreclient_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(90, 363);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 31);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(15, 82);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(97, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre Completo :";
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblpago
            // 
            this.Lblpago.AutoSize = true;
            this.Lblpago.Location = new System.Drawing.Point(24, 267);
            this.Lblpago.Name = "Lblpago";
            this.Lblpago.Size = new System.Drawing.Size(88, 13);
            this.Lblpago.TabIndex = 6;
            this.Lblpago.Text = "Método de pago:";
            this.Lblpago.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(72, 119);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(40, 13);
            this.LblDate.TabIndex = 7;
            this.LblDate.Text = "Fecha:";
            this.LblDate.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Lbltelcontact
            // 
            this.Lbltelcontact.AutoSize = true;
            this.Lbltelcontact.Location = new System.Drawing.Point(0, 193);
            this.Lbltelcontact.Name = "Lbltelcontact";
            this.Lbltelcontact.Size = new System.Drawing.Size(112, 13);
            this.Lbltelcontact.TabIndex = 8;
            this.Lbltelcontact.Text = "Teléfono de contacto:";
            this.Lbltelcontact.Click += new System.EventHandler(this.Lbltelcontact_Click);
            // 
            // Lblemail
            // 
            this.Lblemail.AutoSize = true;
            this.Lblemail.Location = new System.Drawing.Point(77, 155);
            this.Lblemail.Name = "Lblemail";
            this.Lblemail.Size = new System.Drawing.Size(35, 13);
            this.Lblemail.TabIndex = 9;
            this.Lblemail.Text = "Email:";
            this.Lblemail.Click += new System.EventHandler(this.Lblemail_Click);
            // 
            // LblDirección
            // 
            this.LblDirección.AutoSize = true;
            this.LblDirección.Location = new System.Drawing.Point(10, 229);
            this.LblDirección.Name = "LblDirección";
            this.LblDirección.Size = new System.Drawing.Size(102, 13);
            this.LblDirección.TabIndex = 10;
            this.LblDirección.Text = "Dirección Completa:";
            this.LblDirección.Click += new System.EventHandler(this.LblDirección_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(118, 225);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(302, 20);
            this.txtdireccion.TabIndex = 11;
            // 
            // txtemailclient
            // 
            this.txtemailclient.Location = new System.Drawing.Point(118, 151);
            this.txtemailclient.Name = "txtemailclient";
            this.txtemailclient.Size = new System.Drawing.Size(302, 20);
            this.txtemailclient.TabIndex = 13;
            // 
            // Lblentrega
            // 
            this.Lblentrega.AutoSize = true;
            this.Lblentrega.Location = new System.Drawing.Point(19, 307);
            this.Lblentrega.Name = "Lblentrega";
            this.Lblentrega.Size = new System.Drawing.Size(93, 13);
            this.Lblentrega.TabIndex = 14;
            this.Lblentrega.Text = "Forma de entrega:";
            // 
            // Lblintro
            // 
            this.Lblintro.AutoSize = true;
            this.Lblintro.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblintro.ForeColor = System.Drawing.Color.SteelBlue;
            this.Lblintro.Location = new System.Drawing.Point(52, 27);
            this.Lblintro.Name = "Lblintro";
            this.Lblintro.Size = new System.Drawing.Size(335, 26);
            this.Lblintro.TabIndex = 17;
            this.Lblintro.Text = "REPOSTERÍA Y PANADERÍA HAPPY SWEET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(465, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 367);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rdbtnPagoE
            // 
            this.rdbtnPagoE.AutoSize = true;
            this.rdbtnPagoE.Location = new System.Drawing.Point(156, 265);
            this.rdbtnPagoE.Name = "rdbtnPagoE";
            this.rdbtnPagoE.Size = new System.Drawing.Size(64, 17);
            this.rdbtnPagoE.TabIndex = 20;
            this.rdbtnPagoE.TabStop = true;
            this.rdbtnPagoE.Text = "Efectivo";
            this.rdbtnPagoE.UseVisualStyleBackColor = true;
            // 
            // rdbtnPagoL
            // 
            this.rdbtnPagoL.AutoSize = true;
            this.rdbtnPagoL.Location = new System.Drawing.Point(293, 265);
            this.rdbtnPagoL.Name = "rdbtnPagoL";
            this.rdbtnPagoL.Size = new System.Drawing.Size(65, 17);
            this.rdbtnPagoL.TabIndex = 21;
            this.rdbtnPagoL.TabStop = true;
            this.rdbtnPagoL.Text = "En línea";
            this.rdbtnPagoL.UseVisualStyleBackColor = true;
            // 
            // rdbtnEntregaD
            // 
            this.rdbtnEntregaD.AutoSize = true;
            this.rdbtnEntregaD.Location = new System.Drawing.Point(293, 305);
            this.rdbtnEntregaD.Name = "rdbtnEntregaD";
            this.rdbtnEntregaD.Size = new System.Drawing.Size(106, 17);
            this.rdbtnEntregaD.TabIndex = 22;
            this.rdbtnEntregaD.TabStop = true;
            this.rdbtnEntregaD.Text = "Envío a domicilio";
            this.rdbtnEntregaD.UseVisualStyleBackColor = true;
            // 
            // rdbtnEntregaR
            // 
            this.rdbtnEntregaR.AutoSize = true;
            this.rdbtnEntregaR.Location = new System.Drawing.Point(156, 305);
            this.rdbtnEntregaR.Name = "rdbtnEntregaR";
            this.rdbtnEntregaR.Size = new System.Drawing.Size(93, 17);
            this.rdbtnEntregaR.TabIndex = 23;
            this.rdbtnEntregaR.TabStop = true;
            this.rdbtnEntregaR.Text = "Retiro en local";
            this.rdbtnEntregaR.UseVisualStyleBackColor = true;
            this.rdbtnEntregaR.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rhtxtboxreporte
            // 
            this.rhtxtboxreporte.Location = new System.Drawing.Point(910, 56);
            this.rhtxtboxreporte.Name = "rhtxtboxreporte";
            this.rhtxtboxreporte.Size = new System.Drawing.Size(299, 338);
            this.rhtxtboxreporte.TabIndex = 28;
            this.rhtxtboxreporte.Text = "";
            // 
            // Datefecha
            // 
            this.Datefecha.Location = new System.Drawing.Point(118, 115);
            this.Datefecha.Name = "Datefecha";
            this.Datefecha.Size = new System.Drawing.Size(211, 20);
            this.Datefecha.TabIndex = 29;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(118, 189);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(154, 20);
            this.txttelefono.TabIndex = 30;
            // 
            // txtguardado
            // 
            this.txtguardado.Location = new System.Drawing.Point(589, 1);
            this.txtguardado.Name = "txtguardado";
            this.txtguardado.Size = new System.Drawing.Size(147, 20);
            this.txtguardado.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(1018, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "REPORTE";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // btnreporte
            // 
            this.btnreporte.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreporte.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.Location = new System.Drawing.Point(253, 363);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(105, 31);
            this.btnreporte.TabIndex = 33;
            this.btnreporte.Text = "Reporte";
            this.btnreporte.UseVisualStyleBackColor = false;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 442);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtguardado);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.Datefecha);
            this.Controls.Add(this.rhtxtboxreporte);
            this.Controls.Add(this.rdbtnEntregaR);
            this.Controls.Add(this.rdbtnEntregaD);
            this.Controls.Add(this.rdbtnPagoL);
            this.Controls.Add(this.rdbtnPagoE);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lblintro);
            this.Controls.Add(this.Lblentrega);
            this.Controls.Add(this.txtemailclient);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.LblDirección);
            this.Controls.Add(this.Lblemail);
            this.Controls.Add(this.Lbltelcontact);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.Lblpago);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtNombreclient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(870, 464);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del pedido";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label Lblpago;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label Lbltelcontact;
        private System.Windows.Forms.Label Lblemail;
        private System.Windows.Forms.Label LblDirección;
        private System.Windows.Forms.Label Lblentrega;
        private System.Windows.Forms.Label Lblintro;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton rdbtnPagoE;
        public System.Windows.Forms.RadioButton rdbtnPagoL;
        public System.Windows.Forms.RadioButton rdbtnEntregaD;
        public System.Windows.Forms.RadioButton rdbtnEntregaR;
        public System.Windows.Forms.TextBox txtNombreclient;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtemailclient;
        private System.Windows.Forms.RichTextBox rhtxtboxreporte;
        private System.Windows.Forms.DateTimePicker Datefecha;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtguardado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreporte;
    }
}