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

        valueSet valueSetA = new valueSet(null);
        valueSet valueSetB = new valueSet(null);
        valueSet valueSetAll = new valueSet(null);
        KS2 ks;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNewData();
        }

        public void LoadNewData()
        {
            string devPathA = @"C:\Users\scott\Documents\GitHub\Bootstrapped-KS2\data\valuesA.csv";
            string devPathB = @"C:\Users\scott\Documents\GitHub\Bootstrapped-KS2\data\valuesB.csv";
            if (System.IO.File.Exists(devPathA))
                valueSetA = new valueSet(devPathA, true);
            if (System.IO.File.Exists(devPathB))
                valueSetB = new valueSet(devPathB, true);
            ProcessNewDataSets();
            UpdateIdealSampleSize();
        }

        public void UpdateIdealSampleSize()
        {
            if (valueSetA.isValid && valueSetB.isValid)
            {
                int idealSampleSize = idealSampleSizeForBootstrapping((double)nudSignificance.Value, (double)nudPower.Value, (double)nudMeanDiff.Value);
                tbSampleSize.Text = idealSampleSize.ToString();
                double idealSamplePercent = idealSampleSize * 100.0 / Math.Min(valueSetA.count, valueSetB.count);
                lblSampleEstimatorMessage.Text = string.Format("{0:0.0}% of available samples", idealSamplePercent);
                groupSampleEstimator.Enabled = true;
            }
            else
            {
                groupSampleEstimator.Enabled = false;
                lblSampleEstimatorMessage.Text = "--";
            }
        }

        public int idealSampleSizeForBootstrapping(double significance = .05, double power = 0.90, double? manualMeanDiff = null)
        {
            // determine the ideal number of samples for bootstrapping
            var dist = new Meta.Numerics.Statistics.Distributions.NormalDistribution();
            double z = dist.InverseLeftProbability(significance / 2) - dist.InverseLeftProbability(power);
            double zSquared = Math.Pow(z, 2);
            double meanDiff = Math.Abs(valueSetA.mean - valueSetB.mean);
            if (manualMeanDiff != null)
                meanDiff = (double)manualMeanDiff;
            double meanDiffSquared = Math.Pow(meanDiff, 2);
            double totalStdevSquared = Math.Pow(valueSetAll.stdev, 2);
            double idealSampleSize = 2 * totalStdevSquared * zSquared / meanDiffSquared; // TODO: make XOR-safe
            return (int)idealSampleSize;
        }

        public void ProcessNewDataSets()
        {
            if (valueSetA.isValid && valueSetB.isValid)
            {
                double[] allValues = new double[valueSetA.values.Length + valueSetB.values.Length];
                Array.Copy(valueSetA.values, 0, allValues, 0, valueSetA.values.Length);
                Array.Copy(valueSetB.values, 0, allValues, valueSetA.values.Length, valueSetB.values.Length);
                valueSetAll = new valueSet(allValues);

                nudSampleSize.Maximum = Math.Min(valueSetA.count, valueSetB.count);
                double meanDiff = Math.Abs(valueSetA.mean - valueSetB.mean);
                if (meanDiff >= (double)nudMeanDiff.Minimum)
                    nudMeanDiff.Value = (decimal)meanDiff;
            }

            UpdateGuiValueStats();
            CalculateKsAndUpdateGui();
            UpdateIdealSampleSize();
        }

        public void UpdateGuiValueStats()
        {

            if (valueSetA.isValid)
            {
                lblCountA.Text = string.Format("{0}", valueSetA.count);
                lblMeanA.Text = string.Format("{0:0.000}", valueSetA.mean);
                lblStdevA.Text = string.Format("{0:0.000}", valueSetA.stdev);
                lblStdErrA.Text = string.Format("{0:0.000}", valueSetA.stdErr);
            }
            else
            {
                lblCountA.Text = "--";
                lblMeanA.Text = "--";
                lblStdevA.Text = "--";
                lblStdErrA.Text = "--";
            }

            if (valueSetB.isValid)
            {
                lblCountB.Text = string.Format("{0}", valueSetB.count);
                lblMeanB.Text = string.Format("{0:0.000}", valueSetB.mean);
                lblStdevB.Text = string.Format("{0:0.0000}", valueSetB.stdev);
                lblStdErrB.Text = string.Format("{0:0.000}", valueSetB.stdErr);
            }
            else
            {
                lblCountB.Text = "--";
                lblMeanB.Text = "--";
                lblStdevB.Text = "--";
                lblStdErrB.Text = "--";
            }

            if (valueSetA.isValid && valueSetB.isValid)
            {
                var tTestResult = Meta.Numerics.Statistics.Sample.StudentTTest(valueSetA.sample, valueSetB.sample);
                lblValuesP.Text = string.Format("P = {0:0.0.000}", tTestResult.Probability);
                if (tTestResult.Probability < .001)
                    lblValuesP.Text = string.Format("P = {0:0.000E+0}", tTestResult.Probability);
            }
            else
            {
                lblValuesP.Text = "--";
            }
        }

        public void CalculateKsAndUpdateGui(bool lockHorizontal = false)
        {
            if (valueSetA.isValid && valueSetB.isValid)
            {
                ks = new KS2(valueSetA.values, valueSetB.values, (double)nudBinSize.Value);
                Console.WriteLine($"BINSIZE: {ks.binSize}");
                lblKsD.Text = string.Format("D = {0:0.000000}", ks.D);
                lblKsP.Text = string.Format("P = {0:0.000000}", ks.P);
                if (ks.P < .001)
                    lblKsP.Text = string.Format("P = {0:0.000E+0}", ks.P);
                UpdateGuiGraph(lockHorizontal);
                groupBootstrap.Enabled = true;
            }
            else
            {
                lblKsD.Text = "--";
                lblKsP.Text = "--";
                groupBootstrap.Enabled = false;
                scottPlotUC1.plt.Clear();
                scottPlotUC1.Render();
            }
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
                scottPlotUC1.plt.PlotHLine(ks.D * 100, label: "KStat (D)", lineWidth: 2, color: Color.Black);
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

        private void BtnPasteA_Click(object sender, EventArgs e)
        {
            valueSetA = new valueSet(Clipboard.GetText());
            ProcessNewDataSets();
        }

        private void BtnPasteB_Click(object sender, EventArgs e)
        {
            valueSetB = new valueSet(Clipboard.GetText());
            ProcessNewDataSets();
        }

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
                progressBar1.Value = i+1;
                progressBar1.Value = i;
                double[] cphA = KSTools.CumulativeSum(KSTools.GetHistogram(valueSetA.GetRandomSample(sampleSize), bins));
                double[] cphB = KSTools.CumulativeSum(KSTools.GetHistogram(valueSetB.GetRandomSample(sampleSize), bins));
                double D = KSTools.CalculateKsD(cphA, cphB);
                double P = KSTools.CalculateKsP(D, sampleSize, sampleSize);
                bootstrapDs[i] = D;
                bootstrapPs[i] = P;
            }
            progressBar1.Value = 0;
            btnRun.Enabled = true;

            double meanD = Meta.Numerics.Statistics.Univariate.Mean(bootstrapDs);
            double stdevD = Meta.Numerics.Statistics.Univariate.StandardDeviation(bootstrapDs);
            double meanP = Meta.Numerics.Statistics.Univariate.Mean(bootstrapPs);
            double stdevP = Meta.Numerics.Statistics.Univariate.StandardDeviation(bootstrapPs);
            rtbBootstrapResults.Clear();
            rtbBootstrapResults.Text += string.Format("D = {0} +/- {1} ({2:0.00} %)\n", FormatNumber(meanD), FormatNumber(stdevD), 100 * stdevD / meanD);
            rtbBootstrapResults.Text += string.Format("P = {0} +/- {1}\n", FormatNumber(meanP), FormatNumber(stdevP));
            rtbBootstrapResults.Text += string.Format("P(D) = {0}", KSTools.CalculateKsP(meanD, sampleSize, sampleSize));
        }

        public string FormatNumber(double value)
        {
            if (value < .001)
                return string.Format("{0:0.0000 E+0}", value);
            else
                return string.Format("{0:0.000000}", value);
        }

        private void NudMeanDiff_ValueChanged(object sender, EventArgs e)
        {
            UpdateIdealSampleSize();
        }

        private void NudSignificance_ValueChanged(object sender, EventArgs e)
        {
            UpdateIdealSampleSize();
        }

        private void NudPower_ValueChanged(object sender, EventArgs e)
        {
            UpdateIdealSampleSize();
        }
    }
}
