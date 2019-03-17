using Xunit;
using PrototypePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Tests
{
    public class ShadowCopyConcreteTests
    {
        [Fact()]
        public void CloneTest_ValueType()
        {
            ShadowCopyConcrete concrete = new ShadowCopyConcrete("name","201066","address");
            var clone = concrete.Clone() as ShadowCopyConcrete;
            Assert.True(concrete.Name == clone.Name);
        }

        [Fact]
        public void CloneTest_ReferenceType()
        {
            ShadowCopyConcrete concrete = new ShadowCopyConcrete("name", "201066", "address");
            var clone = concrete.Clone() as ShadowCopyConcrete;
            clone.Address.PostalCode = "201000";
            clone.Address.DeliveryAddress = "delivery address";
            Assert.True(concrete.Address.DeliveryAddress == "delivery address"
                && concrete.Address.PostalCode == "201000");
        }
    }
}