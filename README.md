# Bootstrapped KS2 Tester

The ***Bootstrapped KS2 Tester*** is a standalone program which makes it easy to perform the Kolmogorov-Smirnov (KS) test on two-samples. It also has tools to bootstrap this test (repeating it many times on random sub-samples of the original data). 

### Download 
Compiled (click-to-run) releases are in [/downloads/](/downloads/) 

### Usage
Copy data to the windows clipboard. Data must be a single list of numbers separated by line breaks (as in CSV or TSV files). Click the "paste A" and "paste B" buttons at the top of the program. Sample data is available in the [/data/](/data/) folder.

### Screenshot 
![](/src/BootstrappedKS2/screenshot.png)

# KS2 Test Theory
### What the KS2 test is for
The KS2 test is used to determine if two datasets were sampled from the same population (or from two populations of equivocal distribution). It is a nonparametric test (appropriate for datasets which are not normally distributed).

### What the KS2 test measures
Consider overlapping histograms of the two datasets. The KS test simply (and only) measures the single location where the histogram counts most diverge. The divergence at this point (represented as cumulative probability) is the **K Statistic (D)**. Because it is fractional probability it will always be 0-1 with no units, where values closer to zero indicate the two datasets are similar in distribution. The **Probability (P)** is the likelihood that the K statistic was produced from datasets of similar distributions (with P < .05 representing 95% confidence the that source datasets were sampled from different distributions). _Note that P is an exponential representation of D (meaning that P falls rapidly as D drops a little bit)._

### Calculating P from D
* `P` is the significance level
* `n` is the size of data set A
* `m` is the size of data set B
* `D = sqrt( -ln(P) / 2 ) * sqrt( (n + m) / (n * m) )` _(from Wikipedia)_
* `P = exp( -2 * n * m * k * k / (n + m) )` _(solved for P)_

### Bootstrapping the KS2 test for large datasets
On extremely large datasets the P value rapidly drops to zero (because its calculation takes into account the number of data points). To get more meaningful D and P values (with confidence intervals) from large datasets the KS test is run many times on subsamples of data randomly selected from the original datasets.

### Calculate ideal sample size for bootstrapping
You can calculate the ideal size for bootstrapping using the following formula. 
* Don't actually target p = .05 (or you'll get that result +/- a distribution)
* If the ideal sample size a large portion of the original dataset then the utility of sub-sampling the original dataset for bootstrapping decreases

```cs
public int idealSampleSizeForBootstrapping(
        double significance = .05, 
        double power = 0.99, 
        double? manualMeanDiff = null
    )
{
    var dist = new Meta.Numerics.Statistics.Distributions.NormalDistribution();
    double z = dist.InverseLeftProbability(significance/2) - dist.InverseLeftProbability(power);
    double zSquared = Math.Pow(z, 2);
    double meanDiff = Math.Abs(valueSetA.mean - valueSetB.mean);
    if (manualMeanDiff != null)
        meanDiff = (double)manualMeanDiff;
    double meanDiffSquared = Math.Pow(meanDiff, 2);
    double totalStdevSquared = Math.Pow(valueSetAll.stdev, 2);
    double idealSampleSize = 2 * totalStdevSquared * zSquared / meanDiffSquared;
    return (int)idealSampleSize;
}
```

### Discrete KS2 Test in Python
An easy-to-read discrete KS2 test was written in Python. This allows comparison between KS2 test results calculated discretely against those calculated by SciPy's KS2 test. Examples aren't always Pythonic, but they're easy to translate to C. Source code is in [/src/python/](/src/python/)

Create a CPH | K Statistic
--- | ---
![](/src/python/step1-cph.png)|![](/src/python/step2-diff.png)

### Discrete KS2 Test in C#
The discrete KS2 test in Python was translated to C#. Core (bootstrap-independent) KS2 test routines are in [KS2.cs](/src/BootstrappedKS2/KS2.cs) and [KSTools.cs](/src/BootstrappedKS2/KSTools.cs).

### Additional Resources
* [two sample KS test](https://en.wikipedia.org/wiki/Kolmogorov%E2%80%93Smirnov_test#Two-sample_Kolmogorov%E2%80%93Smirnov_test) (wikipedia)
* [scipy.stats.ks_2samp](https://docs.scipy.org/doc/scipy-0.15.1/reference/generated/scipy.stats.ks_2samp.html)
* [target power](https://stackoverflow.com/questions/15204070/is-there-a-python-scipy-function-to-determine-parameters-needed-to-obtain-a-ta) (stack overflow)
* [two sample KS test procedure](https://influentialpoints.com/Training/kolmogorov-smirnov_test-principles-properties-assumptions.htm#twos)
* [online KS2 tester](http://scistatcalc.blogspot.com/2013/11/kolmogorov-smirnov-test-calculator.html)
* [KS2 in Excel](http://www.real-statistics.com/non-parametric-tests/goodness-of-fit-tests/two-sample-kolmogorov-smirnov-test/)
* [KS2 theory](https://ocw.mit.edu/courses/mathematics/18-443-statistics-for-applications-fall-2006/lecture-notes/lecture14.pdf)
* [Evaluating the K Distribution](http://www.jstatsoft.org/v08/i18/paper?ev=pub_ext_btn_xdl)
* [nag_2_sample_ks_test (g08cdc)](https://www.nag.co.uk/numeric/cl/nagdoc_latest/html/g08/g08cdc.html) (part of [NAG](https://en.wikipedia.org/wiki/NAG_Numerical_Library))
* [scipy.stats.kstwobign](https://docs.scipy.org/doc/scipy-0.14.0/reference/generated/scipy.stats.kstwobign.html#scipy.stats.kstwobign) (Kolmogorov-Smirnov two-sided test for large N)
* [scipy/special/cephes/kolmogorov.c](https://github.com/scipy/scipy/blob/master/scipy/special/cephes/kolmogorov.c) (SciPy's actual implementation in C)
* [Computing the Two-sided KS Statistic](https://arxiv.org/pdf/1803.00426.pdf) (LOL at section 3.5!)

# Sample Data
Sample data is in the [/data/](/data/) folder
* a full dataset is intended to analyzed using bootstrapping
  * [valuesA.csv](/data/valuesA.csv) 
  * [valuesB.csv](/data/valuesB.csv)
* The partial dataset is intended to use for single KS2 testing
  * [subsetA.csv](/data/subsetA.csv) 
  * [subsetB.csv](/data/subsetB.csv)

### Sample Data Descriptive Statistics
metric | full | subset
---|---|---
A count | 28099 | 123
B count | 23655 | 105
A mean | 176.30107 | 173.65325
B mean | 157.06084 | 169.15000

### Sample Data KS Test Results
Because P is calculated from exp(D), small changes in D produces large changes in P. Differences in algorithm (and even floating-point precision) can result in different platforms yielding different P values from the same original datasets.

metric | Origin | SciPy | Discrete Python/C#
---|---|---|---
D full | 0.039589107477428 | 0.0395891074774 | 0.0395891074774
D subset | 0.13728222996516 | 0.137282229965 | 0.137282229965
P full | 6.222757632907E-18 | 6.02410366928e-18 | 6.56505380145e-18
P subset | 0.19528856296462 | 0.218640723776 | 0.236465546027

