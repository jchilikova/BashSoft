using System;
using System.Collections.Generic;
using System.Text;
using BashSoft.Exceptions;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class ReadDatabaseCommand : Command
    {
        public ReadDatabaseCommand(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string filePath = this.Data[1];
                this.Repository.LoadData(filePath);
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
