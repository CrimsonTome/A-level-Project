from statistics import *

while True:
    print('Type here: ')
    data = [int(x) for x in input().split()]
    print(data)

    mean = mean(data)
    print("mean time in ms is: "+str(mean))
