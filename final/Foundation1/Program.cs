using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videoList = new List<Video>();
        
       Video v1 = new Video();
       v1._title = "Hamlet play";
       v1._author = "Shakespeare";
       v1._lenght = 30;

       Comment comment1v1 = new Comment();
       comment1v1._name = "Susan Boyle";
       comment1v1._text = "This play is awesome!";

       Comment comment2v1 = new Comment("Paul Mcarthur", "I love the way how this play is perfomed!");
       Comment comment3v1 = new Comment("Anne Flower", "I think the audio could be better.");

        v1._comments.Add(comment1v1);
        v1._comments.Add(comment2v1);
        v1._comments.Add(comment3v1);

        Video v2 = new Video("Cosmos", "Carl Sagan", 12);
        Comment comment1v2 = new Comment("John Locke", "This is my favorite TV show!");
        Comment comment2v2 = new Comment("Albert Einstein", "Carl is the best host ever!");
        Comment comment3v2 = new Comment("Marie Curie", "I think really interesting this theme.");

        v2._comments.Add(comment1v2);
        v2._comments.Add(comment2v2);
        v2._comments.Add(comment3v2);

        Video v3 = new Video("Animal planet", "Discovery Channel", 7);
        Comment comment1v3 = new Comment("Vin Diesel", "I didn't know that the wilderness was so dangerous.");
        Comment comment2v3 = new Comment("Elvis Presley", "It's impressive as animals survive there.");
        Comment comment3v3 = new Comment("Barack Obama", "Sustainable is a very important topic in this video.");

        v3._comments.Add(comment1v3);
        v3._comments.Add(comment2v3);
        v3._comments.Add(comment3v3);

        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetVideoDetails());
            video.GetComments();
        }
    }
}
