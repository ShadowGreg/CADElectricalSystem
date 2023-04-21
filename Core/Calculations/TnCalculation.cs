using System;

namespace Core {
    public static class TnCalculation {
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