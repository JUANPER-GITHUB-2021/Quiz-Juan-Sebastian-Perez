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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        public Report(string text)
        {
            InitializeComponent();
            rhtxtboxreporte.Text = text;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
