using System;

namespace MichaelQuinlan.CharacterCreator.ConsoleHost
{
    class Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a character!  ");
        }
    }

    static void CharacterCreator character = new Character ();

    bool done = false;

        do
        {
            char choice = GetInput();

            if (choice == 'Q')
                done = HandleQuit ();          
            if (choice == 'H')
                    Help ();

            else if (choice == 'C')
                    Create ();
            else if (choice == 'B')
                    Build ();
            else if (choice == 'R')
                    Race ();
            else if (choice == 'A')
                    Attributes ();
            
            Console.WriteLine("Unknown option");

        } while (!done) ;

        private static void Quit ()
        {
            if (!ReadBoolean("Are you sure (Y/N)?  "))
            return;

            Console.WriteLine("Not implemented");
        }

        private static bool HandleQuit ()
        {
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;
                return false;
        }

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);

            do
            {
                ConsoleKeyInfo input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.Y)
                    return true;

                else if (input.Key == ConsoleKey.N)
                    return false;

        }   while (true);
}
