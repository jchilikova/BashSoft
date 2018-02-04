using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BashSoft
{
    public static class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentsToTake)
        {
            if (wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x => x >= 5, studentsToTake);
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => x < 5.0 && x >= 3.5, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;
            foreach (var student in wantedData)
            {
                if (counterForPrinted == studentsToTake)
                {
                    break;
                }

                double averageScore = student.Value.Average();
                double percentageOfFullfilment = averageScore / 100;
                double mark = percentageOfFullfilment * 4 + 2;
                if (givenFilter(mark))
                {
                    OutputWriter.PrintStudent(student);
                    counterForPrinted++;
                }
            }
        }

        // private static bool ExcellentFilter(double mark)
        // {
        //     return mark >= 5.0;
        // }
        // private static bool AverageFilter(double mark)
        // {
        //     return mark < 5.0 && mark >= 3.5;
        // }
        // private static bool PoorFilter(double mark)
        // {
        //     return mark < 3.5;
        // }

        //private static double Average(List<int> scoreOnTask)
        //{
        //    int totalScore = 0;
        //    foreach (var score in scoreOnTask)
        //    {
        //        totalScore += score;
        //    }

        //    double percentageOfAll = (double)totalScore / ((double)scoreOnTask.Count * 100);
        //    var mark = percentageOfAll * 4 + 2;

        //    return mark;
        //}

    }
}
