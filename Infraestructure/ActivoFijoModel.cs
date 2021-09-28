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

        public decimal Depreciacion(ActivoFijo actfijo)
        {
            if (actfijo.MetodoDepresiacion == 0)
            {
                decimal Depreciacion = 0;
                Depreciacion = (actfijo.ValorActivo - actfijo.ValorResidual) / actfijo.VidaUtil;

                return Depreciacion;
            }
            else
            {
                decimal importe = actfijo.ValorActivo - actfijo.ValorResidual;
                int periodos = 0;
                int j = 1;
                for (int i = 1; i <= actfijo.VidaUtil; i++)
                {
                    j += i;
                }
                decimal depreciacion = importe / j;
                return depreciacion;
            }

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

        public string ImprimirActivos()
        {

            string result = "";

            foreach (ActivoFijo p in activosfijos)
            {
                result += "-ID: " + p.Id.ToString() + "   Nombre: " + p.NombreActivo.ToString() +
                              "   Codigo: " + p.CodigoActivo.ToString() + "  Valor: " + p.ValorActivo.ToString() +
                              "   Fecha: " + p.FechaAdquisicion.ToString() + "   Tipo de Activo: " + p.tipoActivoFijo.ToString() +
                              "   Vida útil: "+p.VidaUtil.ToString()+"  Depreciacion: "+Depreciacion(p)+"\n";


            }
            return result;
        }
    }
}
