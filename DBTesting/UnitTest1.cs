using BDTest;
using Core;

namespace DBTesting;

public class Tests {
    private Class1 cl = new();
    private ConsumerController bc;

    [Test]
    public void motor_consumer_test() {
        bc = new ConsumerController(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test",
            MechanismName = "Test",
            LoadType = "Test",
            StartingCurrentMultiplicity = 1.5,
            RatedElectricPower = 12,
            UsageFactor = 1,
            PowerFactor = 0.98,
            EfficiencyFactor = 0.98,
            PhaseNumber = 3,
            NumberElectricalReceivers = 1,
            HoursWorkedPerYear = 1200,
            LocationEquipmentInstallation = "Test",
            ClassificationEquipmentInstallation = "Test",
            Voltage = 400
            //RatedPowerSquared = 12,
            //ReactivePower = 12,
            //RatedCurrent = 12,
            //StartingCurrent = 12
        };
        bc.FillConsumerController();
        cl.BaseCons.Add(bc);
        cl.SaveChanges();

        var data = cl.BaseCons.ToList();

        Assert.IsNotNull(data);
        foreach (BaseConsumer item in data) {
            cl.RemoveRange(item);
        }

        cl.SaveChanges();
    }

    [Test]
    public void another_consumer_test() {
        bc = new ConsumerController(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
            LoadType = "Test",
            StartingCurrentMultiplicity = 1.5,
            RatedElectricPower = 12,
            UsageFactor = 1,
            PowerFactor = 0.98,
            EfficiencyFactor = 0.98,
            PhaseNumber = 3,
            NumberElectricalReceivers = 1,
            HoursWorkedPerYear = 1200,
            LocationEquipmentInstallation = "Test",
            ClassificationEquipmentInstallation = "Test",
            Voltage = 400
        };
        bc.FillConsumerController();
        cl.BaseCons.Add(bc);
        bc = new ConsumerController(ConsumerType.CONSUMER)
        {
            TechnologicalName = "Test2",
            LoadType = "Test",
            StartingCurrentMultiplicity = 1.5,
            RatedElectricPower = 12,
            UsageFactor = 1,
            PowerFactor = 0.98,
            EfficiencyFactor = 0.98,
            PhaseNumber = 3,
            NumberElectricalReceivers = 1,
            HoursWorkedPerYear = 1200,
            LocationEquipmentInstallation = "Test",
            ClassificationEquipmentInstallation = "Test",
            Voltage = 400
        };
        bc.FillConsumerController();
        cl.BaseCons.Add(bc);
        cl.SaveChanges();

        var data = cl.BaseCons.ToList();

        Assert.IsNotNull(data);
        foreach (BaseConsumer item in data) {
            cl.RemoveRange(item);
        }

        cl.SaveChanges();
    }
}