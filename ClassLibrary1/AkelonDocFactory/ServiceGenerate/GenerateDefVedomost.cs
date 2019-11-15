using Akelon.Auchan.DocFactory.TemplateModels;
using System.Collections.Generic;

namespace Akelon.Auchan.DocFactory.ServiceGenerate
{
    public class GenerateDefVedomost : GeneratorDocuments
    {
        private Dictionary<string, string> _doc;
        
        public GenerateDefVedomost(DefectVedEntity doc)
        {
            _doc = doc.GetDictionaryProperties();
        }
        
    }
}
