using Xunit;
using AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Tests
{
    public class ClassAdapterTests
    {
        [Fact()]
        public void AddTest()
        {
            ClassAdapter adapter = new ClassAdapter();
            string expectedItem = "expected item";
            adapter.Add(expectedItem);
            Assert.Equal(expectedItem, adapter.Get(0));
        }

        [Fact()]
        public void RemoveTest()
        {
            ClassAdapter adapter = new ClassAdapter();
            string expectedItem = "expected item";
            adapter.Add(expectedItem);
            adapter.Remove(expectedItem);
            Assert.Throws<ArgumentOutOfRangeException>(()=>adapter.Get(0));
        }
    }
}