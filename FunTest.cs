using System;
namespace FunRecommendations
{
    public class FunTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunRecs.Greeting());
            Console.WriteLine("\nWhat activity are you interested in?");
            Console.WriteLine("Your options are: \n 1) Action \n 2) Chilling \n 3) Danger \n 4) Good Food");
            int userActivityChoice = Convert.ToInt32(Console.ReadLine());

            if (!FunRecs.IsValidInput(userActivityChoice))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
          
            Console.WriteLine("How many people are you taking with you?");
            int numGuests = Convert.ToInt32(Console.ReadLine());
            FunRecs recs1 = new FunRecs(userActivityChoice, numGuests);

            Console.WriteLine(recs1);

        } 
    }
}
