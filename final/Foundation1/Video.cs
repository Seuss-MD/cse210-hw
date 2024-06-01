using System;

public class Video 
{
   public string _title;
   public string _author;
   public float _lenght;

   public List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public Video(string title, string author, float lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public string GetVideoDetails()
    {
        return($"Title : {_title} - Author: {_author} - Lenght: {_lenght} minutes - Number of commentaries: {_comments.Count}.");
    }

    public void GetComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.GetComment();
        }
    }
}