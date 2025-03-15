using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    internal class TemperatureArray
    {
        private double[] array;

        public TemperatureArray(double mon, double tue, double wed, double thu, double fri, double sat, double sun)
            => array = new double[] { mon, tue, wed, thu, fri, sat, sun };

        public double this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public double Average()
        {
            return Math.Round((array.Sum() / array.Length), 2);
        }

        public void Show()
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
