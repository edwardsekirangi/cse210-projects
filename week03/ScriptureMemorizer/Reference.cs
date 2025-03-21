using System;
public class Reference
{
    //We have first got the book, verse and chapters from the user using these attributes.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //This interacts with our private data
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //We now need a function to Convert the reference into a string to be displayed on the console.
    public string StringConverter()
    {

        string formatScript = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return formatScript;

    }


}