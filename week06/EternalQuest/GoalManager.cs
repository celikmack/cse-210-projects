using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;


public class GoalManager
{
   private List<Goal> _goals = new List<Goal>();
   private int _score;

   public GoalManager()
    {
        _score = 0;
    } 

    public void Start()
    {
        Console.WriteLine("*************************************");
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("*************************************");

        do
        {
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice  = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }

            else if (choice == 2)
            {
                ListGoalDetails();
            }

            else if (choice == 3)
            {
                SaveGoals();
            }

            else if (choice == 4)
            {
                LoadGoals();
            }

            else if (choice == 5)
            {
                RecordEvent();
            }

            else if (choice == 6)
            {
                Console.WriteLine("Keep on working. Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Please choose a valid number.");
            }
            
        } while (true);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach(Goal activity in _goals)
        {
            string goalDetails = activity.GetStringRepresentation();
            string [] goalName = goalDetails.Split(",");
            Console.WriteLine($" {_goals.IndexOf(activity) + 1}. {goalName[1]}");
        }

    }

    public void ListGoalDetails()
    {
            Console.WriteLine("These are your goals: ");
            foreach(Goal activity in _goals)
            {
                Console.WriteLine($"{_goals.IndexOf(activity) + 1}. {activity.GetCheckbox()}");    
            }
            
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        do
        {
            Console.Write("Which type of goal would you like to create? ");
            int type = int.Parse(Console.ReadLine());
            
            if (type == 1)
            {
                List<string> sItems = GoalHelper();
                SimpleGoal simple = new SimpleGoal(sItems[0], sItems[1], int.Parse(sItems[2]));
                _goals.Add(simple);
                break; 
            }                                     

            else if (type == 2)
            {
                List<string> eItems = GoalHelper();
                EternalGoal eternal = new EternalGoal(eItems[0], eItems[1], int.Parse(eItems[2]));
                _goals.Add(eternal);
                break;
            }    

            else if (type == 3)
            {
                List<string> cItems = GoalHelper();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string bonus = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string target = Console.ReadLine();
                
                cItems.AddRange(new List<string> {bonus, target});
                ChecklistGoal checklist = new ChecklistGoal(cItems[0], cItems[1], int.Parse(cItems[2]), int.Parse(cItems[3]), int.Parse(cItems[4]));
                _goals.Add(checklist);
                break;
            }
            else
            {
                Console.WriteLine($"Please choose an valid number.");
            }        
        } while (true);
    }

    public List<string> GoalHelper()
    {
        Console.Write("\nWhat is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short descritption of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");               
        string points = Console.ReadLine();

        return new List<string> {name, description, points};
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine($"What goal did you complet? (by nymber): ");
        int goalCompleted = int.Parse(Console.ReadLine());

        Goal chosenGoal = _goals[goalCompleted -1];

        int reward = chosenGoal.RecordEvent();
        _score += reward;
        Console.WriteLine($"Well done! You have earned {reward} points.");
        Console.WriteLine($"Your current points are {_score}.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine() + ".csv";

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach(Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
        
        Console.WriteLine("Goals succesfully saved!");
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();

        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine() + ".csv";
        
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal sGoal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(sGoal);
            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal eGoal = new EternalGoal(name, description, points);
                _goals.Add(eGoal);
            }

            else if(goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(checklist);
            }
        }

        Console.WriteLine("Goals successfully loaded!");
    }
}