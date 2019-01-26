using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using static Dcoder.Printer;
using static Dcoder.Algorithms;
 /*Please dont change namespace, Dcoder 
 and class must not be public*/

 //Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
 	public class Program
 	{
 		public static void Main(string[] args)
 		{
 		   List<int> myl = new List<int>
 		   {
    			6,5,6,3,7,2,0
    		};
    		myl.InsertionSort();
    		myl.ShowAll();
 		}
 	}
 	
 	public static class Algorithms
 	{
 		public static void Swap<T>(this List<T> l,int indexA,int indexB)
 		{
 			var temp = l[indexA];
 			l[indexA] =l[indexB];
 			l[indexB] = temp;
 		}
 		public static void InsertionSort(this List<int> l)
 		{
 			for(int i =1;i<l.Count;i++)
 			{
 				int head = i;
 				while(head>0)
 				{
 					if(l[head]<l[head-1])
 						l.Swap(head,head-1);
 					head--;
 				}
 			}
 		}
 	}
 	
 	
 	public static class Printer
 	{
 		public static void p<T>(T n)
 		{
 			Console.WriteLine( n);
 		}
 		
 		public static void ShowAll<T>(this IEnumerable<T> l)
 		{
 			foreach(var i in l)
 				p(i);
 		}   
 	}
 }	
