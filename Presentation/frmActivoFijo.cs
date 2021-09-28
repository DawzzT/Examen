using Domain;
using Domain.Enums;
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
    public partial class frmActivoFijo : Form
    {
        int count = 0;
        public frmActivoFijo()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {


            ActivoFijo actfijo = new ActivoFijo()
            {
                Id = count++,
                NombreActivo = txtNombre.Text,
                CodigoActivo = txtCodigo.Text,
                Descripcion = txtxtDescripcion.Text,
                ValorActivo = nudValor.Value,
                FechaAdquisicion = dtpAdquisicion.Value,
                ValorResidual = nudValorResidual.Value,
                MetodoDepresiacion = (MetodoDepresiacion)cmbTipoDepresiacion.SelectedIndex,
                tipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex

            };

        }
    }
}
