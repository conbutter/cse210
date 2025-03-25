using System;
using System.ComponentModel;

class Program
{
    private static List<Video> _videoList = new List<Video>();

    static void Main(string[] args)
    {   
        CreateVideoList();
        DisplayVideoList();
    }

    static void CreateVideoList()
    {
        // Create videos
        Video video1 = new Video("Chocolate Rain", "TayZonday", 293);
        Video video2 = new Video("Keyboard Cat", "Keyboard Cat!", 46);
        Video video3 = new Video("Evolution of dance", "Judson Laipply", 361);
        Video video4 = new Video("Numa Numa", "Gary Brolsma", 100);

        // Create comment lists
        Comment comment1 = new Comment("TheGreatGuy", "Going to learn this on piano!!");
        Comment comment2 = new Comment("Fancy Player", "No other song can beat this classic.");
        Comment comment3 = new Comment("creeper8235", "the breathing catches me off guard");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment("Mr Worldwide", "Mr Worldwide approves of this.");
        Comment comment5 = new Comment("Alexander", "I adore this. I will share it with my coworkers.");
        Comment comment6 = new Comment("Misty", "<3");
        Comment comment6a = new Comment("Strange", "idek");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment6a);

        Comment comment7 = new Comment("Greenzilla", "That was EPIC!");
        Comment comment8 = new Comment("1000 SUBS NO VIDS", "Some say he's still dancing to this day.");
        Comment comment9 = new Comment("Google Plus 2", "I am Google Plus 2.");
        Comment comment9a = new Comment("DO NOT CLICK ON MY ACCOUNT", "that's cool");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment9a);

        Comment comment10 = new Comment("LinuxJunkie", "what");
        Comment comment11 = new Comment("Web", "Weird to think it's been 10 years since this was unleashed upon the world");
        Comment comment12 = new Comment("11575", "i like video its fun");
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        
        // Add videos to list
        _videoList.Add(video1);
        _videoList.Add(video2);
        _videoList.Add(video3);
        _videoList.Add(video4);
    }

    static void DisplayVideoList()
    {
        foreach ( Video video in _videoList )
        {
            video.Display();
        }
    }
}