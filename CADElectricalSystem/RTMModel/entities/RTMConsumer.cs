using CADElectricalSystem.Model.physicalQuantities;

namespace CADElectricalSystem.RTMModel.entites;

public class RTMConsumer : ARTMConsumer
{
    public RTMConsumer(APower power, AVoltage voltage, APowerFactor powerFactor, int phaseCount, string name,
        string technologicalID) : base(power, voltage, powerFactor, phaseCount, name, technologicalID)
    {
    }

    public override ARatedCurrent getNominalCurrent()
    {
        throw new NotImplementedException();
    }
}