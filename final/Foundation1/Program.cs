using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> v1Comments = new List<Comment>();

        Comment comment_1 = new Comment("John", "This is awesome!");
        v1Comments.Add(comment_1);
        Comment comment_2 = new Comment("Mark", "Great content.");
        v1Comments.Add(comment_2);
        Comment comment_3 = new Comment("Elizabeth", "Well articulated.");
        v1Comments.Add(comment_3);


        List<Comment> v2Comments = new List<Comment>();

        Comment comment4 = new Comment("Martha", "Great Video!");
        v2Comments.Add(comment4);
        Comment comment5 = new Comment("Gerald", "Well explained!");
        v2Comments.Add(comment5);
        Comment comment6 = new Comment("Hellen", "Finally, a great explanation for While Loops!");
        v2Comments.Add(comment6);
        

        List<Comment> v3Comments = new List<Comment>();
        
        Comment comment7 = new Comment("Caleb", "Great content as usual.");
        v3Comments.Add(comment7);
        Comment comment8 = new Comment("Kelle", "Next do a video on Arrays, please!");
        v3Comments.Add(comment8);
        Comment comment9 = new Comment("Pedro", "Thank you Katopola for the video.");
        v3Comments.Add(comment9);


        List<Video> videosList = new List<Video>(); 

        Video video1 = new Video("C# For Loop", "Moffat", 540, v1Comments);
        videosList.Add(video1);
        Video video2 = new Video("C# While Loop", "Stephen", 480, v2Comments);
        videosList.Add(video2);
        Video video3 = new Video("C# Switch", "Katopola", 660, v3Comments);
        videosList.Add(video3);

        Console.WriteLine();

        foreach (Video video in videosList)
        {
            Console.WriteLine($"Video name : {video._title}\nLength: {video._length} seconds\nAuthor: {video._author}\nComments : {video.GetNumberOfComments()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }

    }
}

