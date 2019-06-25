using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrappedKS2
{
    public static class KSTools
    {
        public static void CalculateKS(double[] valuesA, double[] valuesB, double[] bins, ref double D, ref double P)
        {
            double[] countsA = GetHistogram(valuesA, bins);
            double[] countsB = GetHistogram(valuesB, bins);

            double[] cphA = CumulativeSum(countsA);
            double[] cphB = CumulativeSum(countsB);

            double[] cphAbsDiff = new double[cphA.Length];
            for (int i = 0; i < cphAbsDiff.Length; i++)
                cphAbsDiff[i] = Math.Abs(cphA[i] - cphB[i]);

            D = cphAbsDiff.Max();

            // This is the the Wikipedia formula (solved for P) and *2
            double k = D;
            double n = valuesA.Length;
            double m = valuesB.Length;
            P = Math.Exp((-2 * n * m * k * k) / (n + m)) * 2;
        }

        public static double[] GetHistogram(double[] values, double[] bins)
        {
            double binSize = bins[1] - bins[0];
            double[] counts = new double[bins.Length];
            for (int i = 0; i < values.Length; i++)
                counts[(int)((values[i] - bins[0]) / binSize)] += 1;
            return counts;
        }

        public static double[] CumulativeSum(double[] values, bool normalize = true)
        {
            double[] cumulativeSum = new double[values.Length];
            cumulativeSum[0] = values[0];
            for (int i = 1; i < values.Length; i++)
                cumulativeSum[i] = cumulativeSum[i - 1] + values[i];

            if (normalize)
            {
                double total = cumulativeSum[cumulativeSum.Length - 1];
                for (int i = 0; i < cumulativeSum.Length; i++)
                    cumulativeSum[i] = cumulativeSum[i] * 100.0 / total;
            }

            return cumulativeSum;
        }

        public static double[] CreateBins(double[] valuesA, double[] valuesB, double binSize, double? min = 0, double? max = null)
        {
            if (min == null)
                min = Math.Min(valuesA.Min(), valuesB.Min());
            if (max == null)
                max = Math.Max(valuesA.Max(), valuesB.Max());
            int binCount = (int)((max - min) / binSize) + 1;
            double[] bins = new double[binCount];
            for (int i = 0; i < bins.Length; i++)
                bins[i] = i * binSize + (double)min;
            return bins;
        }

        public static double[] CreateKsLine(double[] cphA, double[] cphB)
        {
            double[] ksLine = new double[cphA.Length];
            for (int i = 0; i < ksLine.Length; i++)
                ksLine[i] = Math.Abs(cphA[i] - cphB[i]);
            return ksLine;
        }

        public static double CalculateKsD(double[] cphA, double[] cphB)
        {
            double D = 0;
            for (int i=0; i<cphA.Length; i++)
            {
                double diff = Math.Abs(cphA[i] - cphB[i]);
                if (diff > D)
                    D = diff;
            }
            return D / 100.0;
        }

        public static double CalculateKsP(double D, int valueCountA, int valueCountB)
        {
            // This is the the Wikipedia formula (solved for P) * 2
            double k = D;
            double n = valueCountA;
            double m = valueCountB;
            double P = Math.Exp((-2 * n * m * k * k) / (n + m)) * 2;
            return P;
        }
    }
}
