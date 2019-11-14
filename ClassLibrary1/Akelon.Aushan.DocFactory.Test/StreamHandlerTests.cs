using Akelon.Auchan.DocFactory;
using Xunit;
using System.IO;
using System;

namespace Akelon.Aushan.DocFactory.Test
{
    public class StreamHandlerTests
    {
        private static string _testFilename = @"D:\\1.docx";
        private static string _filename = TemplateSource.GetPathTemplate(TemplateSource.TemplateType.DefectVed);

        [Fact]    
        
        public void GetFileFailtest()
        {
            Assert.Throws<IOException>(() => StreamHandler.GetFileAsMemoryStream(_testFilename));

        }
        [Fact]
        public void InvalidNameFile()
        {
            
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string _filename = Path.Combine(startupPath, @"AkelonDocFactory\Resources\defect_ved.docx");
            
            // assert
            Assert.True(File.Exists(_filename));
           

        }
    }
}
