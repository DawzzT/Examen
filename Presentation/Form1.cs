using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public ActivoFijoModel actfjo;
        public Form1()
        {
            actfjo = new ActivoFijoModel();
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;

            frmActivoFijo frmaf = new frmActivoFijo();
            frmaf.afijo = actfjo;
            frmaf.ShowDialog();

            richTextBox1.Text = actfjo.ImprimirActivos();
        }
    }
}
