using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Collections.Generic;
namespace Akelon.Auchan.DocFactory
{
    /// <summary>
    /// Класс для работы с Word документами
    /// </summary>
    public class WordHandler
    {
        /// <summary>
        /// Пустой шаблон
        /// </summary>
        private MemoryStream _template;

        /// <summary>
        /// Входящие данные
        /// </summary>
        private Dictionary<string, string> _document;
        
        public WordHandler(Dictionary<string, string> document,  byte[] resourceTemplate)
        {
            _document = document;
            _template = StreamHandler.AddResourceToMemoryStream(resourceTemplate);
        }

        /// <summary>
        /// Выполнить замену стандартных ключей в шаблоне на данные из модели
        /// </summary>
        /// <returns>Заполненный шаблон</returns>
        public MemoryStream ReplaceTexts()
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open(_template, true))
            {
               
                MainDocumentPart mainPart = doc.MainDocumentPart;

                if (mainPart == null)
                {
                    mainPart = doc.AddMainDocumentPart();
                }
                var document = mainPart.Document;


                if (document == null)
                    return _template;

                var textDocument = new Text(document.InnerText);

                foreach (var text in document.Descendants<Text>())
                {
                    if (text.Text.Contains(Placeholders.TextPlaceholderTag))
                        text.Text = text.Text.Replace(Placeholders.TextPlaceholderTag, "");
                    
                    foreach (var replace in _document)
                    {
                        if (text.Text == replace.Key)
                        {
                            text.Text = text.Text.Replace(replace.Key, replace.Value);
                        }
                    }
                }

                _template.Position = 0;
                return _template;             

            }
        }
    }
}
