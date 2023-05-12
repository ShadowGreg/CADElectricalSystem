namespace Core {
    public enum ConsumerType {
        MOTOR,
        CONSUMER
    }

    public enum VoltageMode {
        TWO_HUNDRED_THIRTY = 230,
        FOUR_HUNDRED = 400
    }

    /// <summary>
    /// Техническая прослойка для заполнения полей потребителя
    /// </summary>
    public class ConsumerFiller: BaseConsumer {
        public ConsumerFiller() {
            base.LoadType = ConsumerType.MOTOR.ToString();
        }

        public ConsumerFiller(ConsumerType consumerType) {
            base.LoadType = consumerType.ToString();
        }

        public override void FillConsumerController() {
            IDGeneration();
            FillRatedPowerSquared();
            FillReactivePower();
            FillRatedCurrent();
            FillTan();
            FillStartingCurrent();
        }

        private void FillRatedPowerSquared() {
            RatedPowerSquared = TnCalculation.GetRatedPowerSquared(RatedElectricPower);
        }

        private void FillReactivePower() {
            ReactivePower = TnCalculation.GetReactivePower(RatedElectricPower, PowerFactor);
        }

        private void FillRatedCurrent() {
            if (base.LoadType == "MOTOR") {
                switch (PhaseNumber) {
                    case 1:
                        RatedCurrent =
                            TnCalculation.MoorSinglePhaseCurrentCalculation(RatedElectricPower, Voltage, PowerFactor,
                                EfficiencyFactor);
                        break;
                    case 3:
                        RatedCurrent = TnCalculation.MotorThreePhaseCurrentCalculation(RatedElectricPower, Voltage,
                            PowerFactor,
                            EfficiencyFactor);
                        break;
                }
            }
            else {
                switch (PhaseNumber) {
                    case 1:
                        RatedCurrent =
                            TnCalculation.SinglePhaseCurrentCalculation(RatedElectricPower, Voltage, PowerFactor);
                        break;
                    case 3:
                        RatedCurrent = TnCalculation.ThreePhaseCurrentCalculation(RatedElectricPower, Voltage,
                            PowerFactor);
                        break;
                }
            }
        }

        private void FillTan() => TanPowerFactor = TnCalculation.GetTan(PowerFactor);


        private void FillStartingCurrent() {
            StartingCurrent = TnCalculation.GetStartingCurrent(RatedCurrent, StartingCurrentMultiplicity);
        }

        public new string LoadType
        {
            get => base.LoadType;
            set
            {
                base.LoadType = value;
                FillConsumerController();
            }
        }

        public new double RatedElectricPower
        {
            get => base.RatedElectricPower;
            set
            {
                base.RatedElectricPower = value;
                FillConsumerController();
            }
        }

        public new double PowerFactor
        {
            get => base.PowerFactor;
            set
            {
                base.PowerFactor = value;
                FillConsumerController();
            }
        }

        public new double EfficiencyFactor
        {
            get => base.EfficiencyFactor;
            set
            {
                base.EfficiencyFactor = value;
                FillConsumerController();
            }
        }

        public new double StartingCurrentMultiplicity
        {
            get => base.StartingCurrentMultiplicity;
            set
            {
                base.StartingCurrentMultiplicity = value;
                FillConsumerController();
            }
        }

        public new int PhaseNumber
        {
            get => base.PhaseNumber;
            set
            {
                base.PhaseNumber = value;
                if (PhaseNumber == 1) {
                    Voltage = (double)VoltageMode.TWO_HUNDRED_THIRTY;
                }
                else {
                    Voltage = (double)VoltageMode.FOUR_HUNDRED;
                }

                FillConsumerController();
            }
        }
    }
}