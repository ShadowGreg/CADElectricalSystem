using System.Runtime.Serialization.Formatters.Binary;
using BDTest;
using Core;

namespace DBTesting;

public class ConsumerFillerTest {
    private readonly Class1 cl = new();
    private ConsumerFiller bc;

    [Test]
    public void Creation_Class_Instance_With_Load_Type_Motor_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test",
            MechanismName = "Test",
            LoadType = "Test",
            StartingCurrentMultiplicity = 1.5,
            RatedElectricPower = 12,
            UsageFactor = 1,
            PowerFactor = 0.883,
            EfficiencyFactor = 1,
            PhaseNumber = 3,
            NumberElectricalReceivers = 1,
            HoursWorkedPerYear = 1200,
            LocationEquipmentInstallation = "Test",
            ClassificationEquipmentInstallation = "Test",
            Voltage = 400
        };
        const double expectedRatedCurrent = 19.63877742064297d;
        
        // Act
        bc.FillConsumerController();
        
        // Assert
        double actualRatedCurrent = bc.RatedCurrent;
        Assert.That(actualRatedCurrent, Is.EqualTo(expectedRatedCurrent));
    }

    [Test]
    public void Change_The_Load_Type_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstRatedCurrent = bc.RatedCurrent;
        
        // Act
        bc.LoadType = ConsumerType.CONSUMER.ToString();
        
        // Assert
        double secondRatedCurrent = bc.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_RatedElectricPower_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstRatedCurrent = bc.RatedCurrent;
        
        // Act
        bc.RatedElectricPower = 0.75;
        
        // Assert
        double secondRatedCurrent = bc.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_PowerFactor_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstRatedCurrent = bc.RatedCurrent;
        
        // Act
        bc.PowerFactor = 0.5;
        
        // Assert
        double secondRatedCurrent = bc.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_EfficiencyFactor_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstRatedCurrent = bc.RatedCurrent;
        
        // Act
        bc.EfficiencyFactor = 0.5;
        
        // Assert
        double secondRatedCurrent = bc.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    
    [Test]
    public void Change_The_PhaseNumber_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstRatedCurrent = bc.RatedCurrent;
        
        // Act
        bc.PhaseNumber = 1;
        
        // Assert
        double secondRatedCurrent = bc.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    
    [Test]
    public void Change_The_StartingCurrentMultiplicity_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Test1",
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
        double firstStartingCurrent = bc.StartingCurrent;
        
        // Act
        bc.StartingCurrentMultiplicity = 7;
        
        // Assert
        double secondStartingCurrent = bc.StartingCurrent;
        Assert.That(secondStartingCurrent, Is.Not.EqualTo(firstStartingCurrent));
    }
    
    [Test]
    public void reload_consumer_test() {
        bc = new ConsumerFiller(ConsumerType.MOTOR)
        {
            TechnologicalName = "Электродвигатель",
            LoadType = "Test",
            StartingCurrentMultiplicity = 7,
            RatedElectricPower = 12,
            UsageFactor = 1,
            PowerFactor = 0.98,
            EfficiencyFactor = 0.98,
            PhaseNumber = 3,
            NumberElectricalReceivers = 1,
            HoursWorkedPerYear = 1200,
            LocationEquipmentInstallation = "Test",
            ClassificationEquipmentInstallation = "Test",
        };
        bc.FillConsumerController();
        ConsumerFiller first = bc;
        cl.BaseCons.Add(first);
        cl.SaveChanges();

        bc.LoadType = ConsumerType.CONSUMER.ToString();
        bc.RatedElectricPower = 300;
        
        cl.BaseCons.Add(bc);
        cl.SaveChanges();

        var data = cl.BaseCons.ToList();

        Assert.IsNotNull(data);
        foreach (ConsumerFiller item in data) {
            cl.RemoveRange(item);
        }

        cl.SaveChanges();
    }
}