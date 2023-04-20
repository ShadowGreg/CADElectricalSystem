namespace CADElectricalSystem.Model.physicalQuantities;

public abstract class IDoubleable
{
    private readonly double _value;

    protected IDoubleable(double value)
    {
        _value = value;
    }

    public double getValue()
    {
        return _value;
    }
    
    public override string ToString() => _value.ToString();
}