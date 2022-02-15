using System;
using System.Text;

namespace Guia_Herencia_EjC02
{
    public class VehiculoDeCarrera
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustible 
        { 
            get { return this.cantidadCombustible; }
            set
            {
                if (value > 0)
                    this.cantidadCombustible = value;
            }
                
        }
        public bool EnCompetencia 
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
            
        }

        public string Escuderia 
        {
            get { return this.escuderia; } 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.escuderia = value;
            }
        }

        public short Numero 
        {
            get { return this.numero; } 
            set
            {
                if (value >= 0)
                    this.numero = value;
            }
        }
        public short VueltasRestantes 
        {
            get { return this.vueltasRestantes; }
            set
            {
                if (value > 0)
                    this.vueltasRestantes = value;
            }
        }

        //MostrareDatos() No se agrega ya que habra problemas con el mismo metodo en clase derivadas, se arregla con polimorfismo, proximo tema.

        //public string MostrarDatos()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("Datos del vehiculo");
        //    sb.AppendLine($"Cantidad combustible: {this.cantidadCombustible}");
        //    sb.AppendLine($"Escuderia: {this.escuderia}");
        //    sb.AppendLine($"Numero: {this.numero}");
        //    if(this.enCompetencia)
        //    {
        //        sb.AppendLine("El vehiculo se encuentra en competencia");
        //        sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
        //    }
        //    else
        //    {
        //        sb.AppendLine($"El Vehiculo no se encuentra compitiendo");
        //    }
        //    return sb.ToString();
        //}

    }
}
