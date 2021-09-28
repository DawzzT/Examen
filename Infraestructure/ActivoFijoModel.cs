using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class ActivoFijoModel
    {
        ActivoFijo [] activosfijos;

        public void Add (ActivoFijo actfijo)
        {
            Add(actfijo, ref activosfijos);
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




        private void Add(ActivoFijo af, ref ActivoFijo[] pds)
        {
            if (pds == null)
            {
                pds = new ActivoFijo[1];
                pds[pds.Length - 1] = af;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[pds.Length - 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = af;
            pds = tmp;
        }
    }
}
