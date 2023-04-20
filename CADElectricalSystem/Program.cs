// See https://aka.ms/new-console-template for more information

using CADElectricalSystem.Model.consumers;
using CADElectricalSystem.Model.consumers.consumerDescendants;
using CADElectricalSystem.Model.physicalQuantities;
using CADElectricalSystem.Model.physicalQuantities.Values;

APower template = new Power(12.3);
Console.WriteLine(template.getValue());
APowerFactor tepFactor = new PowerFactor(0.98);
Console.WriteLine(tepFactor.getTanPowerFactor());
Consumer fun = new ThreePhaseConsumer(new Power(12), new Voltage(380), new PowerFactor(0.85));
Consumer radio = new SinglePhaseConsumer(new Power(12), new Voltage(380), new PowerFactor(0.85));
Console.WriteLine(fun.getNominalCurrent());
Console.WriteLine(radio.getNominalCurrent());