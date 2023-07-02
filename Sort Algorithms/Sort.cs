
public class Sort{

    ///BSelectionSort is a sorting algorithms that takes O(n^2) time to sort an array.
    /// returns the sorted array from smaalest to the largest number.
    public List<int> SelectionSort(int[] array){
        var response = new List<int>();
        var list = new List<int>(array);
        while(list.Count>0){
           int s = GetSmallestNumberIndex(list);
           response.Add(list[s]);
           list.RemoveAt(s);
        }
        return response;
    }

    private int GetSmallestNumberIndex(List<int> list){
        var index = 0;
        foreach(var item in list){
            if(item<list[index]){
                index = list.IndexOf(item);
            }
        }
        return index;
    }
}