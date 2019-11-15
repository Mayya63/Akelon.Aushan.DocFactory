using System.Reflection;
using Xunit;
using Akelon.Auchan.DocFactory.TemplateModels;
using System.Collections.Generic;
using System.Linq;

namespace Akelon.Aushan.DocFactory.Test
{
    public class VerifyEntityTests
    {
        public class TestDefVedEntity
        {
            public string Number { get; set; }
            public string RequestName { get; set; }
            public string RequestAddress { get; set; }
            public string CreateDate { get; set; }
            public string RoomName { get; set; }
            public string EquipmentName { get; set; }
            public string RoomNumber { get; set; }
            public string EquipmentNumber { get; set; }
            public string Defects { get; set; }
            public string Reasons { get; set; }
            public string FeatureWorks { get; set; }
            public string EquipmentWorks { get; set; }
            public string TimeDelivery { get; set; }
            public string TimeRepair { get; set; }
            public string Annex { get; set; }
            public string CustomerJob { get; set; }
            public string Customer { get; set; }
            public string BuilderJob { get; set; }
            public string Builder { get; set; }
        }
        
        [Fact]
        public void GetFileFailtest()
        {
            var testModel = new TestDefVedEntity();
            var originalModel = new DefectVedEntity();

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
