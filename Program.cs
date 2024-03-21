using System.Text;

namespace Topic_12_for_real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EventScore> eventScores;
                
            eventScores = ReadEventScoresFromFile(@"results.txt");

            foreach (EventScore eventScore in eventScores)
            {
                Console.WriteLine(eventScore);
            }

            int choice;
            do
            {
                Console.WriteLine("Menu:\n");
                Console.WriteLine("1. Print Scores");
                Console.WriteLine("2. Highest Score");
                Console.WriteLine("3. Lowest Score");
                Console.WriteLine("0. Exit");

                Console.WriteLine("\nEnter your choice:\n");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Scores:");
                        PrintScores(eventScores);
                        break;
                    case 2:
                        Console.WriteLine("Highest Scores:");
                        PrintHighestScores(eventScores);
                        break;
                    case 3:
                        PrintLowestScore(eventScores);
                        break;
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 0);
        }

        static List<EventScore> ReadEventScoresFromFile(string v)
        {
            List<EventScore> eventScores = new List<EventScore>();
            string name, playerEvent;
            List<double> scores;


            using (StreamReader reader = new StreamReader(v))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    scores = new List<double>();
                    name = line;
                    playerEvent = reader.ReadLine();
                    scores.Add(Convert.ToDouble(reader.ReadLine()));
                    scores.Add(Convert.ToDouble(reader.ReadLine()));
                    scores.Add(Convert.ToDouble(reader.ReadLine()));
                    scores.Add(Convert.ToDouble(reader.ReadLine()));
                    scores.Add(Convert.ToDouble(reader.ReadLine()));

                    eventScores.Add(new EventScore(name, playerEvent, scores));
                }
            }
            return eventScores;
        }

        static void PrintScores(List<EventScore> eventScores)
        {
            foreach (EventScore eventScore in eventScores)
            {
                Console.WriteLine(eventScore);
            }
        }

        static void PrintHighestScores(List<EventScore> eventScores)
        {
            EventScore highestScore = eventScores.OrderByDescending(e => e.GetTotalscore()).First();//THID
            Console.WriteLine("Highest Score:");
            Console.WriteLine(highestScore);
        }

        static void PrintLowestScore(List<EventScore> eventScores)
        {
            EventScore lowestScore = eventScores.OrderBy(e => e.GetTotalScore()).First();//THISD
            Console.WriteLine("Lowest Score:");
            Console.WriteLine(lowestScore);
        }
    }

}

    
    
