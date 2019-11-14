using System.Collections.Generic;
using System.IO;

namespace Akelon.Auchan.DocFactory
{
    public class GeneratorDocuments
    {       
        public void GenerateReport(TemplateSource.TemplateType templateType, string outReportName, Dictionary<string, string> dictText)
        {
            string templateStringPath = templateType.GetPathTemplate();            
            var docx = new WordHandler(dictText, outReportName);

            try
            {
                var ms = docx.ReplaceTexts(templateStringPath);        
                StreamHandler.WriteMemoryStreamToDisk(ms, outReportName);
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
