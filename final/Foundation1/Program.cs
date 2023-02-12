using System;

class Program
{
 static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create some videos and comments
            Video video1 = new Video("Video 1", "Author 1", 180);
            video1.Comments.Add(new Comment("Commenter 1", "This is a great video!"));
            video1.Comments.Add(new Comment("Commenter 2", "I agree, very informative."));
            video1.Comments.Add(new Comment("Commenter 3", "Thank you for sharing this!"));
            videos.Add(video1);

            Video video2 = new Video("Video 2", "Author 2", 120);
            video2.Comments.Add(new Comment("Commenter 4", "Fantastic work, keep it up!"));
            video2.Comments.Add(new Comment("Commenter 5", "I learned a lot from this video."));
            videos.Add(video2);

            Video video3 = new Video("Video 3", "Author 3", 240);
            video3.Comments.Add(new Comment("Commenter 6", "This is really helpful, thanks!"));
            video3.Comments.Add(new Comment("Commenter 7", "I'm now a big fan of your work."));
            videos.Add(video3);

            // Display information about each video
            foreach (Video video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length: " + video.Length + " seconds");
                Console.WriteLine("Number of comments: " + video.GetCommentCount());
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine("\t" + comment.Name + ": " + comment.Text);
                }

                Console.WriteLine();
            }
        }
}