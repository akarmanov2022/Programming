using System;

namespace Programming.Model
{
    public class Discipline
    {
        private int _audienceNumber;

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public Discipline()
        {
        }

        public Discipline(int audienceNumber, string name, string teacherName)
        {
            AudienceNumber = audienceNumber;
            Name = name;
            TeacherName = teacherName;
        }

        public int AudienceNumber
        {
            get => _audienceNumber;
            set => _audienceNumber = value < 0 ? throw new AggregateException($"AudienceNumber < 0: {value}") : value;
        }
    }
}