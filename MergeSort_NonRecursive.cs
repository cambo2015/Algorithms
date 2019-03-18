using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        
        foreach(var item in Algorithms.InEfficientMergeSort(new int[] { 1, 3, 7, 0, 9 }))
        {
            Console.WriteLine(item);
        }
      

    }
}

public static class Algorithms
{
    public static int[] InEfficientMergeSort(int[] arr)
    {
        //base case: if the len of arr is <2, we know it is already sorted
        //and will return orginal arr
        if(arr.Length<2)
        {
            return arr;
        }
        //otherwise break arr into two parts
        //sort both those parts
        int[] arr2, arr3;
        arr2 = new int[arr.Length/2];
        arr3 = new int[arr.Length / 2 + arr.Length % 2];

        //splitting array into 2 parts
        for (int i = 0; i < arr.Length/2; i++)//arr2 gets firts hale
        {
            arr2[i] =arr[i];
        }
        for (int i = arr.Length/2; i < arr.Length; i++)//arr3 gets second half
        {
            arr3[i-arr.Length/2] = arr[i];
        }
        var sortedArr2 = InEfficientMergeSort(arr2);
        var sortedArr3 = InEfficientMergeSort(arr3);
        //MergeTwoSortedArrays into 1 final sorted arr
        return Merge2OrderArrays(sortedArr2, sortedArr3);
    }

    ///<summary>
    ///Merges two unsorted arrays and sorts them
    ///</summary>
    public static int[] Merge2OrderArrays(int[] arr1, int[] arr2)
    {
        int len = arr1.Length + arr2.Length;
        int[] arr3 = new int[len];
        int arr1Pos = 0;
        int arr2Pos = 0;
        for (int arr3Pos = 0; arr3Pos < len; arr3Pos++)
        {
            if (arr1Pos == arr1.Length)//arr1 is empty or we have used them all
            {
                int a = arr2[arr2Pos];
                arr3[arr3Pos] = a;
                arr2Pos++;
            }
            else if (arr2Pos == arr2.Length)//arr2 is empty or we have used them all
            {
                arr3[arr3Pos] = arr1[arr1Pos];
                arr1Pos++;
            }
            else
            {//both arrays still have something in them
                if (arr1[arr1Pos] < arr2[arr2Pos])
                {
                    arr3[arr3Pos] = arr1[arr1Pos];
                    arr1Pos++;
                }
                else
                {
                    arr3[arr3Pos] = arr2[arr2Pos];
                    arr2Pos++;
                }
            }
        }
        return arr3;

    }

}
