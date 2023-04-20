using CADElectricalSystem.Model.physicalQuantities;
using CADElectricalSystem.Model.physicalQuantities.Values;

namespace CADElectricalSystem.Model.calculators;

public static class Calculator
{
    public static PowerFactor getTan(double value)
    {
        return new PowerFactor(Math.Sqrt(1 - value * value) / value);
    }

    public static double getSinglePhaseNominalCurrent(APower powerFiled, AVoltage voltageFiled, APowerFactor factor)
    {
        return getNominalCurrent(powerFiled, voltageFiled, factor);
    }

    public static double getTherdPhaseNominalCurrent(APower powerFiled, AVoltage voltageFiled, APowerFactor factor)
    {
        return getNominalCurrent(powerFiled, voltageFiled, factor) / Math.Sqrt(3);
    }

    private static double getNominalCurrent(APower powerFiled, AVoltage voltageFiled, APowerFactor factor)
    {
        const int THOUTHEND = 1000;
        return powerFiled.getValue() * THOUTHEND / voltageFiled.getValue() / factor.getValue();
    }
}