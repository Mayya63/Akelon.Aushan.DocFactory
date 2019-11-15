
namespace Akelon.Auchan.DocFactory.TemplateModels
{
    /// <summary>
    /// Шаблон заказа
    /// </summary>
    public class OrderEntity : BaseEntity
    {
        /// <summary>
        /// Автоматический номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Номер договора
        /// </summary>
        public string ContractNumber { get; set; }

        /// <summary>
        /// Дата договора
        /// </summary>
        public string ContractDate { get; set; }

        /// <summary>
        /// Наименование заявки
        /// </summary>
        public string RequestName { get; set; }        
        
        
        /// <summary>
        /// Адрес магазина
        /// </summary>
        public string RequestAddress { get; set; }

        /// <summary>
        /// Дата создания
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
        /// Работы
        /// </summary>
        public string FeatureWorks { get; set; }
        
        /// <summary>
        /// Работы по оборудованию
        /// </summary>
        public string EquipmentWorks { get; set; }
        
        /// <summary>
        /// Другие работы
        /// </summary>
        public string OtherWorks { get; set; }

        /// <summary>
        /// Дата начала поставки запасных частей/материалов 
        /// </summary>
        public string DateDeliveryStart { get; set; }

        /// <summary>
        /// Дата завершения поставки запасных частей/материалов 
        /// </summary>
        public string DateDeliveryEnd { get; set; }

        /// <summary>
        /// Дата начала работ
        /// </summary>
        public string DateWorksStart { get; set; }

        /// <summary>
        /// Дата завершения работ
        /// </summary>
        public string DateWorksEnd { get; set; }
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

        /// <summary>
        /// ФИО согласующего заказчика
        /// </summary>
        public string CustomerAggrement { get; set; }

        /// <summary>
        /// ФИО согласующего подрядчика
        /// </summary>
        public string BuilderAggreement { get; set; }

    }
}
