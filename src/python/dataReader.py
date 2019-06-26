import os
import sys
import numpy as np

PATH_HERE = os.path.abspath(os.path.dirname(__file__))
PATH_DATA = os.path.abspath(PATH_HERE+"/../../data/")


def loadValuesFromFile(filePath):
    vals = np.loadtxt(filePath)
    mean = np.mean(vals)
    stderr = np.std(vals)/np.sqrt(len(vals))
    print("Loaded values from '%s': n=%d (Ave: %.03f StdErr: %.03f)" %
          (os.path.basename(filePath), len(vals), mean, stderr))
    return vals


valuesA = loadValuesFromFile(PATH_DATA + "/valuesA.csv")
valuesB = loadValuesFromFile(PATH_DATA + "/valuesB.csv")
subsetA = loadValuesFromFile(PATH_DATA + "/subsetA.csv")
subsetB = loadValuesFromFile(PATH_DATA + "/subsetB.csv")

if __name__ == "__main__":
    print("DO NOT RUN THIS MODULE DIRECTLY")
