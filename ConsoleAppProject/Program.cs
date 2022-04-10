﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Jesse Mwansa                                ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            String[] choices =
                {
                  "App01 Distance Converter",
                  "App02 BMI Calculator",
                  "App03 Student Grades",
                  "App04 Social Network"
                };

            Console.WriteLine("Please choose your app\n");

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    DistanceConverter app01 = new DistanceConverter();
                    app01.Run();
                    break;

                case 2: 
                     BMI app02 = new BMI();
                    app02.Run();
                     break;

                case 3:
                    StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;

                case 4: NewsApp app04 = new NewsApp(); app04.Run();
                    break;   


            }
        }
    }
}
