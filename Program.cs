using System;
using System.Collections.Generic;

namespace heist
{
  class Program
  {
    static void Main(string[] args)
    {
      int memberSkillSum = 0;
      int successSum = 0;
      int failureSum = 0;

      Dictionary<string, TeamMember> heistTeam = new Dictionary<string, TeamMember>();

      Console.WriteLine("Plan Your Heist!");

      Console.WriteLine("Whats the bank difficulty level? ");
      int bankDiffLevel = Int32.Parse(Console.ReadLine());

      while (true)
      {
        TeamMember member = new TeamMember();

        Console.WriteLine("Hi there cowboy! Whats your name?");
        string _Name = Console.ReadLine();
        if (_Name == "")
        {
          break;
        }
        else
        {
          member.Name = _Name;
        }

        Console.WriteLine("How brave are you? 0.0 - 2.0");
        member.CourageFactor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Whats your skill level?");
        member.SkillLevel = Int32.Parse(Console.ReadLine());
        memberSkillSum += member.SkillLevel; // aggregating skill level value

        heistTeam.Add(member.Name, member);

        Console.WriteLine("Team Member Added!");

      } // end of While loop


      Console.WriteLine("How many trials? ");
      int Tries = Convert.ToInt16(Console.ReadLine());

      for (int i = 1; i <= Tries; i++)
      {
        Random rnd = new Random();
        int luck = rnd.Next(-10, 11);
        bankDiffLevel += luck;

        Console.WriteLine($@"
      Cool! So we got {heistTeam.Count} team members on board:
      ========================================================
      ");

        foreach (KeyValuePair<string, TeamMember> teamMember in heistTeam)
        {
          System.Console.WriteLine($@"
        Name: {teamMember.Key}, Skill Level: {teamMember.Value.SkillLevel}, Courage Factor: {teamMember.Value.CourageFactor}
          ");
        }
        Console.WriteLine($@"
        Team Combined Skill Level: {memberSkillSum}
        Bank Difficulty Level: {bankDiffLevel}

      ========================================================
      ");

        if (memberSkillSum >= bankDiffLevel)
        {
          successSum++;
        }
        else
        {
          failureSum++;
        }

      }

      System.Console.WriteLine($@"
          Final Report - Success: {successSum}, Failure: {failureSum}
          ");

    }
  }
}

