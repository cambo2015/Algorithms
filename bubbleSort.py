def bubbleSort(l):#->void
    sorted = False
    while not sorted:
        sorted = True
        for i in range(len(l)-1):
            if l[i] > l[i+1] :
                temp = l[i]
                l[i] = l[i+1]
                l[i+1] = temp
                sorted = False
    return l

def showAll(l):
    for i in range(len(l)):
        print(l[i])


def main():
    l = [1,5,7,4,7,4]
    l = bubbleSort(l)
    showAll(l)
    
main()
