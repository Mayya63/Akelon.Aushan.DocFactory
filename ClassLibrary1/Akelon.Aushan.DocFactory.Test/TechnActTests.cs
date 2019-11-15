using System.Reflection;
using Xunit;
using Akelon.Auchan.DocFactory.TemplateModels;
using System.Linq;

namespace Akelon.Aushan.DocFactory.Test
{
    public class TechnActTests
    {
        public class TechnActEntityTest
        {
            public string DayRequest { get; set; }
            public string MonthRequest { get; set; }
            public string YearRequest { get; set; }
            public string RequestName { get; set; }
            public string RequestAddress { get; set; }
            public string Customer { get; set; }
            public string Reasons { get; set; }
            public string Builder { get; set; }
            public string Comments { get; set; }
            public string TimeStart { get; set; }
            public string TimeEnd { get; set; }
            public string RoomName { get; set; }
            public string RoomNumber { get; set; }
            public string CompleteWorks { get; set; }
            public string CompleteEquipment { get; set; }
            public string Annex { get; set; }
            public string SpecialInstruments { get; set; }
            public string ConditionEquipment { get; set; }
            public string CustomerJob { get; set; }
            public string BuilderJob { get; set; }
        }

        [Fact]
        public void VerifyPropertiesTest()
        {
            var testModel = new TechnActEntityTest();
            var originalModel = new TechnActEntity();

            PropertyInfo[] propertiesTest = testModel.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo[] properties = originalModel.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            foreach (var prop in propertiesTest)
            {
                var t = properties.Where(x => x.Name == prop.Name).ToList();
                Assert.True(t.Count > 0);
            }
        }
    }
}
