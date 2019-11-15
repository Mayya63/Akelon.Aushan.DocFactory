
namespace Akelon.Auchan.DocFactory.TemplateModels
{
    /// <summary>
    /// Шаблон сметы
    /// </summary>
    public class TechnActEntity : BaseEntity
    {
        /// <summary>
        /// Денб
        /// </summary>
        public string DayRequest { get; set; }

        /// <summary>
        /// Месяц
        /// </summary>
        public string MonthRequest { get; set; }

        /// <summary>
        /// Год
        /// </summary>
        public string YearRequest { get; set; }

        /// <summary>
        /// Наименование заявки
        /// </summary>
        public string RequestName { get; set; }

        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string RequestAddress { get; set; }

        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Причины
        /// </summary>
        public string Reasons { get; set; }

        /// <summary>
        /// ФИО подрядчика
        /// </summary>
        public string Builder { get; set; }

        /// <summary>
        /// Комментарии
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Время начала
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// Время завершения
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        /// Наименование помещения
        /// </summary>
        public string RoomName { get; set; }

        /// <summary>
        /// Наименование помещения
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Выполненные работы
        /// </summary>
        public string CompleteWorks { get; set; }

        /// <summary>
        /// Замененные части и / или использованные материалы
        /// </summary>
        public string CompleteEquipment { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public string Annex { get; set; }

        /// <summary>
        /// Спецсредства 
        /// </summary>
        public string SpecialInstruments { get; set; }

        /// <summary>
        /// Состояние оборудования после работ
        /// </summary>
        public string ConditionEquipment { get; set; }

        /// <summary>
        /// Должность заказчика
        /// </summary>
        public string CustomerJob { get; set; }
       
        /// <summary>
        /// ФИО подрядчика
        /// </summary>
        public string BuilderJob { get; set; }
    }
}
