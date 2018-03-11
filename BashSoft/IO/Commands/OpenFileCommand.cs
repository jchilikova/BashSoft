using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using BashSoft.Exceptions;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data, Tester judge, StudentRepository repository,
            IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string fileName = this.Data[1];
                try
                {
                    var process = new Process();
                    process.StartInfo.FileName = SessionData.currentPath + "\\" + fileName;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }
                catch (Win32Exception)
                {
                    throw new Win32Exception(ExceptionMessages.CannotFindFile);
                }

            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
