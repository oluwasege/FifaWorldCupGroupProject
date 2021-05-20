using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using static System.Environment;
using static System.IO.Path;

namespace FifaWorldCupGroupProject
{
    class FifaFile
    {
        
        public void CreateFile()
        {
            
            string folderName =Combine(GetFolderPath(SpecialFolder.MyDocuments), "Fifa");
            //Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName));
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
                Console.WriteLine("Folder Created");
            }
            //else
            //{
            //    Console.WriteLine("This Folder Exist");
            //}

            string fileName = "WorldcupWinners.txt";
            string pathString = Path.Combine(folderName, fileName);
            if (!File.Exists(pathString))
            {
                FileStream fs = File.Create(pathString);
                fs.Close();
            }

            //else
            //{
            //    Console.WriteLine("File Already Exists");
            //}
            //Console.WriteLine(pathString);

            try
            {
                using StreamWriter sw = new StreamWriter(pathString);
                sw.WriteLine("\t\t\t\t\t\tWorld Cup History\n\nThe FIFA World Cup is the most prestigious soccer competition in the world. Played every four years, the World Cup hosts the top 32 national teams in a month long tournament. The host country is selected by FIFA's Council. The full list of World Cup Winners is listed below. For a list of past World Cup individual player awards visit the World Cup Awards page.");
                sw.WriteLine("\nYEAR\t\tHOST\t\tCHAMPION\t\tRUNNER UP\t\tTEAMS\t\tMATCHES PLAYED");
                sw.WriteLine("\n1930\t\tUraguay\t\tArgentina\t\tUnited States\t\t13\t\t16");
                sw.WriteLine("\n1934\t\tItaly\t\tItaly\t\t\tCzechoslovakia\t\t16\t\t17");
                sw.WriteLine("\n1938\t\tFrance\t\tItaly\t\t\tHungary\t\t\t15\t\t18");
                sw.WriteLine("\n1950\t\tBrazil\t\tUraguay\t\t\tBrazil\t\t\t13\t\t22");


                sw.Close();

            }
            catch (Exception)
            {

                throw;
            }



            
        
        }
        public void ViewHistory()
        {
            string folderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fifa");
            string fileName = "WorldcupWinners.txt";
            string pathString = Path.Combine(folderName, fileName);
            try
            {
                using StreamReader sr = new StreamReader(pathString);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddHistory()
        {

            string folderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fifa");
            string fileName = "WorldcupWinners.txt";
            string pathString = Path.Combine(folderName, fileName);
            try
            {
                


                Console.Write("Enter the year : ");
                string year = Console.ReadLine();
                while(string.IsNullOrEmpty(year))
                {
                    Console.WriteLine("Year Cannot be Left Blank");
                    Console.Write("Enter the year : ");
                    year = Console.ReadLine();
                }
                Console.Write("Enter the Host : ");
                string host = Console.ReadLine();
                while (string.IsNullOrEmpty(host))
                {
                    Console.WriteLine("Host Cannot be Left Blank");
                    Console.Write("Enter the Host : ");
                    host = Console.ReadLine();
                }
                Console.Write("Enter the Champion : ");
                string champion = Console.ReadLine();
                while (string.IsNullOrEmpty(champion))
                {
                    Console.WriteLine("Champion Cannot be Left Blank");
                    Console.Write("Enter the Champion : ");
                    champion = Console.ReadLine();
                }
                Console.Write("Enter the Runner Up : ");
                string runnerUp = Console.ReadLine();
                while (string.IsNullOrEmpty(runnerUp))
                {
                    Console.WriteLine("Runner Up Cannot be Left Blank");
                    Console.Write("Enter the Runner Up : ");
                    runnerUp = Console.ReadLine();
                }
                Console.Write("Enter the Number of Teams : ");
                string teams = Console.ReadLine();
                while (!int.TryParse(teams, out int numberOfTeams))
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Enter the Number of Teams : ");
                    teams = Console.ReadLine();
                }
                Console.Write("Enter the Total matches played : ");
                string matches = Console.ReadLine();
                while (!int.TryParse(matches, out int totalMatchesPlayed))
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Enter the Total matches played : ");
                    matches = Console.ReadLine();
                }
                using StreamWriter sw = File.AppendText(pathString);
                sw.WriteLine();
                sw.WriteLine($"{year}\t\t{host}\t\t{champion}\t\t\t{runnerUp}\t\t\t{teams}\t\t{matches} ");
                sw.Close();

            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                using StreamReader sr = new StreamReader(pathString);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
                
}
}
