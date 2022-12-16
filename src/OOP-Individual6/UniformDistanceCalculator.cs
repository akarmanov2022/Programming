namespace OOP_Individual6;

public class UniformDistanceCalculator : IDistanceCalculator
{
    private double _speed;

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

    public UniformDistanceCalculator(double speed)
    {
        Speed = speed;
    }

    public double Calculate(double time)
    {
        return Speed * time;
    }
}