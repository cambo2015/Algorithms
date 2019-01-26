using System;
using System.Collections.Generic;
using static Algorithms;		
public class Program
{
	public static void Main()
	{
		var list = new List<int>{5,3,6,8,3,6};
		list.BubbleSort();
		list.ShowAll();		
	}
}

public static class Algorithms
{
	
	public static void Swap<T>(this List<T> l,int indexA,int indexB)//EXTENSION METHOD for swapping. 
	{
		var temp = l[indexA];
		l[indexA] = l[indexB];
		l[indexB] = temp;
	}
	
	public static void ShowAll<T>(this List<T> list)//Showing The Entire List
	{
		foreach(var item in list)
		{
			Console.WriteLine(item);
		}
	}
	
  //BubbleSort Algorithm
	public static void BubbleSort(this List<int> l)
	{
		bool sorted = false;
		while(!sorted)
		{
			sorted = true;
			for(int i = 0;i<l.Count-1;i++)
			{
				if(l[i] > l[i+1])
				{
					l.Swap(i,i+1);
					sorted= false;
				}
			}
		}
	}
}
