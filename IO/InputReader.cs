using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BashSoft
{
    class InputReader
    {
        private const string endCommand = "quit";
        public static void StartReadingCommands()
        {
            while (true)
            {
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                string input = Console.ReadLine();
                input = input.Trim();
                if (input == endCommand)
                {
                    break;
                }
                CommandInterpreter.InterpredCommand(input);
            }
            
        }
    }
}
