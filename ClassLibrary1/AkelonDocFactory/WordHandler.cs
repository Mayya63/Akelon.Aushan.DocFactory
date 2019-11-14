using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using System.Collections.Generic;

namespace Akelon.Auchan.DocFactory
{
    public class WordHandler
    {

        private MemoryStream _template;
        private Dictionary<string, string> _newText;
        private string _outPath;


        public WordHandler( Dictionary<string, string> newText, string outPathName)
        {         
            _newText = newText;
            _outPath = outPathName;
        }

        public MemoryStream ReplaceTexts(string docTemplateFilename)
        {
            try
            {
                _template = StreamHandler.GetFileAsMemoryStream(docTemplateFilename);
            }
            catch (IOException)
            {
                throw;
            }
            using (WordprocessingDocument doc = WordprocessingDocument.Open(_template, true))
            {
                //doc.ChangeDocumentType(WordprocessingDocumentType.Document);

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
                    
                    foreach (var replace in _newText)
                    {
                        if (text.Text == replace.Key)
                        {
                            text.Text = text.Text.Replace(replace.Key, replace.Value);
                        }
                    }
                }

                _template.Position = 0;
                return _template;

                // document.Save();                

            }
        }
    }
}
