using System;

namespace MichaelQuinlan.CharacterCreator.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    static void AdeventureGame game = new Game ();

    bool done = false;

        do
        {
            char choice = GetInput();

            if (choice == 'Q')
                done = HandleQuit ();          
            if (choice == 'H')
                    Help ();

            else if (choice == 'U')
                    MoveUp ();
            else if (choice == 'D')
                    MoveDown ();
            else if (choice == 'L')
                    MoveLeft ();
            else if (choice == 'R')
                    MoveRight ();
            Console.WriteLine("Unknown option");

        } while (!done) ;

        private static void Quit ()
        {
            if (!ReadBoolean("Are you sure (Y/N)?  "))
            return;

            Console.WriteLine("Not implemented");
        }

        static void roomNumber ( MoveUp, MoveDown, MoveLeft, MoveRight)
        {
            roomNumber = ReadString("You are currently in room number:  ", true)
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
