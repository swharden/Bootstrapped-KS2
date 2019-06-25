using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootstrappedKS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        valueSet valueSetA;
        valueSet valueSetB;
        KS2 ks;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNewData();
        }

        public void LoadNewData()
        {
            valueSetA = new valueSet(@"C:\Users\scott\Documents\GitHub\Bootstrapped-KS2\data\valuesA.csv", true);
            valueSetB = new valueSet(@"C:\Users\scott\Documents\GitHub\Bootstrapped-KS2\data\valuesB.csv", true);
            nudSampleSize.Maximum = Math.Min(valueSetA.count, valueSetB.count);
            UpdateGuiValueStats();
            CalculateKsAndUpdateGui();
        }

        public void UpdateGuiValueStats()
        {
            var tTestResult = Meta.Numerics.Statistics.Sample.StudentTTest(valueSetA.sample, valueSetB.sample);
            lblCountA.Text = string.Format("{0}", valueSetA.count);
            lblCountB.Text = string.Format("{0}", valueSetB.count);
            lblMeanA.Text = string.Format("{0:0.000}", valueSetA.mean);
            lblMeanB.Text = string.Format("{0:0.000}", valueSetB.mean);
            lblStdevA.Text = string.Format("{0:0.000}", valueSetA.stdev);
            lblStdevB.Text = string.Format("{0:0.0000}", valueSetB.stdev);
            lblStdErrA.Text = string.Format("{0:0.000}", valueSetA.stdErr);
            lblStdErrB.Text = string.Format("{0:0.000}", valueSetB.stdErr);
            lblValuesP.Text = string.Format("P = {0:0.0.000}", tTestResult.Probability);
            if (tTestResult.Probability < .001)
                lblValuesP.Text = string.Format("P = {0:0.000E+0}", tTestResult.Probability);
        }

        public void CalculateKsAndUpdateGui(bool lockHorizontal = false)
        {
            ks = new KS2(valueSetA.values, valueSetB.values, (double)nudBinSize.Value);

            Console.WriteLine($"BINSIZE: {ks.binSize}");

            lblKsD.Text = string.Format("D = {0:0.000000}", ks.D);
            lblKsP.Text = string.Format("P = {0:0.000000}", ks.P);
            if (ks.P < .001)
                lblKsP.Text = string.Format("P = {0:0.000E+0}", ks.P);
            UpdateGuiGraph(lockHorizontal);
        }
        public void UpdateGuiGraph(bool lockHorizontal = false)
        {
            scottPlotUC1.plt.Clear();

            if (rbHistogram.Checked)
            {
                scottPlotUC1.plt.PlotScatter(ks.bins, ks.countsA, label: "A", markerSize: 0, lineWidth: 2);
                scottPlotUC1.plt.PlotScatter(ks.bins, ks.countsB, label: "B", markerSize: 0, lineWidth: 2);
                scottPlotUC1.plt.PlotHLine(0, color: Color.Black);
                scottPlotUC1.plt.Title("Histogram");
                scottPlotUC1.plt.YLabel("Count (#)");
            }
            else if (rbCPH.Checked)
            {
                scottPlotUC1.plt.PlotScatter(ks.bins, ks.cphA, label: "A", markerSize: 0, lineWidth: 2);
                scottPlotUC1.plt.PlotScatter(ks.bins, ks.cphB, label: "B", markerSize: 0, lineWidth: 2);
                scottPlotUC1.plt.PlotHLine(0, color: Color.Black);
                scottPlotUC1.plt.Title("Cumulative Probability Histogram");
                scottPlotUC1.plt.YLabel("Probability (%)");
            }
            else if (rbKLine.Checked)
            {
                scottPlotUC1.plt.PlotScatter(ks.bins, ks.cphAbsDiff, label: "K Line", markerSize: 0, lineWidth: 2, color: Color.Red);
                scottPlotUC1.plt.PlotHLine(ks.D*100, label: "KStat (D)", lineWidth: 2, color: Color.Black);
                scottPlotUC1.plt.PlotHLine(0, color: Color.Black);
                scottPlotUC1.plt.Title("Absolute CPH Difference");
                scottPlotUC1.plt.YLabel("Delta Probability (%)");
            }

            double oldX1 = scottPlotUC1.plt.Axis()[0];
            double oldX2 = scottPlotUC1.plt.Axis()[1];
            scottPlotUC1.plt.AxisAuto();
            if (lockHorizontal)
                scottPlotUC1.plt.Axis(oldX1, oldX2, null, null);

            scottPlotUC1.plt.Legend();
            scottPlotUC1.Render();
        }




















        // GUI BINDINGS

        private void NudBinSize_ValueChanged(object sender, EventArgs e)
        {
            CalculateKsAndUpdateGui(lockHorizontal: true);
        }

        private void RbHistogram_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuiGraph();
        }

        private void RbCPH_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGuiGraph();
        }

        private void NudRunCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {

            // BOOTSTRAP KS TEST
            double[] valuesA = valueSetA.values;
            double[] valuesB = valueSetB.values;
            double binSize = (double)nudBinSize.Value;
            double[] bins = KSTools.CreateBins(valuesA, valuesB, binSize);

            int bootstrapCount = (int)nudRunCount.Value;
            int sampleSize = (int)nudSampleSize.Value;
            double[] bootstrapDs = new double[bootstrapCount];
            double[] bootstrapPs = new double[bootstrapCount];

            progressBar1.Maximum = bootstrapCount;
            btnRun.Enabled = false;
            for (int i = 0; i < bootstrapCount; i++)
            {
                progressBar1.Value = i;
                double[] cphA = KSTools.CumulativeSum(KSTools.GetHistogram(valueSetA.GetRandomSample(sampleSize), bins));
                double[] cphB = KSTools.CumulativeSum(KSTools.GetHistogram(valueSetB.GetRandomSample(sampleSize), bins));
                double D = KSTools.CalculateKsD(cphA, cphB);
                double P = KSTools.CalculateKsP(D, sampleSize, sampleSize);
                bootstrapDs[i] = D;
                bootstrapPs[i] = P;
            }
            btnRun.Enabled = true;

            double meanD = Meta.Numerics.Statistics.Univariate.Mean(bootstrapDs);
            double stdevD = Meta.Numerics.Statistics.Univariate.StandardDeviation(bootstrapDs);
            double meanP = Meta.Numerics.Statistics.Univariate.Mean(bootstrapPs);
            double stdevP = Meta.Numerics.Statistics.Univariate.StandardDeviation(bootstrapPs);
            lblBootstrapD.Text = $"D = {FormatNumber(stdevD)} +/- {FormatNumber(stdevD)}";
            lblBootstrapP.Text = $"P = {FormatNumber(meanP)} +/- {FormatNumber(stdevP)}";
        }

        public string FormatNumber(double value)
        {
            if (value<.001)
                return string.Format("{0:0.0000 E+0}", value);
            else
                return string.Format("{0:0.000000}", value);
        }
    }
}
