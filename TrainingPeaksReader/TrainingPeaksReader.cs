using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FinalSurge
{
    public static class TrainingPeaksReader
    {
        public static List<Workout> ReadCsvFile(string csvFilePath, bool isFirstRowHeader = true)
        {
            return
                File.ReadAllLines(csvFilePath)
                    .Skip(isFirstRowHeader ? 1 : 0)
                    .Select(line => line.Split(new char[] { ',' }).Select(x => x.Replace("\"", string.Empty)).ToArray())
                    .Select(
                        x =>
                            new Workout
                                {
                                    Type = x[0].Trim(),
                                    Description = x[1].Trim(),
                                    PlannedDuration = ParseDecimal(x[4]),
                                    PlannedDistanceInMeters = ParseDecimal(x[5]),
                                    WorkoutDate = ParseDateTime(x[6]),
                                    CoachComments = x[7].Trim(),
                                    DistanceInMeters = ParseDecimal(x[8]),
                                    PowerAverage = ParseInt(x[9]),
                                    PowerMax = ParseInt(x[10]),
                                    Energy = ParseDecimal(x[11]),
                                    AthleteComments = x[12].Trim(),
                                    TotalTimeInHours = ParseDecimal(x[13]),
                                    VelocityAverage = ParseDecimal(x[14]),
                                    VelocityMax = ParseDecimal(x[15]),
                                    CadenceAverage = ParseInt(x[16]),
                                    CadenceMax = ParseInt(x[17]),
                                    HeartRateAverage = ParseInt(x[18]),
                                    HeartRateMax = ParseInt(x[19])
                                })
                    .ToList();
        }

        private static DateTime? ParseDateTime(string data)
        {
            DateTime result;
            if (DateTime.TryParse(data.Trim(), out result))
            {
                return result;
            }

            return null;
        }

        private static decimal? ParseDecimal(string data)
        {
            decimal result;
            if (decimal.TryParse(data.Trim(), out result))
            {
                return result;
            }

            return null;
        }

        private static int? ParseInt(string data)
        {
            int result;
            if (int.TryParse(data.Trim(), out result))
            {
                return result;
            }

            return null;
        }
    }
}
