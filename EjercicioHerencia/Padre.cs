﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Padre
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }

        public DateTime FechaNac { get; set; }
        public int Edad { get; set; }

        public Padre()
        {
            Nombre =  "";
            Apellido = "";
            Direccion = "";
        }
        
        public int calculo_edad()
        {
            TimeSpan edad = FechaNac - DateTime.Now;
            int fecha = int.Parse(edad.ToString());
            return(fecha);
        }
    }
}
