using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        _count = 0;
        
        // Loop que permite o usuário digitar até o tempo acabar
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}