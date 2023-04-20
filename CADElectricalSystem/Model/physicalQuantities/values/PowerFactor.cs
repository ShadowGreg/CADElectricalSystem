using CADElectricalSystem.Model.calculators;

namespace CADElectricalSystem.Model.physicalQuantities.Values;

public class PowerFactor : APowerFactor
{
    public PowerFactor(double value) : base(value)
    {
    }

    public override PowerFactor getTanPowerFactor()
    {
        return Calculator.getTan(getValue());
    }
    
}