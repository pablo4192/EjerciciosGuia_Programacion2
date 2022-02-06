using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicio7
{
    public class Empleado
    {
        float valorHora;
        string nombre;
        int antiguedad;
        float horasTrabajadasMes;
        double totalBruto;
        double totalNeto;

        public Empleado()
        {

        }

        public float ValorHora
        {
            get { return valorHora; }
            set 
            { 
                if(value > 0)
                {
                    valorHora = value;
                }
                
            }
        }

        public string Nombre 
        {
            get { return nombre; } 
            set 
            {
                if(!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                
            } 
        }

        

        public int Antiguedad
        {
            get { return antiguedad; }
            set 
            { 
                if(value > 0)
                {
                    antiguedad = value;
                }
                
            }
        }

        public float HorasTrabajadas
        {
            get { return horasTrabajadasMes; }
            set 
            { 
                if(value > 0)
                {
                    horasTrabajadasMes = value;
                }
                
            }
        }

        public double TotalBruto
        {
            get { return totalBruto; }
            set { totalBruto = value; }
        }
        
        public double TotalNeto
        {
            get { return totalNeto; }
            set { totalNeto = value; }
        }

    }
}
