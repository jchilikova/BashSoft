using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BashSoft
{
    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsMarks, string comparison, int studentToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                this.PrintStudents(studentsMarks.OrderBy(x=> x.Value)
                    .Take(studentToTake)
                    .ToDictionary(pair=> pair.Key, pair => pair.Value));
            }
            else if(comparison == "descending")
            {
                PrintStudents(studentsMarks.OrderByDescending(x => x.Value)
                     .Take(studentToTake)
                     .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComparisonQuery);
            }
        }
       
        private void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (KeyValuePair<string,double> keyValuePair in studentsSorted)
            {
                OutputWriter.PrintStudent(keyValuePair);
            }
        }
    }
}
