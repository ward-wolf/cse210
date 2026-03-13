// A Program to run the YouTube Video Program

// Steve Ward CSE210 March 12, 2026

using System;

class Program
{
    static void Main(string[] args)
    {
        
        VideoList videos = new VideoList();
        
        Video video1 = new Video("Lamb of God", "Gordon Hinckley", 600);
        video1.AddComment(new Comment("Nephi", "Amazing video!"));
        video1.AddComment(new Comment("Sam", "Love this!"));
        video1.AddComment(new Comment("Laman", "Boring. No CGI at all."));
        video1.AddComment(new Comment("Lemuel", "Slept through the whole thing."));

        Video video2 = new Video("Legacy", "Tom Monson", 3000);
        video2.AddComment(new Comment("Nephi", "So awesome!"));
        video2.AddComment(new Comment("Sam", "Inspiring!"));
        video2.AddComment(new Comment("Laman", "And they walked and walked and walked. Never been more bored."));
        video2.AddComment(new Comment("Lemuel", "Why won't Dad let us watch Marvel movies?"));

        Video video3 = new Video("Saturday's Warrior", "Ezra Benson", 1200);
        video3.AddComment(new Comment("Nephi", "I hope they call me on a mission!"));
        video3.AddComment(new Comment("Sam", "Go forth and serve!"));
        video3.AddComment(new Comment("Laman", "Why couldn't they get Scarlett Johanson in this movie?"));
        video3.AddComment(new Comment("Lemuel", "I hate our FHE movie nights."));

        Video video4 = new Video("The Testaments", "Howard Hunter", 4500);
        video4.AddComment(new Comment("Nephi", "The ending is so powerful."));
        video4.AddComment(new Comment("Sam", "Great cinematography."));
        video4.AddComment(new Comment("Laman", "Still no Scarlett Johanson."));
        video4.AddComment(new Comment("Lemuel", "I'm just here for the snacks."));

        videos.AddVideo(video1);
        videos.AddVideo(video2);
        videos.AddVideo(video3);
        videos.AddVideo(video4);

        // Call the display method to show the results
        Console.WriteLine("YouTube Video List:");
        Console.WriteLine("-------------------");
        DisplayVideoList(videos);
    }

    public static void DisplayVideoList(VideoList videos)
    {
        foreach (Video video in videos.GetVideos())
        {
            video.DisplayVideo();
        }
    }
}