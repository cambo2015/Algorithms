#include <iostream>
#include <string>
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


//Works like a deck of cards.
//If one right card  is lower than the other
// (next to it on the left), swap em.
//continue checking it with the card on it's left
//until no cards on its left are higher.
//When you sort cards you check to see if
//it's smaller than the card on the right
//if it is , you take a card out and insert
//it right before the other! Neat!
void insertionSort(vector<int>& v)
{
	for(int i=1;i<v.size();i++)
	{
		int head = i;//j variable name would also be appropriate but less readable
		while(head>0)
		{
			if(v.at(head) < v.at(head-1))//if previous is larger then swap
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
