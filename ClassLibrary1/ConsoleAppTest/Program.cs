using Akelon.Auchan.DocFactory;
using Akelon.Auchan.DocFactory.TemplateModels;
using System.IO;
using System;


namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаем тип шаблона
            TemplateSource.TemplateType typedoc = TemplateSource.TemplateType.DefectVed;

            //куда будет сохраняться + как называться
            string outPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources", typedoc.ToString() + "_result.docx");

            var DefVed = new DefectVedEntity 
            {
                Number = "9999",
                RequestName =  "003 Ашан Рязанский" ,
                RequestAddress = "429004 г.Москва, рязанский пр-т, д.2, корп. 2" ,
                CreateDate = "11.12.2018" ,
                RoomName = "Торговая галерея - Торговая площадка, эт. 1 в осях Д-Е и в осях 40-42" ,
                EquipmentName = "Воздушный компрессор GA11 7,5-10bar" ,
                RoomNumber = "1111" ,
                EquipmentNumber = "22222" ,
                Defects = "Неустойчивая работа, посторонний шум, частые остановки" ,
                Reasons = "Физический износ" ,
                FeatureWorks = "Провести ремонт, Установить уплотнения, Заменить подшипники" ,
                EquipmentWorks = "Подшипники, Набор уплотнений, Набор для капремонта" ,
                TimeDelivery = "14 календарных дней" ,
                TimeRepair = "5 календарных дней" ,
                Annex = "2018-12-11 001 Photo" ,                
                CustomerJob = "Разработчик" ,
                Customer = "Иванов Иван" ,
                BuilderJob = "Тестировщик" ,
                Builder = "Петров Петр" 
            };

            var generator = new GeneratorDocuments();
            try           
            {
                
                var  dictDoc = DefVed.GetDictionaryProperties();

                generator.GenerateReportToWord(typedoc, outPath, dictDoc);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
