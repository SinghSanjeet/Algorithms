using System.IO;


public class Search{

    ///Binary search is a searching algorithms that takes log(n) time to search
    /// an element in a sorted array.
    /// returns the index of the searched element.
    public int? BinarySearch(int[] array, int element){
        int high = array.Length - 1;
        int low = 0;

        while(low<=high){
            int mid = (high+low)/2;
            int guess = array[mid];

            if(guess == element){
                return mid;
            }else if(guess>element){
                high = mid - 1;
            }else if(guess<element){
                low = mid + 1;
            }
        }
        return null;
    }
}