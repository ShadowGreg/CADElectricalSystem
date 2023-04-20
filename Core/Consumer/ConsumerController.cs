using System;

namespace Core {
    public class Busbar {
        
    }

    public enum ConsumerType {
        MOTOR,
        CONSUMER
    }

    public class ConsumerController: BaseConsumer {
        public ConsumerController() {
            MechanismName = ConsumerType.MOTOR.ToString();
        }

        public ConsumerController(ConsumerType consumerType) {
            MechanismName = consumerType.ToString();
        }

        public void FillConsumerController() {
            IDGeneration();
            FillRatedPowerSquared();
            FillReactivePower();
            FillRatedCurrent();
            FillTan();
            FillStartingCurrent();
        }

        private void FillRatedPowerSquared() {
            RatedPowerSquared = TNCalculation.GetRatedPowerSquared(RatedElectricPower);
        }

        private void FillReactivePower() {
            ReactivePower = TNCalculation.GetReactivePower(RatedElectricPower, PowerFactor);
        }

        private void FillRatedCurrent() {
            if (MechanismName == "MOTOR") {
                switch (PhaseNumber) {
                    case 1:
                        Voltage = 220;
                        RatedCurrent =
                            TNCalculation.MoorSinglePhaseCurrentCalculation(RatedElectricPower, Voltage, PowerFactor,
                                EfficiencyFactor);
                        break;
                    case 3:
                        Voltage = 380;
                        RatedCurrent = TNCalculation.MotorThreePhaseCurrentCalculation(RatedElectricPower, Voltage,
                            PowerFactor,
                            EfficiencyFactor);
                        break;
                }
            }
            else {
                switch (PhaseNumber) {
                    case 1:
                        Voltage = 220;
                        RatedCurrent =
                            TNCalculation.SinglePhaseCurrentCalculation(RatedElectricPower, Voltage, PowerFactor);
                        break;
                    case 3:
                        Voltage = 380;
                        RatedCurrent = TNCalculation.ThreePhaseCurrentCalculation(RatedElectricPower, Voltage,
                            PowerFactor);
                        break;
                }
            }
        }

        private void FillTan() => TanPowerFactor = TNCalculation.GetTan(PowerFactor);


        private void FillStartingCurrent() {
            StartingCurrent = TNCalculation.GetStartingCurrent(RatedCurrent, StartingCurrentMultiplicity);
        }
    }

    public static class TNCalculation {
        public static double GetRatedPowerSquared(double ratedElectricPower) {
            return ratedElectricPower * ratedElectricPower;
        }

        public static double GetTan(double cos) {
            return Math.Sin(Math.Acos(cos)) / cos;
        }

        public static double GetReactivePower(double ratedElectricPower, double powerFactor) {
            return ratedElectricPower * GetTan(powerFactor);
        }

        public static double ThreePhaseCurrentCalculation(double ratedElectricPower,
            double voltage, double powerFactor) {
            return ratedElectricPower * 1000 / (voltage * 1.73 * powerFactor);
        }

        public static double MotorThreePhaseCurrentCalculation(double ratedElectricPower,
            double voltage, double powerFactor, double efficiencyFactor) {
            return ThreePhaseCurrentCalculation(ratedElectricPower, voltage, powerFactor) / efficiencyFactor;
        }

        public static double SinglePhaseCurrentCalculation(double ratedElectricPower, double voltage,
            double powerFactor) {
            return ratedElectricPower * 1000 / (voltage * powerFactor);
        }

        public static double MoorSinglePhaseCurrentCalculation(double ratedElectricPower, double voltage,
            double powerFactor, double efficiencyFactor) {
            return SinglePhaseCurrentCalculation(ratedElectricPower, voltage, powerFactor) / efficiencyFactor;
        }

        public static double GetStartingCurrent(double ratedCurrent, double startingCurrentMultiplicity) {
            return ratedCurrent * startingCurrentMultiplicity;
        }
    }
}