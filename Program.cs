// See https://aka.ms/new-console-template for more information

int[] array = {2, 3, 4, 10, 40};
int[] selectionSortArray = {5,3,6,2,10};
var search = new Search();
var sort = new Sort();
//var result = search.BinarySearch(array, 30);
var sortedArray = sort.SelectionSort(selectionSortArray);
foreach(var item in sortedArray){
    Console.Write($"{item}, ");
}
//Console.WriteLine($"Hello, World! {result}");
