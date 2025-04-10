using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {

        // Create list of videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Exploring the Sahara", "NomadLife", 420);
        Comment comment1a = new Comment("Alice", "Wow, this was amazing!");
        Comment comment1b = new Comment("Bob", "I want to visit someday.");
        Comment comment1c = new Comment("Clara", "Great camera work!");
        video1.AddComment(comment1a);
        video1.AddComment(comment1b);
        video1.AddComment(comment1c);
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("DIY Solar Oven", "EcoTech", 300);
        Comment comment2a = new Comment("Daniel", "Very helpful, thanks!");
        Comment comment2b = new Comment("Eva", "Trying this tomorrow.");
        Comment comment2c = new Comment("Frank", "Can you show the temperature readings?");
        video2.AddComment(comment2a);
        video2.AddComment(comment2b);
        video2.AddComment(comment2c);
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Ancient Timbuktu", "HistoryNerd", 600);
        Comment comment3a = new Comment("Grace", "So informative!");
        Comment comment3b = new Comment("Henry", "Loved the visuals.");
        Comment comment3c = new Comment("Ivy", "Perfect for my history project.");
        video3.AddComment(comment3a);
        video3.AddComment(comment3b);
        video3.AddComment(comment3c);
        videos.Add(video3);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}