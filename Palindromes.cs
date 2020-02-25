using System;
// using System.Collections.Generic;

// public class Palindromes
// {
//   // public string PalindromeChecker()
//   // {
    

//   // }
// }

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word you think is a palindrome!");
    string userInput = Console.ReadLine();

    char[] arr;
    
    arr = userInput.ToCharArray(0, userInput.Length);

    Array.Reverse(arr);

    string reverseInput = new String(arr);
    Console.WriteLine(reverseInput);
  

    if(userInput == reverseInput)
    {
      Console.WriteLine("Palindrome");
    }
    else
    {
      Console.WriteLine("It's not a palindrome.");
    }
  
    // foreach (char letter in arr)
    // {
    //   Console.WriteLine(letter);
    // }
    
    

  }

   
  
}