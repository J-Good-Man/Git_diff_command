using System;

namespace Diff_comand
{
    class Program

    {
        static void Main(string[] args)
        {
            //initialises variable for the loop
            int repo_set = 0;

            //while loop is used for input control
            while (repo_set <= 0 || repo_set >= 4)
            {
                //asks the user to input what files they want to compare
                Console.WriteLine("which files do you want to compare? set 1, 2 or 3?");
                string testvalue = Console.ReadLine();

                //converts the input to an integer and checks if if falls within the valid range, notifying the user if it isn't.
                bool correct = Int32.TryParse(testvalue, out repo_set);
                if (correct && Convert.ToInt32(testvalue) >= 1 && Convert.ToInt32(testvalue) <= 3)
                {
                    repo_set = Convert.ToInt32(testvalue);
                }
                else
                {
                    Console.WriteLine("please pick a valid number");
                }
            }

            // cases are used to check the user input and compare the correct files
            switch (repo_set)
            {
                case 1:
                    Console.WriteLine("you selected 1");

                    //reads the files and stores the text in a string
                    string fileA = System.IO.File.ReadAllText(@"Data\GitRepositories_2a.txt");
                    string fileB = System.IO.File.ReadAllText(@"Data\GitRepositories_2b.txt");

                    //determins if the files are the same and lets them know if they are or arn't
                    if (fileA == fileB)
                    {
                        Console.WriteLine("the files are the same");
                    }
                    else;
                    {
                        Console.WriteLine("the files are not the same");
                    }
                    break;

                case 2:
                    Console.WriteLine("you selected 2");
                    string file2A = System.IO.File.ReadAllText(@"Data\GitRepositories_2a.txt");
                    string file2B = System.IO.File.ReadAllText(@"Data\GitRepositories_2b.txt");
                    if (file2A == file2B)
                    {
                        Console.WriteLine("the files are the same");
                    }
                    else;
                    {
                        Console.WriteLine("the files are not the same");
                    }
                    break;

                case 3:
                    Console.WriteLine("you selected 3");
                    string file3A = System.IO.File.ReadAllText(@"Data\GitRepositories_2a.txt");
                    string file3B = System.IO.File.ReadAllText(@"Data\GitRepositories_2b.txt");
                    if (file3A == file3B)
                    {
                        Console.WriteLine("the files are the same");
                    }
                    else;
                    {
                        Console.WriteLine("the files are not the same");
                    }
                    break;

            }
        }
    }
}
