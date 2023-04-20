using CADElectricalSystem.Model.consumers;
using CADElectricalSystem.Model.physicalQuantities;

namespace CADElectricalSystem.RTMModel;

public abstract class ARTMConsumer : Consumer
{
    protected string Name { get; set; }
    protected string TechnologicalId { get; set; }

    protected ARTMConsumer(APower power, AVoltage voltage, APowerFactor powerFactor, int phaseCount, string name,
        string technologicalID) : base(power, voltage, powerFactor, phaseCount)
    {
        Name = name;
        TechnologicalId = technologicalID;
    }
}