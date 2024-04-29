using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Catedratico:Padre
    {
        public string Titulo { get; set; }
        public int Colegiado { get; set; }
        public Catedratico()
        {
            Titulo= string.Empty;
        }
    }
}
