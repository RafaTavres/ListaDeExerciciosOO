using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio06.ConsoleApp
{
    internal class Temperatura
    {
        private double celsiu;
        public double Farenheint
        {
            private set
            { }
            get
            {
                return TransformaCelsiuEmFahrenheint();
            }
        }

        public double PegaCelsiuDoUsuario()
        {
            Console.Write("-------------\nTemperatura em F°: ");
            celsiu = Convert.ToDouble(Console.ReadLine());
            return celsiu;
        }
        private double TransformaCelsiuEmFahrenheint()
        {
            return (celsiu * 1.8) + 32;
        }
    }
}
