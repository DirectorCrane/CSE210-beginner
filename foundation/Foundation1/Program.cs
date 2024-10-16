using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video ("5 Minutes Crafting", "MR Crafty", 3*60);
        Video video2 = new Video ("How to Change Your Car Tire", "John The Mechanic", 2*60);
        Video video3 = new Video ("How to Tie a Tie", "Peter", 1*60);
        Video video4 = new Video ("Tips and Tricks for  Iphone 20 Pro MAx", "MR Tech", 4*60);

        video1.AddComment(new Comment("Bush Baby", "Wow I can open a can now"));
        video2.AddComment(new Comment("The Big5", "Wow I need to keep my Tools in the car"));
        video3.AddComment(new Comment("Ethan", "Now I can help my dad tie a tie"));
        video4.AddComment(new Comment("Jessica", "Wow I cant wait to get the iphone 20 pro ax"));
        
        List<Video> videos = new List<Video>{video1, video2, video3, video4};
        
        foreach (Video video in videos)
        {
            video.VideoRun();
            Console.WriteLine();
        }
        
        
       
    }
}