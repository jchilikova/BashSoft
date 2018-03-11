using System;
using BashSoft.Exceptions;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentRepository repository;
        private IOManager inputOutputManager;

        protected Command(string input, string[] data, Tester judge, StudentRepository repository, IOManager inputOutputManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public string Input
        {
            get => input;
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.input = value;
            }
        }

        public string[] Data
        {
            get => data;
            private set
            {
                if (value == null || value.Length == 0) 
                {
                    throw new NullReferenceException();
                }

                this.data = value;
            }
           
        }

        public Tester Judge { get => judge; }
        public StudentRepository Repository { get => repository; }
        public IOManager InputOutputManager { get => inputOutputManager; }

        public abstract void Execute();
    }
}
