using System;
using System.Collections.Generic;
using System.Text;

namespace FifaWorldCupGroupProject
{
    public class Menu
    {
        //Represents the current stage the user is in.
        public int CurrentStage { get; set; }
        public void CheckingOption(string option)
        {
            switch (option)
            {
                case "b":
                    this.CurrentStage = 1;
                    break;
                case "a":
                    this.CurrentStage = 3;
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
            Console.Clear();
        }
       
    }
}
