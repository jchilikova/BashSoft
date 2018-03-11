using System;
using System.Collections.Generic;
using System.Text;
using BashSoft.Exceptions;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class TraverseFoldersCommand : Command
    {
        public TraverseFoldersCommand(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 1)
            {
                this.InputOutputManager.TraverseDirectory(0);
            }
            else if (this.Data.Length == 2)
            {
                int depth;
                bool hasParsed = int.TryParse(this.Data[1], out depth);

                if (hasParsed)
                {
                    this.InputOutputManager.TraverseDirectory(depth);
                }
                else
                {
                   throw new ArgumentException(ExceptionMessages.UnableToParseNumber);
                }

            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
