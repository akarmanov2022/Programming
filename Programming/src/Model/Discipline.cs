using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    public class Discipline
    {
        private int _audienceNumber;

        public Discipline()
        {
        }

        public Discipline(string titleName, int audienceNumber, string teacherName)
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
            set
            {
                AssertOnPositiveValue(value, nameof(AudienceNumber));
                _audienceNumber = value;
            }
        }
    }
}