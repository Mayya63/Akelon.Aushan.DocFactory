
namespace Akelon.Auchan.DocFactory.TemplateModels
{
    /// <summary>
    /// Шаблон сметы
    /// </summary>
    public class SmetaEntity : BaseEntity
    {
        /// <summary>
        /// Автоматический номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Работы
        /// </summary>
        public string FeatureWorks { get; set; }

        /// <summary>
        /// Итого по Разделу – Работы
        /// </summary>
        public string TotalBySectionWorks { get; set; }

        /// <summary>
        /// Материалы
        /// </summary>
        public string EquipmentWorks { get; set; }

        /// <summary>
        /// Итого по Разделу – Материалы
        /// </summary>
        public string TotalBySectionEquipmentWorks { get; set; }

        /// <summary>
        /// Другие работы
        /// </summary>
        public string OtherWorks { get; set; }

        /// <summary>
        /// Итого по Разделу – Другие работы
        /// </summary>
        public string TotalBySectionOtherWorks { get; set; }
      
        /// <summary>
        /// Итого
        /// </summary>
        public string TotalBySection { get; set; }

        /// <summary>
        /// СКИДКА
        /// </summary>
        public string Sale { get; set; }

        /// <summary>
        /// НДС 
        /// </summary>
        public string NDS { get; set; }

        /// <summary>
        /// Всего с НДС
        /// </summary>
        public string InTotal { get; set; }

        /// <summary>
        /// Всего рублей
        /// </summary>
        public string InTotalRUB { get; set; }

        /// <summary>
        /// Всего копеек
        /// </summary>
        public string InTotalKOP { get; set; }

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

