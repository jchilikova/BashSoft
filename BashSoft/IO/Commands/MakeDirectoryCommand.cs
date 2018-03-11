﻿using BashSoft.Exceptions;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class MakeDirectoryCommand : Command
    {
        public MakeDirectoryCommand(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string folderName = this.Data[1];
                this.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
