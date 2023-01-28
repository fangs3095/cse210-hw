using System;

 class Program
{
    public static void Main(string[] args){
    JournalMk2 journalMk2 = new JournalMk2();
    FileHandling fileHandling = new FileHandling();
    PromptGenerator PromtGenerator = new PromptGenerator();
    ScripturesGenerator scripturesGenerator = new ScripturesGenerator();
    string filename = "";
    
    
        int menu_option = 0;
        while (menu_option != 6 )
        
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


            

          while (menu_option !=6)
          {

            if (menu_option == 1)
            {
                journalMk2.addEntry();
            }
            else if (menu_option == 2)
            {
                 journalMk2.display();
            }
            else if (menu_option == 3)
            {
                 FileHandling.load();
            }
            else if (menu_option == 4)
            {
                 FileHandling.save(journalMk2.date, journalMk2.prompt,journalMk2.userImput);
            }
            else if (menu_option == 5)
            {
                string scripture = scripturesGenerator.getScrip();
                Console.WriteLine(scripture);
            }
            Console.WriteLine("Hello welcom to the joural app");
            Console.WriteLine("Please select what you like to do");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Save");
            Console.WriteLine("4-Load");
            Console.WriteLine("5-Random scripture");
            Console.WriteLine("6-Quit");
            Console.Write(">");
          }
           
    }
}

