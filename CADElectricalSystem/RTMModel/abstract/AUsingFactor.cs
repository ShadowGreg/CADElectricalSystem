using CADElectricalSystem.Model.physicalQuantities;

namespace CADElectricalSystem.RTMModel.calculateEntities;

public abstract class UsingFactor : IDoubleable
{
    protected UsingFactor(double value) : base(value)
    {
    }
}