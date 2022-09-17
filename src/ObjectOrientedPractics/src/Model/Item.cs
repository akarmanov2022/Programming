using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private string _name;
        private string _info;
        private double _cost;

        public Item(string name, string info, double cost)
        {
            Id = IdGenerator.GetNextId();
            _name = name;
            _info = info;
            _cost = cost;
        }   

        public int Id { get; }

        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertOnStringLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                Validator.AssertOnStringLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                Validator.AssertOnPositiveValue(value, 0 , 100000, nameof(Name));
                _cost = value;
            }
        }
    }
}