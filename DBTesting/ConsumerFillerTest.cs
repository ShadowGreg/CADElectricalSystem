using System.Runtime.Serialization.Formatters.Binary;
using BDTest;
using Core;

namespace DBTesting;

public class ConsumerFillerTest {
    private readonly BaseProjectedObject _baseProjectedObject = new();
    private ConsumerFiller _consumerFiller;

    [Test]
    public void Creation_Class_Instance_With_Load_Type_Motor_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        
        // Assert
        double actualRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(actualRatedCurrent, Is.EqualTo(expectedRatedCurrent));
    }

    [Test]
    public void Change_The_Load_Type_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstRatedCurrent = _consumerFiller.RatedCurrent;
        
        // Act
        _consumerFiller.LoadType = ConsumerType.CONSUMER.ToString();
        
        // Assert
        double secondRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_RatedElectricPower_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstRatedCurrent = _consumerFiller.RatedCurrent;
        
        // Act
        _consumerFiller.RatedElectricPower = 0.75;
        
        // Assert
        double secondRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_PowerFactor_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstRatedCurrent = _consumerFiller.RatedCurrent;
        
        // Act
        _consumerFiller.PowerFactor = 0.5;
        
        // Assert
        double secondRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    [Test]
    public void Change_The_EfficiencyFactor_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstRatedCurrent = _consumerFiller.RatedCurrent;
        
        // Act
        _consumerFiller.EfficiencyFactor = 0.5;
        
        // Assert
        double secondRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    
    [Test]
    public void Change_The_PhaseNumber_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstRatedCurrent = _consumerFiller.RatedCurrent;
        
        // Act
        _consumerFiller.PhaseNumber = 1;
        
        // Assert
        double secondRatedCurrent = _consumerFiller.RatedCurrent;
        Assert.That(secondRatedCurrent, Is.Not.EqualTo(firstRatedCurrent));
    }
    
    
    [Test]
    public void Change_The_StartingCurrentMultiplicity_The_Rated_Current_Is_Calculated_Test() {
        // Arrange
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        double firstStartingCurrent = _consumerFiller.StartingCurrent;
        
        // Act
        _consumerFiller.StartingCurrentMultiplicity = 7;
        
        // Assert
        double secondStartingCurrent = _consumerFiller.StartingCurrent;
        Assert.That(secondStartingCurrent, Is.Not.EqualTo(firstStartingCurrent));
    }
    
    [Test]
    public void reload_consumer_test() {
        _consumerFiller = new ConsumerFiller(ConsumerType.MOTOR)
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
        _consumerFiller.FillConsumerController();
        ConsumerFiller first = _consumerFiller;
        _baseProjectedObject.BaseCons.Add(first);
        _baseProjectedObject.SaveChanges();

        _consumerFiller.LoadType = ConsumerType.CONSUMER.ToString();
        _consumerFiller.RatedElectricPower = 300;
        
        _baseProjectedObject.BaseCons.Add(_consumerFiller);
        _baseProjectedObject.SaveChanges();

        var data = _baseProjectedObject.BaseCons.ToList();

        Assert.IsNotNull(data);
        foreach (ConsumerFiller item in data) {
            _baseProjectedObject.RemoveRange(item);
        }

        _baseProjectedObject.SaveChanges();
    }
}