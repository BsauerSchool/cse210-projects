using System;
using System.ComponentModel.Design;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // GoalManager()
    public GoalManager()
    {
        // Processing the choices
        int choice = 0;
        while (choice != 6)
        {
            choice = 0;
            // Menu Options:
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create a New Goal");
            Console.WriteLine(" 2. List Goals");        
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
                
            switch (choice)
            {
                // 1 new goal
                case 1:
                    Console.WriteLine("new goal\n");
                    break;
                // 2 List goal
                case 2: 
                    Console.WriteLine("List Goals\n");
                    break;
                // 3 Save Goal
                case 3:
                    Console.WriteLine("Save Goal\n");
                    break;
                // 4 Load
                case 4:
                    Console.WriteLine("Load\n");
                    break;
                // 5 Record Event
                case 5: 
                    Console.WriteLine("Record Event\n");
                    break;
                // 6 Quit
                case 6:
                    Console.WriteLine("Quit\n");
                    break;
                default:
                    Console.WriteLine("Invalid Entry\n");
                    break;
            }
        }
    }
    // Start(): VoidList goal
    // DisplayPlayerInfo(): void
    // ListGoalNames(): void
    // ListGoalDetails(): void
    // CreateGoal(): Void
    public void CreatGoal()
    {
        
    }
    // SaveGoals(): Void
    //LoadGoals(): void
}