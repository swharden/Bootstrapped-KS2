using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootstrappedKS2
{

    public class KS2
    {
        public double[] valuesA { get; private set; }
        public double[] valuesB { get; private set; }
        public double[] bins { get; private set; }
        public double binSize { get { return bins[1] - bins[0]; } }
        public double[] countsA { get; private set; }
        public double[] countsB { get; private set; }
        public double[] cphA { get; private set; }
        public double[] cphB { get; private set; }
        public double[] cphAbsDiff { get; private set; }
        public double D { get; private set; }
        public double P { get; private set; }

        public KS2(double[] valuesA, double[] valuesB, double binSize)
        {
            this.valuesA = valuesA;
            this.valuesB = valuesB;

            bins = KSTools.CreateBins(valuesA, valuesB, binSize);

            countsA = KSTools.GetHistogram(valuesA, bins);
            countsB = KSTools.GetHistogram(valuesB, bins);

            cphA = KSTools.CumulativeSum(countsA);
            cphB = KSTools.CumulativeSum(countsB);

            cphAbsDiff = KSTools.CreateKsLine(cphA, cphB);

            D = cphAbsDiff.Max() / 100.0;
            P = KSTools.CalculateKsP(D, valuesA.Length, valuesB.Length);
        }
    }
}
