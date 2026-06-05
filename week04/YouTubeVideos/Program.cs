using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video();

        video1._title = "Learning C#";
        video1._author = "Aevon";
        video1._length = 500;

        Comment c1 = new Comment();
        c1._name = "Noel";
        c1._text = "Incredibly informative";

        Comment c2 = new Comment();
        c2._name = "Sein";
        c2._text = "A little bit difficult to follow.";

        Comment c3 = new Comment();
        c3._name = "Fontano";
        c3._text = "Thanks!";

        video1._comments.Add(c1);
        video1._comments.Add(c2);
        video1._comments.Add(c3);

        // Video 2
        Video video2 = new Video();
        video2._title = "Python Basics";
        video2._author = "Loraine";
        video2._length = 300;

        video2._comments.Add(new Comment { _name = "Mark", _text = "Very easy to understand!" });
        video2._comments.Add(new Comment { _name = "Jane", _text = "Thanks for the tutorial." });
        video2._comments.Add(new Comment { _name = "Paul", _text = "Helped me learn Python." });

        // Video 3
        Video video3 = new Video();
        video3._title = "How to Cook Chicken";
        video3._author = "Chef Mike";
        video3._length = 780;

        video3._comments.Add(new Comment { _name = "Sarah", _text = "Looks delicious!" });
        video3._comments.Add(new Comment { _name = "Tom", _text = "I'll try this recipe." });
        video3._comments.Add(new Comment { _name = "Jake", _text = "Easy to follow." });

        // Video 4
        Video video4 = new Video();
        video4._title = "Algebra for Beginners";
        video4._author = "Professor Lee";
        video4._length = 650;

        video4._comments.Add(new Comment { _name = "Grace", _text = "Math finally makes sense!" });
        video4._comments.Add(new Comment { _name = "Ben", _text = "Excellent lesson." });
        video4._comments.Add(new Comment { _name = "Lucy", _text = "Can you make more videos?" });

    
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}