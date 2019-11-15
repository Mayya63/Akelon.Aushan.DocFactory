
namespace Akelon.Auchan.DocFactory.TemplateModels
{
    /// <summary>
    /// Шаблон дефектной ведомости
    /// </summary>
    public class DefectVedEntity : BaseEntity 
    {
        /// <summary>
        /// Автоматический номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Наименование заявки
        /// </summary>
        public string RequestName { get; set; }

        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string RequestAddress { get; set; }

        /// <summary>
        /// Дата оформления
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// Наименование помещения
        /// </summary>
        public string RoomName { get; set; }

        /// <summary>
        /// Наименование Оборудования 
        /// </summary>
        public string EquipmentName { get; set; }

        /// <summary>
        /// Наименование помещения
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Номер Оборудования 
        /// </summary>
        public string EquipmentNumber { get; set; }

        /// <summary>
        /// Выявленные дефекты
        /// </summary>
        public string Defects { get; set; }

        /// <summary>
        /// Причины выявленных дефектов
        /// </summary>
        public string Reasons { get; set; }

        /// <summary>
        /// Требуемые работы
        /// </summary>
        public string FeatureWorks { get; set; }

        /// <summary>
        /// Требуемые работы по оборудованию
        /// </summary>
        public string EquipmentWorks { get; set; }

        /// <summary>
        /// Сроки поставки запасных частей/материалов 
        /// </summary>
        public string TimeDelivery { get; set; }

        /// <summary>
        /// Сроки ремонтных работ
        /// </summary>
        public string TimeRepair { get; set; }

        /// <summary>
        /// Приложение
        /// </summary>
        public string Annex { get; set; }

        /// <summary>
        /// Должность заказчика
        /// </summary>
        public string CustomerJob { get; set; }

        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// Должность порядчика
        /// </summary>
        public string BuilderJob { get; set; }

        /// <summary>
        /// ФИО подрядчика
        /// </summary>
        public string Builder { get; set; }
       

    }
}
