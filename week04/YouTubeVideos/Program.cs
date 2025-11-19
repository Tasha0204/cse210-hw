using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videolist = new List<Video>();

        Video video1 = new Video("Getting to know my beautiful Peru", "Alejandro Castillo Galvez ", 2700);
        Comment video1Comment1 = new Comment("Martha", "This video clearly shows what my beautiful Peru is like.");
        Comment video1Comment2 = new Comment("Andree", "Peruvian cuisine is very rich; the dishes are a feast for your palate.");
        Comment video1Comment3 = new Comment("Alfonso", "Nothing compares to my beautiful Peru.");
        Comment video1Comment4 = new Comment("Ainoha", "What is ruining my beautiful Peru is the government that runs it.");

        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);
        video1.AddComment(video1Comment4);
        videolist.Add(video1);

        Console.WriteLine();

        Video video2 = new Video("Machu Picchu: Wonder of the World", "Sofia Mejia Alcantara", 10800);
        Comment video2Comment1 = new Comment("Pedrito", "Simply magical! The sunrise over Machu Picchu is the most beautiful thing I have ever seen.");
        Comment video2Comment2 = new Comment("Diana", "It's striking; if you focus on the mountain of Machu Picchu, you can see the silhouette of the Inca.");
        Comment video2Comment3 = new Comment("Camila", "The views are simply breathtaking. I'm proud to be Peruvian.");

        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);
        videolist.Add(video2);

        Console.WriteLine();
        Video video3 = new Video("Temple of Los Olivos Sud: A little piece of heaven", "Renzo Soto Choquehuanca", 3600);
        Comment video3Comment1 = new Comment("Aracely", "I thank my Heavenly Father for having two temples in Lima, Peru.");
        Comment video3Comment2 = new Comment("Oscar", "I love how you present our traditional dishes. I definitely need to try them all.");
        Comment video3Comment3 = new Comment("Junwen", "a place to be with family and receive personal revelation.");
         Comment video3Comment4 = new Comment("Mia", "I'm not of their religion, but the people welcomed me warmly, gave me a tour, and explained everything.");

        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);
        video3.AddComment(video3Comment4);
        videolist.Add(video3);

        Console.WriteLine();
        foreach (Video video in videolist)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}