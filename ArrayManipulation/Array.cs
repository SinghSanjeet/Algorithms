using System;

public class Array
{
    public Array()
    {
        
    }
    /// The function finds an missing element in a given an array of positive numbers from 1 to n. Time complexity O(n).
    /// param int[] array
    /// returns int
    public int FindAMissingNumberInArray(int[] array)
    {
        int missingNumber = 0;
        // Adding 1 to the array leanth to accomodate the missing element length.
        int n = array.Length+1;
        int sumOfTotalElement = (n*(n+1))/2;
        int sumOfArray = 0;
        
        for(int i=0; i<array.Length; i++){
            sumOfArray+=array[i];
        }
        missingNumber = sumOfTotalElement - sumOfArray;
        return missingNumber;
    }

    ///Given an array of integers and a value, the function determine if there are any two integers in the array 
    ///whose sum is equal to the given value. Returns true if the sum exists and return false if it does not. 
    /// Time complexity O(n).
    /// param int[] array, int targetSum
    /// returns true/false
    public bool FindIfSumOfTwoIntergerEqualToGivenValue(int[] array, int targetSum){
        bool exists = default(bool);
        HashSet<int> listToHoldTheDifference = new HashSet<int>();
        
        for(int i=0; i<array.Length; i++){
            if(listToHoldTheDifference.Contains(targetSum - array[i])){
                return true;
            }
            listToHoldTheDifference.Add(array[i]);
        }
        return exists;
    }

    ///Given an array of integers and a value, the function determine if there are any two integers in the array 
    ///whose sum is equal to the given value. Returns true if the sum exists and return false if it does not. 
    /// Time complexity O(n*n). Brute force algorithm
    /// param int[] array, int targetSum
    /// returns int[] with indexes
    public virtual int[]? TwoSumBruteForceSol(int[] array, int targetSum){
       for(int p1=0; p1<array.Length; p1++){
         int numberToLookFor = targetSum - array[p1];
         for(int p2 = p1+1; p2< array.Length; p2++){
            if(array[p2] == numberToLookFor){
                return new int[]{p1, p2};
            }
         }
       }
        return null;
    }

    ///Given an array of integers and a value, the function determine if there are any two integers in the array 
    ///whose sum is equal to the given value. Returns true if the sum exists and return false if it does not. 
    /// Time complexity O(n).
    /// param int[] array, int targetSum
    /// returns int[] with indexes
    public  virtual int[]? TwoSumEfficientSol(int[] array, int targetSum){
       IDictionary<int, int> hashMap = new Dictionary<int,int>();
       
       for(int p1=0; p1<array.Length; p1++){
        int numberToLookFor = targetSum - array[p1];
        if(hashMap.Values.Contains(numberToLookFor)){
            return new int[]{p1, hashMap.Where(x=> x.Value == numberToLookFor).Select(x=>x.Key).FirstOrDefault()};
        }
         hashMap.Add(p1, array[p1]);
       }
        return null;
    }

    /// Given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of 
    /// the ith line are (i, 0) and (i, height[i]), the function two lines that together with the x-axis form a container, 
    /// such that the container contains the most water. Time COmplexity O(n*n) qand soace complexity O(1).
    /// Param int[] array
    /// return max area of duoble type.
    public double GetMaxWaterContainerBruteForceSol(int[] heightArray){
        double area = 0;
        for(int p1=0; p1<heightArray.Length; p1++){
            for(int p2=p1+1; p2<heightArray.Length; p2++){
                int minHeight = Math.Min(heightArray[p1], heightArray[p2]);
                area = Math.Max(area, minHeight*(p2-p1));
            }
        }
        return area;
    }

    /// Given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of 
    /// the ith line are (i, 0) and (i, height[i]), the function two lines that together with the x-axis form a container, 
    /// such that the container contains the most water. Time COmplexity O(n) qand soace complexity O(n).
    /// Param int[] array
    /// return max area of duoble type.
    public double GetMaxWaterContainerTwoPointerSol(int[] heightArray){
        double area = 0;
        int leftPointer = 0;
        int rightPointer = heightArray.Length - 1;
        while(leftPointer<rightPointer){
            int minHeight = Math.Min(heightArray[leftPointer], heightArray[rightPointer]);
            area = Math.Max(area, minHeight*(rightPointer-leftPointer));
            if(heightArray[leftPointer]>=heightArray[rightPointer]){
                rightPointer--;
            }else
            {
                leftPointer++;
            };
        }
        return area;
    }
}