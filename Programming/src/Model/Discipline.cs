using System;

namespace Programming.Model
{
    public class Discipline
    {
        private int _audienceNumber;

        public Discipline()
        {
        }

        public Discipline(int audienceNumber, string titleName, string teacherName)
        {
            AudienceNumber = audienceNumber;
            TitleName = titleName;
            TeacherName = teacherName;
        }

        public string TitleName { get; set; }

        public string TeacherName { get; set; }

        public int AudienceNumber
        {
            get => _audienceNumber;
            set => _audienceNumber = value < 0 ? throw new ArgumentException($"AudienceNumber < 0: {value}") : value;
        }
    }
}