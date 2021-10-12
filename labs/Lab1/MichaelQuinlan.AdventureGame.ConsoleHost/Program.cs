/* 
Michael Quinlan
ITSE 1430 Adventure Game
Fall 2021

During a recreational skydiving outing, you crash landed in the middle of an old abbandoned warehouse. This builiding was no ordinary structure. 
It was haunted by ghosts! Since you are the only survivior, you must make your way through the different rooms to 
find your freedom. But be warned! These foul ghosts will not hesitate to cut your adventure short!

*/

using System;

namespace MichaelQuinlan.AdventureGame.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Adventure Game!  ");
            Console.WriteLine("Start Game in Room 5. You can move up, down, left and right.  ");
            Console.WriteLine("During a recreational skydiving outing, you crash landed in the middle of an old abbandoned warehouse. This builiding was no ordinary structure either. It was haunted by ghosts! Since you are the only survivior, you must make your way through the different rooms to find your freedom. But be warned! These foul ghosts will not hesitate to cut your adventure short!  ");

            Console.ReadKey();
        }

        static void AdeventureGame game = new Game();
        
            bool done = false;

            do
        {
            char choice = GetInput();

            if (choice == 'Q')
                done = HandleQuit();          
            if (choice == 'H')
                    Help();

            else if (choice == 'U')
                    MoveUp();
            else if (choice == 'D')
                    MoveDown();
            else if (choice == 'L')
                    MoveLeft();
            else if (choice == 'R')
                    MoveRight();
            Console.WriteLine("Unknown option");

        }    while (!done);
    }

        private static void Quit ()
        {
             if (!ReadBoolean("Are you sure (Y/N)?  "))
                return;

            Console.WriteLine("Not implemented");
        }

        static void roomNumber (MoveUp, MoveDown, MoveLeft, MoveRight)
        {
            roomNumber = ReadString("You are currently in room number:  ", true)
        }

        private static bool HandleQuit()
        {
            if (ReadBoolean("Are you sure you want to quit (Y/N)? "))
                return true;
                return false;
        }

        private static bool ReadBoolean(string message)
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

        static int ReadInt32(string message, int minimumValue)
        {
            Console.Write(message);

            do
            {
        
                var input = Console.ReadLine();
      
                if (Int32.TryParse(input, out var result) && result >= minimumValue)
                    return result;

                DisplayError("The value must be an integral value >= " + minimumValue);
            }       while (true);    
        }

        static string ReadString(string message, bool required)
        {
            Console.Write(message);

            do
            {

            string input = Console.ReadLine();    
                return input;

            }   while (true);
        }

        static char GetInput()
        {
            Console.WriteLine("Adventure Game!");

            Console.WriteLine("U) p");
            Console.WriteLine("D) own");
            Console.WriteLine("L) eft");
            Console.WriteLine("R) right");
            Console.WriteLine("Q) uit");
            Console.WriteLine("H) elp");

            while (true)
            {        
                string input = Console.ReadLine();

                if (input == "U")
                    return 'U';
                else if (input == "D")
                    return 'L';
                else if (input == "R")
                    return 'R';
                else if (input == "Q")
                    return 'Q';
                else if (input == "H")
                    return 'H';

                DisplayError("Invalid input");            
            }; 
        }

        static int roomNumber = currentX + (MaximumX * (currentY - 1));

        switch (roomNumber)
        {
            case 1: Room1(); break;
            case 2: Room2(); break;
            case 3: Room3(); break;
            case 4: Room4(); break;
            case 5: Room5(); break;
            case 6: Room6(); break;
            case 7: Room7(); break;
            case 8: Room8(); break;
            case 9: Room9(); break;
        }

        int newX = x, newY = y;
        switch (direction)
        {
            case up: newY -= 1;
            case down: newY += 1;
            case left: newX -= 1;
            case right: newX += 1;
        }

switch (description)   
{
    case 1 = Console.WriteLine("This part of the building is extremely cold and very wet. Try and find your exits carefully. You can either move to Room 2 or Room 4.  ");
    case 2 = Console.WriteLine("Once you made your way to Room 2, ghosts began to close in on your location. You need to be brave if you want to make it out of this room. Luckily, you have the option to travel to rooms 1, 3 or 5.  ");
    case 3 = Console.WriteLine("Barely escaping with your life, when you entered Room 3, you noticed a horribly stench. Something in the air smelled like rotten eggs. Sulfur! Everyone knows if you smell sulfur in the air, demons are close by. Hurry and decide which room to pick next! Rooms 2 and 6 are accessible to you.  ");
    case 4 = Console.WriteLine("This room is filled with old mannequins from the 80s. Unfortunately, these poorly dressed mannequins made it very difficult to see whether anything else was in the room with you. Run as fast as you can! The only rooms you can move to from here are 1, 5 and 7.  ");
    case 5 = Console.WriteLine("You crashed landed in the middle room of the abandoned building. Gather yourself and all the supplies you may need and pick between rooms 2, 4, 6, and 8 to begin your quest to freedom.  ");
    case 6 = Console.WriteLine(".  ");
    case 7 = Console.WriteLine(".  ");
    case 8 = Console.WriteLine(".  ");
    case 9 = Console.WriteLine(".  ");
}

}
return;