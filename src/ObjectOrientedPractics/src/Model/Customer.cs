using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private string _fullname;

        private string _address;
        
        public int Id { get; }

        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        public Customer(string fullname, string address)
        {
            Id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }
    }
}