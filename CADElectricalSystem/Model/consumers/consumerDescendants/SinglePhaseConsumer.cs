using CADElectricalSystem.Model.calculators;
using CADElectricalSystem.Model.physicalQuantities;
using CADElectricalSystem.Model.physicalQuantities.Values;

namespace CADElectricalSystem.Model.consumers.consumerDescendants;

public class SinglePhaseConsumer : Consumer
{
    private static readonly int _elektriFaaside = 1;

    public SinglePhaseConsumer(APower power, AVoltage voltage, APowerFactor powerFactor) : base(power,
        voltage, powerFactor, _elektriFaaside)
    {
    }


    public override ARatedCurrent getNominalCurrent()
    {
        return new RatedCurrent(Calculator.getSinglePhaseNominalCurrent(PowerFiled, VoltageFiled, Factor));
    }
}