using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrappedKS2
{
    public class valueSet
    {
        public int count { get; private set; }
        public double mean { get; private set; }
        public double stdev { get; private set; }
        public double stdErr { get; private set; }
        public Meta.Numerics.Statistics.Sample sample { get; private set; }
        public double[] values { get; private set; }

        private Random rand = new Random();

        public bool isValid { get { if (values != null && values.Length > 0) return true; else return false; } }

        public valueSet(double[] values)
        {
            this.values = values;
            if (values != null)
            {
                sample = new Meta.Numerics.Statistics.Sample(values);
                CalculateStatistics();
            }
        }

        public valueSet(string text, bool textIsFilename = false)
        {
            if (textIsFilename)
                text = System.IO.File.ReadAllText(text);
            SetValuesFromText(text);
            CalculateStatistics();
        }

        private void CalculateStatistics()
        {
            count = sample.Count;
            mean = sample.Mean;
            stdev = sample.StandardDeviation;
            stdErr = stdev / Math.Sqrt(sample.Count);
        }

        private void SetValuesFromText(string text)
        {
            string[] lines = text.Split('\n');
            List<double> valueList = new List<double>(lines.Length);
            foreach (string line in lines)
                if (double.TryParse(line, out double value))
                    valueList.Add(value);
            values = valueList.ToArray();
            sample = new Meta.Numerics.Statistics.Sample(values);
        }

        public double[] GetRandomSample(int count)
        {
            int[] randomKeys = new int[count];
            double[] randomValues = new double[count];

            for (int i = 0; i < randomKeys.Length; i++)
                randomKeys[i] = rand.Next(0, randomKeys.Length - 1);

            for (int i = 0; i < randomKeys.Length; i++)
                randomValues[i] = values[randomKeys[i]];

            return randomValues;
        }
    }
}
