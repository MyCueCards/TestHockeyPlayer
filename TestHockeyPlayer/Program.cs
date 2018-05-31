/********************************************************************
 * Original from SDEV 240                                           *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 417, Exercise 1):                             *
 * Create an application named TestHockeyPlayer that instantiates   *
 * and displays a HockeyPlayer object. The HockeyPlayer class       *
 * contains fields for a player’s name (a string), jersey number    *
 * (an integer), and goals scored (an integer).                     *
 ********************************************************************/
using System;

namespace TestHockeyPlayer
{
    class HockeyPlayer
    {
        public string Name { get; set; }
        public int JNumber { get; set; }
        public int GScore { get; set; }
    }
    class EhrmanHarleyTestHockeyPlayer
    {
        static void Main(string[] args)
        {
            HockeyPlayer player1 = new HockeyPlayer()
            { Name = "Joe", JNumber = 17, GScore = 22 };

            //display 
            Console.WriteLine("{0} has jersey number {1} with {2} goals scored.", player1.Name, player1.JNumber, player1.GScore);

            //stops program from automatically closing after above text displays.
            Console.ReadLine();
        }
    }
}
