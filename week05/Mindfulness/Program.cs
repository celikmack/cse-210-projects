using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathAct = new BreathingActivity(30);
        ReflectingActivity reflectAct = new ReflectingActivity(30);
        ListingActivity listAct = new ListingActivity(30);
        SingingActivity singAct = new SingingActivity(30);
 
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Start Singing Activity");
            Console.WriteLine("\t5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathAct.Run();
                    break;
            
                case "2":                    
                    reflectAct.Run();
                    break;

                case "3":
                    listAct.Run();
                    break;

                case "4":
                    singAct.Run();
                    break;
                
                case "5":
                    Console.WriteLine("Glad to help you!");
                    return;

                default:    
                    Console.WriteLine("Number invalid!");
                    break;
            }
        }
    }
}