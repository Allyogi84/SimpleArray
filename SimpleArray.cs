/*


using System.Globalization;

//Given an array of numbers,
//write a method
//that only puts even numbers in a list and return that list

//Example 1

public List<int> Evens(int[] numbers)
{

var evenNumbers = new List<int>();
foreach (var num in numbers)

{
    if(num % 2== 0)
    {
        evenNumbers.Add(num);
    }


}
        retun evenNumbers;

}


//Example 2 


using System.Linq;

Public List<int> Evens(int[] numbers)
{
    return Numbers.Where(num => num % 2==0).ToList();
}