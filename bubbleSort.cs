/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
#include <vector>
#include <string>
using namespace std;

void swap(int& a,int& b)
{
    auto temp = a;
    a = b;
    b = temp;
}

void ShowAll(vector<int>& l)
{
    cout<<" "<<endl;
    for(auto n : l)
    {
        cout<<n<<endl;
    }
}

template<typename T>
void p(T s)
{
    cout<<s<<endl;
}

//O(n2) // not very efficient!
void BubbleSort(vector<int>& v)// references are similar to pointers! 
{
    bool sorted = false;
    while(!sorted)//without this the vector will only iterate through the vector only once! To iterate multiple times you need two loops!
    {
        sorted = true; //assume the array is already sorted
        for (int i = 0; i < v.size()-1; i++) 
        {
            if(v.at(i) > v.at(i+1))//if the lower positon number is lower then the higher position n, swap em!
            {
                swap(v.at(i),v.at(i+1));
                sorted = false;
            }
        }
    }
}
int main()
{
    cout<<"Hello World";
    vector<int>* list = new vector<int>{5,3,6,3,7,2,9,8};
    ::BubbleSort(*list);
    ::ShowAll(*list);
    return 0;
}
