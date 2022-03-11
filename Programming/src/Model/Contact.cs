using System;

namespace Programming.Model
{
    public class Contact
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreateDate { get; set; }

        public Contact(string name, string phoneNumber, DateTime createDate)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
        }

        public Contact()
        {
        }
    }
}