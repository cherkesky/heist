using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            TeamMember member = new TeamMember(); 

            Console.WriteLine("Hi there cowboy! Whats your name?");
            member.Name = Console.ReadLine();

            Console.WriteLine("How brave are you? 0.0 - 2.0");
             member.CourageFactor  = Convert.ToDouble(Console.ReadLine()) ;

            Console.WriteLine("Whats your skill level?");
            try {
            int _SkillLevel =  Int32.Parse(Console.ReadLine());
            if (_SkillLevel>0){
                member.SkillLevel = _SkillLevel;
            }else{
            Console.WriteLine("Must Enter Postive Value");
            }
            }catch(System.FormatException err){
             System.Console.WriteLine($"Hmmmm that doesnt look like a valid input - {err}");
            }
             Console.WriteLine($@"
             Team Member
             ===========

             Name: {member.Name}
             Skill Level: {member.SkillLevel}
             Courage Factor: {member.CourageFactor}

             ");

        }
    }
}

