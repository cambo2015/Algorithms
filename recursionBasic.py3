import math


#FIRST AND EXAMPLE
def countDown(n):
    if n<=0:# or math.floor(n %2) !=0 :
        return
    else:
       print(n)
       return countDown(n-1)

#recursion. requires:
#0.5 an answer parameter
#1. Base case that returns an answer
#2. A return with recursion
#3. do stuff before the recursion call
#4. do all finalizing calculations within the base case
#5. in other words, the answer is in the beginning instead of the end!
def sigma(i,end,answer):
    if(i>=end):
        return answer#final logic here
    #main logic here
    i+=1
    answer += i
    return sigma(i,end,answer)
    
def sigma2(start,end):
    answer =0
    for i in range(start,end+1):
        answer += i
    return answer

def sigma3(start,end):
    
    ans =0
    i=0
    while(i<end+1):
        ans += i
        i+=1
    return ans

def pagTheorm(lst,i,ans):
    if(i==len(lst)):
        return math.sqrt(ans)
    
    ans += lst[i]**2
    i+=1
    return pagTheorm(lst,i,ans)
    
#countDown(16)

print(sigma(0,10,0))
print(sigma2(0,10))
print(sigma3(0,10))

print(pagTheorm([3,4],0,0))