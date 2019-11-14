using System.IO;

namespace Akelon.Auchan.DocFactory
{
    public static class TemplateSource
    {
        /// <summary>
        /// Путь к шаблонам
        /// </summary>
        public enum TemplateType
        {
            /// <summary>
            /// Дефектная ведомость
            /// </summary>
            DefectVed = 0,

            /// <summary>
            /// Заказ
            /// </summary>
            Zakaz = 1,

            /// <summary>
            /// Смета
            /// </summary>
            Smeta = 2,

            /// <summary>
            /// Технический акт
            /// </summary>
            TechAct = 3
        }

        /// <summary>
        /// Получить путь для типа шаблона
        /// </summary>
        public static string GetPathTemplate(this TemplateType value)
        {            
            //string path = Path.Combine(Path.GetFullPath(@"..\..\..\"), "Resources");
            
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            switch (value)
            {
                case TemplateType.DefectVed:
                    return Path.Combine(path, @"AkelonDocFactory\Resources\defect_ved.docx");

                case TemplateType.Zakaz:
                    return Path.Combine(path, @"AkelonDocFactory\Resources\Order.docx");

                case TemplateType.Smeta:
                    return Path.Combine(path, @"AkelonDocFactory\Resources\Smeta.docx");

                case TemplateType.TechAct:
                    return Path.Combine(path, @"AkelonDocFactory\Resources\TechnAct.docx");

                default:
                    return null;
            }
        }

    }
}
