using System.Reflection;
using Xunit;
using Akelon.Auchan.DocFactory.TemplateModels;
using System.Linq;

namespace Akelon.Aushan.DocFactory.Test
{
    public class OrderVerifyTests
    {
        public class OrderEntityTest
        {
            public string Number { get; set; }            
            public string ContractNumber { get; set; }
            public string ContractDate { get; set; }
            public string RequestName { get; set; }
            public string RequestAddress { get; set; }
            public string CreateDate { get; set; }
            public string RoomName { get; set; }
            public string EquipmentName { get; set; }
            public string RoomNumber { get; set; }
            public string EquipmentNumber { get; set; }
            public string FeatureWorks { get; set; }
            public string EquipmentWorks { get; set; }
            public string OtherWorks { get; set; }
            public string DateDeliveryStart { get; set; }
            public string DateDeliveryEnd { get; set; }
            public string DateWorksStart { get; set; }
            public string DateWorksEnd { get; set; }
            public string Annex { get; set; }
            public string CustomerJob { get; set; }
            public string Customer { get; set; }
            public string BuilderJob { get; set; }
            public string Builder { get; set; }
            public string CustomerAggrement { get; set; }
            public string BuilderAggreement { get; set; }
        }

        [Fact]
        public void VerifyPropertiesTest()
        {
            var testModel = new OrderEntityTest();
            var originalModel = new OrderEntity();

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
