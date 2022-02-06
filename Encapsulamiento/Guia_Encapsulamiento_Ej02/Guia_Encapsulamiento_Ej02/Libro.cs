using System;
using System.Collections.Generic;

namespace Guia_Encapsulamiento_Ej02
{
    public class Libro
    {
        List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }

        public string this[int i] 
        {
            get
            {
                if(i > paginas.Count || i < 0)
                {
                    return string.Empty;
                }
                return paginas[i]; 
            }
            
            set
            {
                if(i >= 0)
                {
                    if(i < paginas.Count)
                    {
                        this.paginas[i] = value;
                    }
                    else
                    {
                        this.paginas.Add(value);
                    }
                }
                
            }

        }

    }
}
