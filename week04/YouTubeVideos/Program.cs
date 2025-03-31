using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Video> videos = new List<Video>();

            // Create first video and its comments
            Video video1 = new Video("C# Programming Tutorial", "CodeMaster", 600);
            video1.AddComment(new Comment("John", "Great tutorial, very helpful!"));
            video1.AddComment(new Comment("Sarah", "Could you make more videos like this?"));
            video1.AddComment(new Comment("Mike", "Well explained concepts"));
            videos.Add(video1);

            // Create second video and its comments
            Video video2 = new Video("Guitar Basics", "MusicPro", 480);
            video2.AddComment(new Comment("Alex", "This helped me start playing"));
            video2.AddComment(new Comment("Emma", "Perfect for beginners"));
            videos.Add(video2);

            // Create third video and its comments
            Video video3 = new Video("Cooking Italian Pasta", "ChefCuisine", 720);
            video3.AddComment(new Comment("David", "Made this recipe today, delicious!"));
            video3.AddComment(new Comment("Lisa", "Simple and tasty"));
            video3.AddComment(new Comment("Peter", "Love the tips"));
            video3.AddComment(new Comment("Maria", "Traditional recipe, love it"));
            videos.Add(video3);

            // Here I Display all videos and their comments
            foreach (Video video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}
