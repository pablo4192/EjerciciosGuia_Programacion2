﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface_Ej02
{
    public class PaquetePesado: Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {

        }

        public override bool TienePrioridad { get { return false; } }

        decimal IAfip.Impuestos
        {
            get { return this.costoEnvio * (decimal)0.25; }
        
        }

        public override decimal AplicarImpuestos()
        {
            return base.AplicarImpuestos() + ((IAfip)this).Impuestos;
        }


    }
}
