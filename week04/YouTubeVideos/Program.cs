using System;

class Program
{
    static void Main(string[] args)
    {
        // call the create video method
        var videos = CreateVideos();
        
        foreach (var video in videos)
        {
            video.Display();
        }
    }
    // method to create the video information
    static List<Video> CreateVideos()
    {
        // create video 1
        var video1 = new Video("How to cook spaghetti", "Joe Pasta", 200);
        video1.AddComment(new Comment("John", "We are all spaghetting older."));
        video1.AddComment(new Comment("Mary", "The battle of spaghettisburg."));
        video1.AddComment(new Comment("Harry", "Like unrinsed spaghetti, good friends stick together."));
        // create video 2
        var video2 = new Video("How to fix a clogged toliet", "Tim Taylor", 500);
        video2.AddComment(new Comment("Julie", "My toilet is clogged. I've been working on it. I'm making a little head way."));
        video2.AddComment(new Comment("Mike", "Sink was clogged so I bought off-brand Liquid Plumber. Boy was that money down the drain."));
        video2.AddComment(new Comment("Heather", "Our son put a carrot down the pipes!"));
        //create video 3
        var video3 = new Video("How to bake bread", "Paul Hollywood", 700);
        video3.AddComment(new Comment("Lisa", "What did mama bread say to her kids? It's way past your breadtime!"));
        video3.AddComment(new Comment("Frank", "How does the bread court his sweetheart? With lots of flours."));
        video3.AddComment(new Comment("Kristy", "What does a loaf of bread say when breaking up with his girlfriend? You deserve butter."));
        // put videos in a list
        var videos = new List<Video> {video1, video2, video3};

        return videos;
    }
}