﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio06.ConsoleApp
{
    internal class TemperaturaCelsiu
    {
        public double celsiu;
        public double ValorEmFarenheint
        {
            private set
            { }
            get
            {
                return TransformaCelsiuEmFahrenheint();
            }
        }
        private double TransformaCelsiuEmFahrenheint()
        {
            return (celsiu * 1.8) + 32;
        }
    }
}
