using System;

namespace FunRecommendations
{
    class FunRecs
    {
        private readonly int userActivityChoice;
        private readonly int numGuests;

        public FunRecs(int userActivityChoice, int numGuests)
        {
            this.userActivityChoice = userActivityChoice;
            this.numGuests = numGuests;
        }

        public static string Greeting() // Returns a greeting depending on the time of day the program is run
        {
            string greetingText;
            if (DateTime.Now.Hour < 12)
            {
                greetingText = "Good Morning!";

            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                greetingText = "Good Afternoon!";
            }
            else
            {
                greetingText = "Good Evening!";
            }
            return greetingText;
        }

        public static bool IsValidInput(int userActivityChoice)
        {
            if (userActivityChoice < 1 ||  userActivityChoice > 4)
            {
                return false;  
            }
            else
            {
                return true;
            }
        }

        public string UserMood() // returns the initial activity choice the user made 
        {
            switch (this.userActivityChoice)
            {
                case 1:
                    return "action";
                case 2:
                    return "chilling";
                case 3:
                    return "danger";
                case 4:
                    return "good food";
                default:
                    return null;
            }
        }

        public string Activity() //returns the activity the computer chooses for the user
        {
            string computerChoice;

            switch (this.userActivityChoice)
            {
                case 1:
                    computerChoice = "stock car racing";
                    break;
                case 2:
                    computerChoice = "hiking";
                    break;
                case 3:
                    computerChoice = "skydiving";
                    break;
                case 4:
                    computerChoice = "to Taco Bell";
                    break;
                default:
                    return null;
            }
            return computerChoice;
        }

        public string Transportation(int numGuests) // returns the type of transportation to use depending on the number of guests 
        {
            string transportationMode;

            if (numGuests == 0)
            {
                transportationMode = "sneakers";
            }
            else if (numGuests >= 1 && numGuests <= 4)
            {
                transportationMode = "a sedan";
            }
            else if (numGuests >= 5 && numGuests <= 10)
            {
                transportationMode = "a Volkswagen bus";
            }
            else
            {
                transportationMode = "an airplane";
            }
            return transportationMode;
        }

        public override string ToString()
        {
            return $"Okay! If you are interested in {UserMood()}, you should go {Activity()} and should travel in {Transportation(numGuests)}";

        }
    }
}
