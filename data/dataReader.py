import os
import sys
import numpy as np

PATH_HERE = os.path.abspath(os.path.dirname(__file__))

def loadValuesFromFile(filePath):
    vals = np.loadtxt(filePath)
    mean = np.mean(vals)
    stderr = np.std(vals)/np.sqrt(len(vals))
    print("Loaded values from '%s': n=%d (Ave: %.03f StdErr: %.03f)" % \
        (os.path.basename(filePath), len(vals), mean, stderr))
    return vals

valuesA = loadValuesFromFile(PATH_HERE + "/valuesA.csv")
valuesB = loadValuesFromFile(PATH_HERE + "/valuesB.csv")

if __name__=="__main__":
    print("DO NOT RUN THIS MODULE DIRECTLY")