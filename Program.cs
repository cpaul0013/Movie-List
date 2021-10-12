using System;
using System.Collections.Generic;

namespace Movie_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>()
        {
         new Movie("Spirited Away", "Animated"),
         new Movie("Ponyo", "Animated"),
         new Movie("Dawn of the Dead", "Horror"),
        new Movie("The Blob", "Horror"),
        new Movie("Notting Hill", "Drama"),
        new Movie("Moonlight", "Drama"),
        new Movie("A New Hope", "Sci-Fi"),
        new Movie("The Empire Strikes Back", "Sci-Fi"),
        new Movie("Return of the Jedi", "Sci-Fi"),
        new Movie("Finding Nemo", "Animated"),
    };


            Console.WriteLine("Welcome to the Movie Genre Generator!");

            while (true)
            {

                Hello(movies);


               bool cont = getContinue("Would you like to enter another category? Y / N");
                if(cont == false)
                {
                    break;
                }
                





            }



        }

        public static void Hello(List<Movie> movies)
        {
            List<Movie> selectedCategory = new List<Movie>();
            bool validInput = false;
            while (validInput == false)
            {

                Console.WriteLine("Please enter a genre: Animated, Horror, Drama, Sci-Fi");
                string choice = Console.ReadLine();
                foreach (Movie m in movies)
                {
                    if (choice.ToLower() == m.GetGenre().ToLower())
                    {
                        selectedCategory.Add(m);
                        validInput = true;
                    }


                }
                if (validInput == false)
                {
                    Console.WriteLine("Invalid Input");
                }

            }

            foreach (Movie m in selectedCategory)
            {
                Console.WriteLine(m.GetTitle());
            }
        }

        public static bool getContinue(string s)
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine(s);
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    result = true;
                    break;

                }

                else if (choice == "n")
                {
                    result = false;
                    break;
                }

                else
                {
                    Console.WriteLine("That was not a valid response.");
                }

            }
            return result;

        }






    }
}
