using System;
using System.Collections.Generic;

namespace Akelon.Auchan.DocFactory
{
    /// <summary>
    /// Содержит логику создания документов
    /// </summary>
    public class GeneratorDocuments
    {
        /// <summary>
        /// Сгенерировать отчет в Word
        /// </summary>
        /// <param name="templateType">Вид шаблона</param>
        /// <param name="outReportName">Путь к выходному файлу</param>
        /// <param name="dictDoc">Заполненная модель данных</param>
        /// <returns></returns>
        public void GenerateReportToWord(TemplateSource.TemplateType templateType, string outReportName, Dictionary<string, string> dictDoc)
        {
            byte[] templateResource = templateType.GetRecourceForTemplate();

            try
            {
                var docx = new WordHandler(dictDoc, templateResource);
                var ms = docx.ReplaceTexts();

                StreamHandler.WriteMemoryStreamToDisk(ms, outReportName);
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
    }
}
