namespace OOP_Individual6;

public class AcceleratedDistanceCalculator : IDistanceCalculator
{
    private readonly double _speed;

    public double Speed
    {
        get => _speed;
        init
        {
            if (_speed < 0)
            {
                throw new ArgumentException("Скорость не может быть отрицательной!");
            }
            _speed = value;
        }
    }

    public double Acceleration { get; set; }

    public AcceleratedDistanceCalculator(double speed, double acceleration)
    {
        Speed = speed;
        Acceleration = acceleration;
    }

    public double Calculate(double time)
    {
        return Speed + Acceleration * time;
    }
}