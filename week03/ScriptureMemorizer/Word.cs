using System;
public class Words
{
    //This class represents a word in the scripture
    //It tracks if the word is hidden or visible
    //Displays as underscore when the word is hidden
    private string _text;

    private string Displaying;
    private bool _isHidden;

    //We now create a constructor that gets the text of the scripture
    public Words(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide()
    {
        //Tracks if the word is hidden
        _isHidden = true;
    }

    //Puclicly expose the _isHidden property for checking visibility
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //This function should get us the word
        return _isHidden ? new string('_', _text.Length) : _text;

    }

    public void SetDisplayText(string newText)
    {
        _text = newText;
    }

}