using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Juan_Sebastian_Perez
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombreclient.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtguardado.Visible = false;
            string pago = "No hay datos";
            string entrega = "No hay datos";
            if (rdbtnPagoE.Checked == true) ;
                pago = "El pago es en efectivo";
            if (rdbtnPagoL.Checked == true) ;
                pago = "El pago es en Línea";
            if (rdbtnEntregaR.Checked == true) ;
                entrega = "La entrega es en el local";
            if (rdbtnEntregaD.Checked == true) ;
                entrega = "La entrega es a domicilio";
            rhtxtboxreporte.Text = "Datos del pedido \n" + "Nombre completo: " + txtNombreclient.Text + "\n" + "Fecha: " + Datefecha.Text + "\n" + "Email: " 
            + txtemailclient.Text + "\n" + "Teléfono de contacto: " + txttelefono.Text + "\n" + "Dirección completa: " + txtdireccion.Text + "\n" + "Método de pago: " 
            + pago + "\n" + "Forma de entrega: " + entrega + "-------------------------------------------------------------------- \n" + txtguardado.Text;
            Clipboard.SetText(rhtxtboxreporte.Text);
            txtguardado.Text = Clipboard.GetText();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void LblDirección_Click(object sender, EventArgs e)
        {

        }

        private void Lbltelcontact_Click(object sender, EventArgs e)
        {

        }

        private void Lblemail_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rhtxtboxdatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            string Reporte = rhtxtboxreporte.Text;
            Form Formulario = new Report(Reporte);
            Formulario.Show();
        }
    }
}
