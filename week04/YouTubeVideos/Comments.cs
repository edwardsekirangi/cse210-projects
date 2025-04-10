using System;

//This is our comment class that will handle the comment name and text
class Comment
{
    private string _commenterName;
    private string _commentText;

    //Creating a public constructor to be used to get information
    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;
    }
     public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}