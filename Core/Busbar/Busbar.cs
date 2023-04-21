using System.Collections.Generic;

namespace Core.Busbar {
    public class BaseElement {
        /// <summary>
        /// Уникальный идентификационный номер ID объекта выше по уровню иерархии
        /// </summary>
        public string OwnerId { get; set; } = "";

        /// <summary>
        /// Уникальный идентификационный номер ID
        /// </summary>
        public string ID { get; set; } = "";

        /// <summary>
        /// Наименованеи объекта
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int SequentialNumber { get; set; } = -1;
    }

    public class Busbar: BaseElement {
        /// <summary>
        /// Фидеры на шине
        /// </summary>
        public List<Feeder> Feeders { get; set; } = null;

        /// <summary>
        /// Установленная мощность на шине
        /// </summary>
        public double InstalledCapacity { get; set; } = -1;

        /// <summary>
        /// Реактивная мощность на шине
        /// </summary>
        public double ReactivePower { get; set; } = -1;

        /// <summary>
        /// Номинальный ток на шине
        /// </summary>
        public double DesignCurrent { get; set; } = -1;

        /// <summary>
        /// Расчётный коэффициент мощности на шине
        /// </summary>
        public double PowerFactor { get; set; } = -1;

        /// <summary>
        /// Коэффициент использвования на шине
        /// </summary>
        public double UtilizationFactor { get; set; } = -1;

        /// <summary>
        /// Расчётный ток однофазного короткого замыкания
        /// </summary>
        public double SinglePhaseShortCircuitCurrent { get; set; } = -1;

        /// <summary>
        /// Расчётный ток двухфазного короткого замыкания
        /// </summary>
        public double TwoPhaseShortCircuitCurrent { get; set; } = -1;

        /// <summary>
        /// Расчётный ток трёхфазного короткого замыкания
        /// </summary>
        public double ThreePhaseShortCircuitCurrent { get; set; } = -1;

        /// <summary>
        /// Шина щита
        /// </summary>
        public Busbar() => ID = IdGenerator.Generate();
    }

    public class Feeder: BaseElement {
        public ConsumerFiller Consumer { get; set; } = null;
        public SupplyLine SupplyLine { get; set; } = null;
        public CircuitBreaker CircuitBreaker { get; set; } = null;
        public Contacrtor Contactor { get; set; } = null;

        /// <summary>
        /// Фидер в щите
        /// </summary>
        public Feeder() => ID = IdGenerator.Generate();
    }

    public class Contacrtor: BaseElement {
        public string Type { get; set; } = "";
        public int NominalCurrent { get; set; } = -1;

        /// <summary>
        /// Контактор на фидере
        /// </summary>
        public Contacrtor() => ID = IdGenerator.Generate();
    }

    public class CircuitBreaker: BaseElement {
        public int SeriesRatedCurrent { get; set; } = -1;
        public char TypeTrippingCurve { get; set; } = 'C';

        public int RatedSetPointCurrent { get; set; } = -1;
        /*TODO В последующем добавить Диф автоматат
         с дополнительными параметрами*/

        /// <summary>
        /// Автоматический выключатель на фидере
        /// </summary>
        public CircuitBreaker() => ID = IdGenerator.Generate();
    }

    public class SupplyLine: BaseElement {
        public List<PowerCable> PowerCables { get; set; } = null;

        /// <summary>
        /// Линия электроснабжения
        /// </summary>
        public SupplyLine() => ID = IdGenerator.Generate();
    }

    public class PowerCable: BaseElement {
        /// <summary>
        /// Марка кабеля
        /// </summary>
        public string CableBrand { get; set; } = "";

        /// <summary>
        /// Количество жил в кабеле
        /// </summary>
        public int NumberCores { get; set; } = -1;

        /// <summary>
        /// Сечение кабеля мм.кв.
        /// </summary>
        public double CrossSection { get; set; } = -1;

        /// <summary>
        /// Длина кабеля
        /// </summary>
        public double Length { get; set; } = -1;

        /// <summary>
        /// Кабель линии электроснабжения
        /// </summary>
        public PowerCable() => ID = IdGenerator.Generate();
    }
}