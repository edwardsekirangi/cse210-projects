using System;
public class Scripture
{
    //Store the reference and words 
    //Randomly hide the words while ensuring only visible words are affected
    //Displays the scripture with updates after each input
    public Reference _reference;
    private List<Words> _words = new List<Words>();
    private Random _random = new Random();

    public Scripture(Reference references, string _text)
    {
        //First thing we wanna do is get the reference value from the reference class, because it will be used in this class
        _reference = references;

        //For this one we want to add the text into the list
        //Looked this one up on the internet, for how to add words into a list that takes objects 
        string[] individualWords = _text.Split(' ');

        //We now want to split the sentence in the list and make them individual words
        foreach (string word in individualWords)
        {
            _words.Add(new Words(word));


        }

        //Replace the original list with the new list of split words
        // //debugging
        // foreach (Words splitWord in _words)
        // {
        //     Console.WriteLine(splitWord.GetDisplayText());
        // }

    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.StringConverter()); //Display the reference 
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
    }
    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return false;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Prevents rehiding the same word
        }

        return _words.Any(w => !w.IsHidden()); // Returns fals
    }
    // public string GetDisplayText()
    // {

    // }
}