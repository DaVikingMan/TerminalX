using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace src
{
    // Main class
    class viOne{
        public void Start()
        {
                Console.Clear();
                Menu mk = new Menu();
                mk.MenuMain();
        }
          // Command Class
          public void vi()
          {

              Console.ForegroundColor = ConsoleColor.Cyan;
              
              
                    
                        Console.Clear();
                        
                        Console.WriteLine("Which command do you want to execute?");
                        

                        List<commands> cm = ListManager.Manager();

                        foreach(var m in cm){
                            Console.WriteLine($"{m.command1}\n{m.command2}\n{m.command3}");

                        }
                        Console.Write("> ");
                        string commandRead = Console.ReadLine();
                        
                        
                        if(commandRead == "Exit")
                        {
                            Menu commands = new Menu();
                            commands.MenuMain();
                            
                            



                        }


                        else if(commandRead == "TerminalInfo") // If the user types the following command
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.TerminalInfo("");
                            

                        }
                        
                        else if(commandRead == "ListMaker")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.ListMaker("");
                        }
                        else if(string.IsNullOrWhiteSpace(commandRead))
                        {
                            Console.WriteLine("Kindly input value");
                            Console.ReadKey();
                            vi();
                        }
                        else if(commandRead == "Debug") // TheDebug command is used to go to a certain class(Not completed)
                        {
                            DebugMethod();

                        }
                        else if(commandRead == "WritePad")
                        {
                            CommandsAll v = new CommandsAll();
                            v.WriteConsolePad();

                        }else if(commandRead == "Run")
                        {
                            CommandsAll b = new CommandsAll();
                            b.RunCommand();
                        }

                        
                        
            
            
                
                  

                  

        }

        private void DebugMethod()
        {
            Console.WriteLine("The debug is used to view Debug info");
            Console.Clear();
            Console.WriteLine("Name Info : NAN(return 0),Value(return 1),Special Name : (return +10)");
            Console.WriteLine("CommandRead  : NAN(return), Value(1-5)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Do you want to open Alpha builds or open different states?");
            Console.WriteLine("Type Alpha for Alpha builds or States for opening states");
            string ans = Console.ReadLine();
            if (ans == "Alpha")
            {
                Console.WriteLine("What Alpha build do you want to open");
                ProcessHandler handler = new ProcessHandler();
                handler.ProcessHandle();
                Console.ReadKey();
                Console.WriteLine("Do you want to exit?");
                string ansd = Console.ReadLine();
                if (ansd == "Yes")
                {
                    viOne v = new viOne();
                    v.vi();
                }
                else if (ansd == "No")
                {
                         DebugMethod();
                }

            }
            else if (ans == "States")
            {
                Console.WriteLine("You can open the following States : ");
                Console.ReadKey();
                Console.WriteLine("Notes"); // About TerminalX(Not complete)
                Console.WriteLine("Start"); // Start Menu(Not complete)
                Console.WriteLine("MainTerminal"); // Starting of the program(Not complete)
                Console.ReadKey();
                Console.Clear();
                Console.Write("> ");
                var Tread = Console.ReadLine();
                if (Tread == "Notes")
                {
                    CommandAllReplica c = new CommandAllReplica();
                    c.NotesRe();
                    Console.ReadKey();
                    Console.WriteLine("Do you want to exit?");
                    var cr = Console.ReadLine();
                    if (cr == "Yes" || cr == "yes")
                    {
                        vi();
                    }


                }
                else if (Tread == "Start")
                {
                    CommandAllReplica c = new CommandAllReplica();
                    c.StartRe();

                }
                else if (Tread == "MainTerminal")
                {
                    CommandAllReplica l = new CommandAllReplica();
                    l.MainTerminalRe();

                }

            }
        }


    }
}
