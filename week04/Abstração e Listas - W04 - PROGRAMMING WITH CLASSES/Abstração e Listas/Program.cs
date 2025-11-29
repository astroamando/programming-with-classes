using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list to store videos
        List<Video> videos = new List<Video>();

        // --- VIDEO 1 ---
        Video video1 = new Video("Learning C# in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("John Smith", "Great explanation!"));
        video1.AddComment(new Comment("Mary Oliver", "Helped me a lot with my work."));
        video1.AddComment(new Comment("DevJunior", "Could you talk more about Classes?"));
        videos.Add(video1);

        // --- VIDEO 2 ---
        Video video2 = new Video("Best Soccer Goals 2024", "TotalSport", 450);
        video2.AddComment(new Comment("Carl Santos", "What a goal by number 10!"));
        video2.AddComment(new Comment("Ana Perry", "The goalkeeper saved everything."));
        video2.AddComment(new Comment("Phil Costa", "This team is going to be the champion."));
        videos.Add(video2);

        // --- VIDEO 3 ---
        Video video3 = new Video("Carrot Cake Recipe", "PracticalKitchen", 900);
        video3.AddComment(new Comment("Fernanda Lee", "It was delicious, thanks!"));
        video3.AddComment(new Comment("Robert Al", "Mine burned a little, lol."));
        video3.AddComment(new Comment("Julia M.", "Can I replace oil with butter?"));
        videos.Add(video3);

        // --- ITERATION AND DISPLAY ---
        // Loop through the list of videos
        foreach (Video v in videos)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            // Use the method to get the count
            Console.WriteLine($"Number of Comments: {v.GetNumberOfComments()}"); 
            Console.WriteLine("--- Comments ---");

            // Loop through comments INSIDE each video
            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"- {c._name}: {c._text}");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(); // Blank line for separation
        }
    }
}