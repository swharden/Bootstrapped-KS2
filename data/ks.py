"""
This script demonstrates how to execute the KS2 test step by step.
Examples aren't always Pythonic, but they're easy to translate to C.
"""

import numpy as np
import matplotlib.pyplot as plt

import dataReader
import scipy.stats


class ksTest:

    def __init__(self, valuesA, valuesB, binSize=0.1, displayInfo = False, createPlots = False):

        self.analyzeValues(valuesA, valuesB)
        self.calculateBins(binSize)
        self.createHistograms()
        self.calculateKstatistic()

        if displayInfo:
            self.displayValueStats()
            self.displayBinInfo()
            self.displayKstatistic()

        if createPlots:
            self.createCphPlot()
            self.createKstatPlot()

    def analyzeValues(self, valuesA, valuesB):

        self.valuesA = valuesA
        self.valuesAcount = len(valuesA)
        self.valuesAmean = np.mean(valuesA)
        self.valuesAstdErr = np.std(valuesA)/np.sqrt(len(valuesA))

        self.valuesB = valuesB
        self.valuesBcount = len(valuesB)
        self.valuesBmean = np.mean(valuesB)
        self.valuesBstdErr = np.std(valuesB)/np.sqrt(len(valuesB))

        valuesAandB = np.concatenate((valuesA, valuesB))
        self.valuesAandB = valuesAandB
        self.valuesAandBcount = len(valuesAandB)
        self.valuesAandBmean = np.mean(valuesAandB)
        self.valuesAandBstdErr = np.std(valuesAandB)/np.sqrt(len(valuesAandB))

    def displayValueStats(self):
        print("Values A: n=%d, average=%.03f, stdErr=%.03f" %
              (self.valuesAcount, self.valuesAmean, self.valuesAstdErr))
        print("Values B: n=%d, average=%.03f, stdErr=%.03f" %
              (self.valuesBcount, self.valuesBmean, self.valuesBstdErr))
        print("All Values: n=%d, average=%.03f, stdErr=%.03f" %
              (self.valuesAandBcount, self.valuesAandBmean, self.valuesAandBstdErr))

    def calculateBins(self, binSize, binMin=0):
        binMax = np.max(self.valuesAandB)
        binSpan = binMax - binMin
        binCount = int(binSpan / binSize) + 1
        self.bins = np.arange(binCount) * binSize

    def displayBinInfo(self):
        print("Using %d bins (beteen %f and %f) of size %f" % (len(self.bins),
                                                               self.bins[0], self.bins[-1], self.bins[1]-self.bins[0]))

    def createHistograms(self):
        binCount = len(self.bins)
        binSize = self.bins[1] - self.bins[0]
        binMin = self.bins[0]

        self.countsA = np.zeros(binCount)
        for i, value in enumerate(self.valuesA):
            bin = int((value - binMin) / binSize)
            self.countsA[bin] += 1
        self.cumFreqsA = np.cumsum(self.countsA) / len(self.valuesA) * 100

        self.countsB = np.zeros(binCount)
        for i, value in enumerate(self.valuesB):
            bin = int((value - binMin) / binSize)
            self.countsB[bin] += 1
        self.cumFreqsB = np.cumsum(self.countsB) / len(self.valuesB) * 100

    def calculateKstatistic(self):
        self.kStatisticCurve = np.abs(self.cumFreqsB - self.cumFreqsA)
        self.kStatisticMaxIndex = np.argmax(self.kStatisticCurve)
        self.ksValue = self.bins[self.kStatisticMaxIndex]
        self.ksStat = self.kStatisticCurve[self.kStatisticMaxIndex] / 100.0

        k = self.ksStat
        n = len(self.valuesA)
        m = len(self.valuesB)
        self.ksPvalue = np.exp((-2*n*m*k*k)/(n+m)) # seems to be 2 off

    def displayKstatistic(self):
        print("K Statistic:", self.ksStat)
        print("P value:", self.ksPvalue)

    def createCphPlot(self):
        plt.figure(figsize=(5, 5))
        plt.grid(alpha=.2, ls='--')
        plt.ylabel("Cumulative Probability (%)")
        plt.xlabel("Value")
        plt.plot(self.bins, self.cumFreqsA, label="A")
        plt.plot(self.bins, self.cumFreqsB, label="B")
        maxVal = np.percentile(self.valuesAandB, 99)
        plt.axis([0, maxVal, None, None])
        plt.tight_layout()
        plt.legend()
        plt.show()

    def createKstatPlot(self):
        plt.figure(figsize=(5, 5))
        plt.grid(alpha=.2, ls='--')
        plt.ylabel("K-statistic (%)")
        plt.xlabel("Value")
        plt.plot(self.bins, self.kStatisticCurve, label = 'CPH difference', color='C3')
        plt.axvline(self.ksValue, label = "K value: %.03f" % self.ksValue, color='C2')
        plt.axhline(self.ksStat*100, label = "K statistic: %.05f" % self.ksStat, color='C4')
        plt.axhline(0, color='k')
        plt.legend()
        maxVal = np.percentile(self.valuesAandB, 99)
        plt.axis([0, maxVal, None, None])
        plt.tight_layout()
        plt.show()


if __name__ == "__main__":

    print("\nSciPy says:")
    print(scipy.stats.ks_2samp(dataReader.valuesA, dataReader.valuesB))

    bootStrapCount = 20_000
    bootStrapSampleCount = 1829
    print(f"\nNow bootstrapping {bootStrapCount} times with {bootStrapSampleCount}-point samples...")
    kValues = np.empty(bootStrapCount)
    pValues = np.empty(bootStrapCount)
    for i in range(bootStrapCount):
        if (i%1000==0):
            print(f"on iteration {i} ...")
        valuesA = np.random.choice(dataReader.valuesA, bootStrapSampleCount, False)
        valuesB = np.random.choice(dataReader.valuesB, bootStrapSampleCount, False)
        ks = ksTest(valuesA, valuesB)
        kValues[i] = ks.ksStat
        pValues[i] = ks.ksPvalue
    
    print("K values: %f (+/- %f)" % (np.mean(kValues), np.std(kValues)/np.sqrt(bootStrapCount)))
    print("P values: %f (+/- %f)" % (np.mean(pValues), np.std(pValues)/np.sqrt(bootStrapCount)))

    # current output:
    # K values: 0.051491 (+/- 0.000093)
    # P values: 0.037624 (+/- 0.000514)
