using System.Reflection;
using Xunit;
using Akelon.Auchan.DocFactory.TemplateModels;
using System.Linq;

namespace Akelon.Aushan.DocFactory.Test
{
    public class SmetaVerifyTests
    {
        public class SmetaEntityTest
        {
            public string Number { get; set; }
            public string FeatureWorks { get; set; }
            public string TotalBySectionWorks { get; set; }
            public string EquipmentWorks { get; set; }
            public string TotalBySectionEquipmentWorks { get; set; }
            public string OtherWorks { get; set; }
            public string TotalBySectionOtherWorks { get; set; }
            public string TotalBySection { get; set; }
            public string Sale { get; set; }
            public string NDS { get; set; }
            public string InTotal { get; set; }
            public string InTotalRUB { get; set; }
            public string InTotalKOP { get; set; }
            public string CustomerJob { get; set; }
            public string Customer { get; set; }
            public string BuilderJob { get; set; }
            public string Builder { get; set; }
        }
        
        [Fact]
        public void VerifyPropertiesTest()
        {
            var testModel = new SmetaEntityTest();
            var originalModel = new SmetaEntity();

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
