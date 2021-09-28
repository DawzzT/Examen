using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    class ActivoFijoModel
    {
        ActivoFijoModel [] activosfijos;

        public void Add (ActivoFijo actfijo)
        {
            
        }

        public decimal DepreciacionLineaRecta (ActivoFijo actfijo)
        {
            decimal Depreciacion = 0;
            Depreciacion = (actfijo.ValorActivo - actfijo.ValorResidual) / actfijo.VidaUtil;

            return Depreciacion;
        }

        public decimal DepreciacionDecremental(ActivoFijo actfijo)
        {
            decimal importe = actfijo.ValorActivo - actfijo.ValorResidual;
            int periodos = 0;
            int j = 1;
            for (int i = 1; i<= actfijo.VidaUtil; i++)
            {
                j += i;
            }
            decimal depreciacion = importe / j;
            return depreciacion;
        }
    }
}
