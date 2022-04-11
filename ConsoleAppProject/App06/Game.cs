using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App06
{
    public class Game
    {
        public void Run() 
        {
            ConsoleHelper.OutputHeading("Rock Paper Scissor Game");
            GameImages.DrawSmile();
        }
    }
}
