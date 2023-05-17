using System;

class Program 

    static void Main() 

    { 

        string word1 = "кукурудза"; 

        string word2 = "банан"; 

 

        string uniqueLetters = GetUniqueLetters(word1, word2); 

        Console.WriteLine("Лише одноразові літери: " + uniqueLetters); 

    } 

 

    static string GetUniqueLetters(string word1, string word2) 

    { 

        string uniqueLetters = ""; 

 

         

        char[] word1Chars = word1.ToCharArray(); 

        char[] word2Chars = word2.ToCharArray(); 

 

       

        foreach (char c in word1Chars) 

        { 

            if (word2.Contains(c.ToString()) && !uniqueLetters.Contains(c.ToString())) 

            { 

                uniqueLetters += c; 

            } 

        } 

 

         

        foreach (char c in word2Chars) 

        { 

            if (word1.Contains(c.ToString()) && !uniqueLetters.Contains(c.ToString())) 

            { 

                uniqueLetters += c; 

            } 

        } 

 

        return uniqueLetters; 

    } 

} 
