using System;

namespace BashSoft.Exceptions
{
    public class DuplicateEntryInStrucureException : Exception
    {
        private const string DuplicateEntry = "The {0} already exists in {1}.";

        public DuplicateEntryInStrucureException(string message) : base(message)
        {
        }

        public DuplicateEntryInStrucureException(string entry, string structure)
            : base(string.Format(DuplicateEntry, entry, structure))
        {

        }
    }
}
