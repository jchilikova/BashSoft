using BashSoft.SimpleJudge;
using System;
using System.Diagnostics;

namespace BashSoft
{
    public class Program
    {
        public static void Main()
        {
            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentRepository repo = new StudentRepository(new RepositoryFilter(), new RepositorySorter());

            CommandInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            InputReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
