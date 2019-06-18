# KS2 Test Theory
This page contains notes about the Two-sample Kolmogorov–Smirnov (KS2) test.

* The KS2 test determines if two sets of random samples is from the same dataset (or if the two samples are from equivalent distributions).
* The KS2 test is sensitive to differences in both location and shape of the cumulative distribution curves.
* Running the KS2 test a single time on the entire dataset produces a single value without a confidence interval. 
* Bootstrapping the KS2 test (running it thousands of times if random subsets of data) can provide a confidence interval.

## The K Statistic
***The KS2 test is really just a measurement based on the single point where the two distributions are most different. If it's larger than expected, the null hypothesis is assumed.***
* The **K statistic** is the the absolute value of the distance between the two curves at the point where they are greatest apart. 
* This is indicated by the arrow in the picture below.
* The null hypothesis is rejected if the K statistic is greater than **D** where:
  * `D = sqrt(-ln(alpha)/2) * sqrt((n+m)/(n*m))`
  * where `alpha` is the target significance level
  * where `n` and `m` are the size of the 2 samples
  * e.g., D at the 0.05 level is 1.36 √[(n1 + n2)/(n1 n2)]

![](https://upload.wikimedia.org/wikipedia/commons/3/3f/KS2_Example.png)

## Creating CPH Plots Discretely
* Sample datasets were added to [/data/](/data/).
* A CSV file reader module was [implimented in Python](/data/dataReader.py).
* Analysis of this dataset was previously performed with OriginLab:

Python Analysis | OriginLab Analysis
---|---
![](/data/OriginLab-Summary.PNG) | ![](/data/Python-Summary.PNG)

## Links
* [two sample KS test](https://en.wikipedia.org/wiki/Kolmogorov%E2%80%93Smirnov_test#Two-sample_Kolmogorov%E2%80%93Smirnov_test) (wikipedia)
* [scipy.stats.ks_2samp](https://docs.scipy.org/doc/scipy-0.15.1/reference/generated/scipy.stats.ks_2samp.html)
* [target power](https://stackoverflow.com/questions/15204070/is-there-a-python-scipy-function-to-determine-parameters-needed-to-obtain-a-ta) (stack overflow)
* [two sample KS test procedure](https://influentialpoints.com/Training/kolmogorov-smirnov_test-principles-properties-assumptions.htm#twos)
