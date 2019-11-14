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
            Assert.Throws<FileNotFoundException>(() => StreamHandler.GetFileAsMemoryStream(_testFilename));

        }
        [Fact]
        public void InvalidNameFile()
        {
            
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
           
            string _filenameDef = Path.Combine(startupPath, @"AkelonDocFactory\Resources\defect_ved.docx");
            string _filenameOrder = Path.Combine(startupPath, @"AkelonDocFactory\Resources\order.docx");
            string _filenameSmeta = Path.Combine(startupPath, @"AkelonDocFactory\Resources\Smeta.docx");
            string _filenameTech = Path.Combine(startupPath, @"AkelonDocFactory\Resources\TechnAct.docx");

            // assert
            Assert.True(File.Exists(_filenameDef));
            Assert.True(File.Exists(_filenameOrder));
            Assert.True(File.Exists(_filenameSmeta));
            Assert.True(File.Exists(_filenameTech));


        }
    }
}
