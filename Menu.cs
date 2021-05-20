using System;
using System.Collections.Generic;
using System.Text;

namespace FifaWorldCupGroupProject
{
    public class Menu
    {
        //Represents the current stage the user is in.
        public int CurrentStage { get; set; }
        public static void PromptUser(string prompt)
        {
            Console.WriteLine(prompt);
        }
       
    }
}
