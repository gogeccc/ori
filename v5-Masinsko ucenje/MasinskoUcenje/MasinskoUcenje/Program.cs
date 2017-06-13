using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasinskoUcenje
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearRegression test = new LinearRegression();
            KMeans kmeans = new KMeans(); // inicijalizacija

            // TODO 1: Ucitati skup podataka iz data foldera. 
            System.IO.StreamReader file = new System.IO.StreamReader("C:/Users/gogec/Desktop/TEST.csv");
            file.ReadLine();
            string line;
            List<double> xlist = new List<double>(), ylist = new List<double>();
            while ((line = file.ReadLine()) != null) 
            {
                var splittedLine = line.Split(',');
                xlist.Add(Double.Parse(splittedLine[3]));
                ylist.Add(Double.Parse(splittedLine[4]));
                //Console.WriteLine(Double.Parse(splittedLine[3]) + "|" + double.Parse(splittedLine[4]));
            }
            double[] x, y;
            x = xlist.ToArray();
            y = ylist.ToArray();
            // TODO 4: Izvršiti linearnu regresiju
            // kolokvijum: 
            double[] kolok_prediction_input = { 7.1, 7.4, 8.5 };
            test.fit(x, y);
            Console.WriteLine("foobar k: " + test.k + ", foobar n: " + test.n);
            Console.ReadKey();
            List<double> yPredictedList = new List<double>();
            double[] yPredictedArray;
            foreach (double xelem in kolok_prediction_input)
            {
                double yPred = test.predict(xelem);
                yPredictedList.Add(yPred);
                Console.WriteLine("X: " + xelem + " | Y: " + yPred);
            }
            yPredictedArray = yPredictedList.ToArray();
            Console.ReadKey();
            // TODO 9: Klasterizovati američke države na osnovu geografkse dužine i širine           
            
        }
    }
}
