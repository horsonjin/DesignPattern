using Xunit;
using PrototypePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Tests
{
    public class DeepCopyConcreteTests
    {
        [Fact()]
        public void CloneTest_ValueType()
        {
            DeepCopyConcrete concrete = new DeepCopyConcrete("name", "201066", "address");
            var clone = concrete.Clone() as DeepCopyConcrete;
            Assert.True(concrete.Name==clone.Name);
        }

        [Fact()]
        public void CloneTest_ReferenceType()
        {
            DeepCopyConcrete concrete = new DeepCopyConcrete("name", "201066", "address");
            var clone = concrete.Clone() as DeepCopyConcrete;
            clone.Address.PostalCode = "201000";
            clone.Address.DeliveryAddress = "delivery address";
            Assert.True(concrete.Address.DeliveryAddress != "delivery address"
                && concrete.Address.PostalCode != "201000");
        }

    }
}