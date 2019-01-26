#python 2.7.6

#see the c++ file for explination


def insertionSort(l):
    for i in range(1,len(l)):
        head = i
        while head>0:
            if l[head]<l[head-1]:
                l[head],l[head-1] = l[head-1],l[head]#swap in python is very different from c++,c# languages syntax.
            head-=1
    return l




def main():
    arr = [1,5,3,7,0,9,2]
    print(insertionSort(arr))

main()
    
