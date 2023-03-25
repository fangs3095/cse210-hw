using System;

 class Program
{
    public static void Main(string[] args){
    Entryies entryies = new Entryies();
    FileHandling fileHandling = new FileHandling();
    QandA qandA = new QandA();
    ScripturesGenerator scripturesGenerator = new ScripturesGenerator();
    string filename = "";
    
    
        int menu_option = 0;
        do {
            Console.WriteLine("Hello welcom to the joural app");
            Console.WriteLine("Please select what you like to do");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Save");
            Console.WriteLine("4-Load");
            Console.WriteLine("5-Random scripture");
            Console.WriteLine("6-Quit");
            Console.Write(">");
            menu_option =Convert.ToInt32 (Console.ReadLine());

    
            if (menu_option == 1)
            {
                entryies.addEntry();
            }
            else if (menu_option == 2)
            {
                 entryies.display();
            }
            else if (menu_option == 3)
            {
                 fileHandling.Save(entryies.date, entryies.prompt, entryies.userInput);
            }
            else if (menu_option == 4)
            {
                 fileHandling.load();
            }
            else if (menu_option == 5)
            {
                string scripture = scripturesGenerator.getScrip();
                Console.WriteLine(scripture);
            }
            
          } while (menu_option != 6);
           
    }
}

