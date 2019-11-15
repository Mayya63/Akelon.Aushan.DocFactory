using Akelon.Auchan.DocFactory;
using Xunit;
using System.IO;
using System;

namespace Akelon.Aushan.DocFactory.Test
{

    public class StreamHandlerTests
    {
        private static string _testFilename = @"D:\\1.docx";
        private static byte[] _filename = TemplateSource.GetRecourceForTemplate(TemplateSource.TemplateType.DefectVed);

        [Fact]        
        public void GetFileFailtest()
        {          
            Assert.True(StreamHandler.AddResourceToMemoryStream(_filename).Length > 0);
        }               
        
    }
}
