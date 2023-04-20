using CADElectricalSystem.Model.physicalQuantities;

namespace CADElectricalSystem.Model.consumers;

public abstract class Consumer
{
    protected Consumer(APower power, AVoltage voltage, APowerFactor powerFactor, int phaseCount)
    {
        PowerFiled = power;
        VoltageFiled = voltage;
        Factor = powerFactor;
        PhaseCount = phaseCount;
    }

    protected APowerFactor Factor { get; set; }
    protected AVoltage VoltageFiled { get; set; }
    protected APower PowerFiled { get; set; }
    private int PhaseCount { get; set; }

    public APowerFactor getTanPowerFactor()
    {
        return Factor.getTanPowerFactor();
    }

    public abstract ARatedCurrent getNominalCurrent();
}