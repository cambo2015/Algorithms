using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Dcoder.Algos;
namespace Dcoder
{
    class Program
    {
        static void Main(string[] args)
        {
        	
        	
        	var n = new int[]{
        		9,2,5,1,6,8
        	};
        	
        	MergeSort(n);
        	n.ToList().ForEach(x=>Write(x));
        }
        		
        	
        
        	
    }
    
    public static class Algos
    {
    	
    	//O(nlogn))
    	public static void MergeSort(int[] arr)
    	{
    		MergeSort(arr,new int[arr.Length],0,arr.Length -1 );
    	}
    	
    	public static void MergeSort(int[] arr,int[] helper,int low,int high)
    	{
    		if(low<high)
    		{
    			int middle = (high+low)/2;
    			MergeSort(arr,helper,low,middle);//keeps dividing the left half of the array until the if statement is false
    			MergeSort(arr,helper,middle+1,high);//same but for right half
    			Merge(arr,helper,low,middle,high);
    		}
    	}
    	
    	public static void Merge(int[] arr, int[] helper, int low,int middle, int high)
    	{
    		/*for(int x = low;x<=high;x++)
    		{
    			helper[x] = arr[x];//copy the array over could create method for copy array
    		}*/
    			
    			
    		CopyArray(arr,helper);//this is better than above
    		
    		int left = low;
    		int curr = low;
    		int right = middle +1;
    		while(left <= middle && right <= high)// keep running until we reach the end of both halves
    		{
    			if( helper[left] < helper[right])//check the beginning of both halves
    			{
    				arr[curr++] = helper[left++];//if the left smaller than just do a "swap". Your kind of swapping but your really just reassigning
    			}
    			else{ //if right side is bigger assign that to the current spot
    				arr[curr++] = helper[right++];
    			}
    		}
    		
    		while(left <= middle)
    		{
    			arr[curr++] = helper[left++];
    		}
    	}
    	
    	public static void CopyArray(int[] arr,int[] to)
    	{
    		for(int i = 0;i<arr.Length;i++)
    		{
    			to[i] = arr[i];
    		}
    	}
    }
}
    
    
    
         
                
    
