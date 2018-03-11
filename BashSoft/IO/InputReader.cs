using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft
{
    public class InputReader
    {
        private const string endCommand = "quit";
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            string input = Console.ReadLine();
            input = input.Trim();

            while (!input.Equals(endCommand))
            {
                this.interpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}
