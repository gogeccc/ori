using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasinskoUcenje
{
    public class LinearRegression
    {
        public double k { get; set; }
        public double n { get; set; }

	    public void fit(double[] x, double[] y) {
            // TODO 2: implementirati fit funkciju koja odredjuje parametre k i n
            // y = kx + n
            double xySum = 0, xSum = 0, ySum = 0, xxSum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                xySum += x[i] * y[i];
                xSum += x[i];
                ySum += y[i];
                xxSum += x[i] * x[i];
                //Console.WriteLine("X" + x[i] + "Y" + y[i]);
            }
            var count = x.Length;
            this.k = (count*xySum - xSum*ySum) / (count*xxSum - xSum*xSum);
            this.n = (ySum - this.k*xSum) / count;
	    }

        public double predict(double x)
        {   
            // TODO 3: Implementirati funkciju predict koja na osnovu x vrednosti vraca
            // predvinjenu vrednost y = kx +n
            return this.k*x + this.n;
        }
    }
}
