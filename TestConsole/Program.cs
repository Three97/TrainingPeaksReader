using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    using System.IO;

    using FinalSurge;

    class Program
    {
        static void Main(string[] args)
        {
            const string TestDataDirectory = @"..\..\..\TestData";
            if (!Directory.Exists(TestDataDirectory))
            {
                Console.WriteLine($"Test data directory does not exist! - {TestDataDirectory}");
                ContinuePrompt();
                return;
            }

            var workoutCollections = new Dictionary<string, List<Workout>>();
            var csvFiles = Directory.GetFiles(TestDataDirectory, "*.csv").ToList();
            csvFiles.ForEach(x => workoutCollections.Add(x, TrainingPeaksReader.ReadCsvFile(x)));

            Console.WriteLine($"CSV Files read: {workoutCollections.Count}\n\n");

            workoutCollections.ToList()
                .ForEach(x => Console.WriteLine($"File: {Path.GetFileName(x.Key)} => Workouts Found: {x.Value.Count}"));

            ContinuePrompt();
        }

        private static void ContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
