"""
This script demonstrates how to discretely bin data and use it to create
a cumulative probability histogram. This script plots the CPH of each
dataset without comparing them.
"""
import dataReader

import numpy as np
import matplotlib.pyplot as plt


def plotCph(values, label="", binSize=10, binMax=20_000, binMin=0):
    """
    This function bins and plots data as a CPH. 
    No analysis is performed.
    """

    # create a histogram by binning all the data
    binSpan = binMax - binMin
    binCount = int(binSpan / binSize) + 1
    print(
        f"Creating {binCount} bins ({binSize} steps beteen {binMin} and {binMax})")

    # create the histogram
    binCounts = np.zeros(binCount)
    binValues = np.arange(binCount) * binSize
    for i, value in enumerate(values):
        bin = int((value - binMin) / binSize)
        binCounts[bin] += 1

    # create the cumulative probability histogram
    cumSum = np.cumsum(binCounts)
    cumSumFrac = cumSum/len(values)
    cumFreq = cumSumFrac * 100

    # plot the CPH
    plt.plot(binValues, cumFreq, label=label)


if __name__ == "__main__":
    """
    Create a CPH plot of the two datasets.
    """

    plt.figure(figsize=(5, 5))
    plt.grid(alpha=0.2)
    plotCph(dataReader.valuesA, "valuesA")
    plotCph(dataReader.valuesB, "valuesB")
    plt.axis([-50, 1800, 0, 110])
    plt.title("CPH")
    plt.ylabel("Probability (%)")
    plt.xlabel("Inter-Event Interval (ms)")
    plt.legend()
    plt.tight_layout()
    plt.savefig(dataReader.PATH_HERE+"/Python-Summary.PNG")
    print("\nDONE")
