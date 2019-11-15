using System.IO;
using System;
using System.Resources;
using System.Reflection;

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
        public static byte[] GetRecourceForTemplate(this TemplateType value)
        {                        

            switch (value)
            {
                case TemplateType.DefectVed:
                    return Properties.Resources.defect_ved;

                case TemplateType.Zakaz:
                    return Properties.Resources.order;

                case TemplateType.Smeta:
                    return Properties.Resources.Smeta;

                case TemplateType.TechAct:
                    return Properties.Resources.TechnAct; // Path.Combine(path, @"AkelonDocFactory\Resources\TechnAct.docx");

                default:
                    return new byte[0];
            }
            
        }

    }
}
