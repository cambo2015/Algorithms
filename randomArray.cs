using System;
using System.Collections.Generic;
using static Dcoder.Algorithms;
using static System.Console;
namespace Dcoder
{
	
	public static class Program
	{
		public static void Main(string[] args)
		{
			List<int> l = CreateArray(10);
			foreach(var n in l)
				Write(n);
		}
	}
	
	public static class Algorithms
	{
		public static List<int> RandomArray(int max = 10)
		{
			Random r = new Random();
			var l = new List<int>();
			for(int i =0;i<max;i++)
			{
				while(true)
				{
					var n = r.Next(0,10);
					if(l.Contains(n))
					{
						continue;
					}
					l.Add(n);
					break;
				}
			}
			return l;
		}
	}
}