using System;

// EXCEEDING REQUIREMENTS:
// I added a Leveling System to the display.
// The user now sees their current Level based on their total score.
// Level 1 starts at 0 points, Level 2 at 1000, etc.
// This adds extra gamification to encourage the user.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}