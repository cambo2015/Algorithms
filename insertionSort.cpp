#include <iostream>
#include <string>
#include <cstring>
#include <cstdint>
#include <vector>
using namespace std;

template<typename T>
void print(T n)
{
	cout<<n<<endl;
}

void printAll(vector<int>& v)
{
	for(int item:v)
	{
		print(item);
	}
}
void swap(int& a,int& b)
{
	auto temp = a;
	a= b;
	b= temp;
}

void insertionSort(vector<int>& v)
{
	for(int i=1;i<v.size();i++)
	{
		int head = i;//j variable name would also be appropriate
		while(head>0)
		{
			if(v.at(head) < v.at(head-1))
			{
				swap(v.at(head),v.at(head-1));
			}
			head--;
		}
	}
}


int main(){
	
	vector<int>* v = new vector<int>{
		2,5,3,6,4,8,3,1
	};
	::insertionSort(*v);
	::printAll(*v);
	return 0;
	
}