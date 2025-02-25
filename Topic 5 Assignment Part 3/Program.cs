namespace Topic_5_Assignment_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("Hello and welcome to my mini quiz! There will be 6 questions and you need at least 3 correct to pass.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 1: There 2922 days in 8 years? (True/False)");
            Console.WriteLine();
            Console.Write("Your Answer:? ");
            answer = Console.ReadLine();
            Console.WriteLine();
            if (answer.ToLower() == "true")
            {
                Console.WriteLine("Ding Ding Ding! Your correct!");
            }
            else if (answer.ToLower() == "false")
            {
                Console.WriteLine("Sorry but you must not know this obscure fact :)");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question 2: What is nessecary in a computer for it to start (CPU, GPU, MEMORY,ect excluded)");
            Console.WriteLine("\tA: Power Supply\t " + "\tB: Ram");
            Console.WriteLine("\tC: Hard Drive/SSD\t " + "\tD: Monitor");
            Console.WriteLine();
            Console.Write("Your Answer:? ");
            answer = Console.ReadLine();
            Console.WriteLine();
            if (answer.ToLower() == "a")
            {
                Console.WriteLine("Your correct! CPU and stuff aside, this is required to turn on a computer.");
            }
            else if (answer.ToLower() == "b")
            {
                Console.WriteLine("Wrong! Even though it's important, it's not the main thing the question is asking for.");
            }
            else if (answer.ToLower() == "c")
            {
                Console.WriteLine("Wrong! This is a key component for storing data and managing it easily, its still not the most important thing.");
            }
            else if (answer.ToLower() == "d")
            {
                Console.WriteLine("Wrong! This is important to see what the computer is showing.");
            }
            else
            {
                Console.WriteLine("Invalid Answer");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Question 3: What is the average of 10 15 20 35? ");
            answer = Console.ReadLine();
            Console.WriteLine();
            if (answer == "20")
            {
                Console.WriteLine("Ding Ding! You are correct");
            }
            else
            {
                Console.WriteLine("Sorry but you didnt get the average correct");
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
