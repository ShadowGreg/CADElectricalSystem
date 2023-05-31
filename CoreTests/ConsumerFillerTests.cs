using Core;
using NUnit.Framework;

namespace CoreTests {
    [TestFixture]
    public class ConsumerFillerTests {
        private ConsumerFiller _consumer;

        [Test]
        public void To_Create_A_Consumer_Entity_Test() {
            // Arrange
            _consumer = new ConsumerFiller(ConsumerType.MOTOR)
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
            const double expected = 19.63877742064297d;

            // Act
            _consumer.FillConsumerController();


            // Assert
            double actual = _consumer.RatedCurrent;
            Assert.AreEqual(expected, actual);
        }
        
        
    }
}