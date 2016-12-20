using System;

namespace FinalSurge
{
    public sealed class Workout
    {
        public string AthleteComments { get; set; }

        public int? CadenceAverage { get; set; }

        public int? CadenceMax { get; set; }

        public string CoachComments { get; set; }

        public string Description { get; set; }

        public decimal? DistanceInMeters { get; set; }

        public decimal? Energy { get; set; }

        public int? HeartRateAverage { get; set; }

        public int? HeartRateMax { get; set; }

        public decimal? PlannedDistanceInMeters { get; set; }

        public decimal? PlannedDuration { get; set; }

        public int? PowerAverage { get; set; }

        public int? PowerMax { get; set; }

        public decimal? TotalTimeInHours { get; set; }

        public string Type { get; set; }

        public decimal? VelocityAverage { get; set; }

        public decimal? VelocityMax { get; set; }

        public DateTime? WorkoutDate { get; set; }
    }
}