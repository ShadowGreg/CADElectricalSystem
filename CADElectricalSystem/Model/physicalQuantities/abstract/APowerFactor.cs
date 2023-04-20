using CADElectricalSystem.Model.physicalQuantities.Values;

namespace CADElectricalSystem.Model.physicalQuantities;

public abstract class APowerFactor : IDoubleable
{
    protected APowerFactor(double value) : base(value)
    {
    }

    public abstract PowerFactor getTanPowerFactor();
}