using Domain;
using Domain.Enums;
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
    public partial class frmActivoFijo : Form
    {
        public ActivoFijoModel afijo { get; set; }
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
            int value = 0;
            switch (cmbTipoActivo.SelectedIndex)
            {
                case 0:
                    value = 20;
                    break;
                case 1:
                    value = 5;
                    break;
                case 2:
                    value = 3;
                    break;
                case 3:
                    value = 2;
                    break;
                case 4:
                    value = 1;
                    break;
            }


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
                tipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex,
                VidaUtil = value
            };

        }
    }
}
