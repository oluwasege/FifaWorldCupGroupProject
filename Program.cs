using System;
using System.IO;

namespace FifaWorldCupGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            FifaFile fifa = new FifaFile();
            fifa.CreateFile();
            menu.CurrentStage = 1;
            bool appIsRunning = true;

            while(appIsRunning)
            {
               
                while (menu.CurrentStage==1)
                {
                    Console.WriteLine("\t\t\t\t\t\tWelcome\n\nThis is an application to check Fifa World Cup History and also add yours\n");
                    Console.WriteLine("1 : View History");
                    Console.WriteLine("2 : Add History ");
                    Console.WriteLine("3 : Exit");
                    string selectedOption = Console.ReadLine();
                    
                    switch(selectedOption)
                    {
                        case "1" :
                            menu.CurrentStage = 2;
                            break;
                        case "2":
                            menu.CurrentStage = 3;
                            break;
                        case "3":
                            Environment.Exit(0);
                            break;
                        default:
                            //Console.Clear();
                            //Console.WriteLine("Invalid Input\n");
                            //menu.CurrentStage = 1;
                            break;
                    }
                    Console.Clear();
                    
                }

                while(menu.CurrentStage==2)
                {
                    fifa.ViewHistory();
                    Console.WriteLine("Press b to go back, a to add, and e to exit");
                    string options = Console.ReadLine().ToLower();
                    menu.CheckingOption(options);
                }
                while(menu.CurrentStage==3)
                {
                    
                    fifa.AddToHistory();
                    Console.WriteLine("Press b to go back, a to add, and e to exit");
                    string options = Console.ReadLine().ToLower();
                    while (options != "b" & options != "a" & options != "e")
                    {

                        Console.WriteLine("Invalid Input\nPress b to go back, a to add, and e to exit");
                        options = Console.ReadLine().ToLower();
                    }
                    menu.CheckingOption(options);


                }
            }
            
            




















            /*

            string folderName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Fifa");
             //Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folderName));
            if(!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
                Console.WriteLine("Folder Created");
            }
            else
            {
                Console.WriteLine("This Folder Exist");
            }

            string fileName = "WorldcupWinners.txt";
            string pathString = Path.Combine(folderName, fileName);
            if(!File.Exists(pathString))
            {
                FileStream fs = File.Create(pathString);
                fs.Close();
            }
            
            //else
            //{
            //    Console.WriteLine("File Already Exists");
            //}
            Console.WriteLine(pathString);

            try
            {
                using StreamWriter sw = new StreamWriter(pathString);
                sw.WriteLine("World Cup History\n\nThe FIFA World Cup is the most prestigious soccer competition in the world. Played every four years, the World Cup hosts the top 32 national teams in a month long tournament. The host country is selected by FIFA's Council. The full list of World Cup Winners is listed below. For a list of past World Cup individual player awards visit the World Cup Awards page.");
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
            Console.Write("Enter the year : ");
            string year = Console.ReadLine();
            Console.Write("Enter the Host : ");
            string host = Console.ReadLine();
            Console.Write("Enter the Champion : ");
            string champion = Console.ReadLine();
            Console.Write("Enter the Runner Up : ");
            string runnerUp = Console.ReadLine();
            Console.Write("Enter the Number of Teams : ");
            string teams = Console.ReadLine();
            Console.Write("Enter the Total matches played : ");
            string matches = Console.ReadLine();

            try
            {
                using StreamWriter sw = File.AppendText(pathString); 
                sw.WriteLine($"\n{year}\t\t{host}\t\t{champion}\t\t\t{runnerUp}\t\t\t{teams}\t\t{matches} ");
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
            */
        }

    }
}
