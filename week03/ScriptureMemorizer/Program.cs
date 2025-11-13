using System;
using System.Collections.Generic; 
//I decided to create a conditional structure and add a congratulatory message when all the letters are hidden.
//I also added an encouraging message that will appear after the user types the word "exit" and hasn't fully memorized the scripture.

public class Program
{
    public static void Main(string[] args)
    {
       
        Reference myReference = new Reference("1 nephi", 3, 7);
        
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the" +
        "Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare" +
        "a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture = new Scripture(myReference, scriptureText);
        string userInput = "";
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\n Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3); 
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText()); 
        
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\n ¡Very good, I'm glad you learned the Scripture!. ");
        }
        else
        {
            Console.WriteLine("\n Come back soon, don't give up, little by little you will be able to memorize the scriptures.");
        }
        
        Console.ReadKey();
    }
}