
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
            this.components = new System.ComponentModel.Container();
            this.txtNombreclient = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.datefechapedido = new System.Windows.Forms.DateTimePicker();
            this.Lblpago = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.Lbltelcontact = new System.Windows.Forms.Label();
            this.Lblemail = new System.Windows.Forms.Label();
            this.LblDirección = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnumerocontact = new System.Windows.Forms.TextBox();
            this.txtemailclient = new System.Windows.Forms.TextBox();
            this.Lblentrega = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chListBoxPago = new System.Windows.Forms.CheckedListBox();
            this.Lblintro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chListBoxentrega = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreclient
            // 
            this.txtNombreclient.Location = new System.Drawing.Point(118, 79);
            this.txtNombreclient.Name = "txtNombreclient";
            this.txtNombreclient.Size = new System.Drawing.Size(302, 20);
            this.txtNombreclient.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(167, 363);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 31);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(15, 82);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(97, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre Completo :";
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // datefechapedido
            // 
            this.datefechapedido.Location = new System.Drawing.Point(118, 115);
            this.datefechapedido.Name = "datefechapedido";
            this.datefechapedido.Size = new System.Drawing.Size(200, 20);
            this.datefechapedido.TabIndex = 5;
            this.datefechapedido.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lblpago
            // 
            this.Lblpago.AutoSize = true;
            this.Lblpago.Location = new System.Drawing.Point(24, 255);
            this.Lblpago.Name = "Lblpago";
            this.Lblpago.Size = new System.Drawing.Size(88, 13);
            this.Lblpago.TabIndex = 6;
            this.Lblpago.Text = "Metodo de pago:";
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
            this.Lbltelcontact.Location = new System.Drawing.Point(0, 192);
            this.Lbltelcontact.Name = "Lbltelcontact";
            this.Lbltelcontact.Size = new System.Drawing.Size(112, 13);
            this.Lbltelcontact.TabIndex = 8;
            this.Lbltelcontact.Text = "Telefono de contacto:";
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
            this.toolTip1.SetToolTip(this.txtdireccion, "Si el cliente retira en el local, no es necesaria su dirección");
            // 
            // txtnumerocontact
            // 
            this.txtnumerocontact.Location = new System.Drawing.Point(118, 188);
            this.txtnumerocontact.Name = "txtnumerocontact";
            this.txtnumerocontact.Size = new System.Drawing.Size(302, 20);
            this.txtnumerocontact.TabIndex = 12;
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
            this.Lblentrega.Location = new System.Drawing.Point(19, 309);
            this.Lblentrega.Name = "Lblentrega";
            this.Lblentrega.Size = new System.Drawing.Size(93, 13);
            this.Lblentrega.TabIndex = 14;
            this.Lblentrega.Text = "Forma de entrega:";
            // 
            // chListBoxPago
            // 
            this.chListBoxPago.FormattingEnabled = true;
            this.chListBoxPago.Items.AddRange(new object[] {
            "Efectivo",
            "En línea"});
            this.chListBoxPago.Location = new System.Drawing.Point(118, 257);
            this.chListBoxPago.Name = "chListBoxPago";
            this.chListBoxPago.Size = new System.Drawing.Size(120, 34);
            this.chListBoxPago.TabIndex = 16;
            this.chListBoxPago.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // Lblintro
            // 
            this.Lblintro.AutoSize = true;
            this.Lblintro.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblintro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Lblintro.Location = new System.Drawing.Point(52, 27);
            this.Lblintro.Name = "Lblintro";
            this.Lblintro.Size = new System.Drawing.Size(335, 26);
            this.Lblintro.TabIndex = 17;
            this.Lblintro.Text = "REPOSTERIA Y PANADERIA HAPPY SWEET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Juan_Sebastian_Perez.Properties.Resources.LOGO_HAPPY_SWEET_opt;
            this.pictureBox1.Location = new System.Drawing.Point(426, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 367);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // chListBoxentrega
            // 
            this.chListBoxentrega.FormattingEnabled = true;
            this.chListBoxentrega.Items.AddRange(new object[] {
            "Retiro en el local",
            "Domicilio"});
            this.chListBoxentrega.Location = new System.Drawing.Point(118, 309);
            this.chListBoxentrega.Name = "chListBoxentrega";
            this.chListBoxentrega.Size = new System.Drawing.Size(120, 34);
            this.chListBoxentrega.TabIndex = 19;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 425);
            this.Controls.Add(this.chListBoxentrega);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lblintro);
            this.Controls.Add(this.chListBoxPago);
            this.Controls.Add(this.Lblentrega);
            this.Controls.Add(this.txtemailclient);
            this.Controls.Add(this.txtnumerocontact);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.LblDirección);
            this.Controls.Add(this.Lblemail);
            this.Controls.Add(this.Lbltelcontact);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.Lblpago);
            this.Controls.Add(this.datefechapedido);
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
        private System.Windows.Forms.TextBox txtNombreclient;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DateTimePicker datefechapedido;
        private System.Windows.Forms.Label Lblpago;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label Lbltelcontact;
        private System.Windows.Forms.Label Lblemail;
        private System.Windows.Forms.Label LblDirección;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnumerocontact;
        private System.Windows.Forms.TextBox txtemailclient;
        private System.Windows.Forms.Label Lblentrega;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox chListBoxPago;
        private System.Windows.Forms.Label Lblintro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox chListBoxentrega;
    }
}