namespace CADElectricalSystem.Model.physicalQuantities;

public abstract class AVoltage : IDoubleable
{
    protected AVoltage(double value) : base(value)
    {
    }
}