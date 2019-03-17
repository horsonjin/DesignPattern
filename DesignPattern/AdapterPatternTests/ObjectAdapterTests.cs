using Xunit;
using AdapterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Tests
{
    public class ObjectAdapterTests
    {
        [Fact()]
        public void AddTest()
        {
            string expectedItem = "Expected Item";
            ObjectAdapter adapter = new ObjectAdapter();
            adapter.Add(expectedItem);
            Assert.Equal(expectedItem, adapter.Get(0));
        }

        [Fact()]
        public void RemoveTest()
        {
            string expectedItem = "Expected Item";
            ObjectAdapter adapter = new ObjectAdapter();
            adapter.Add(expectedItem);
            adapter.Remove(expectedItem);
            Assert.Throws<ArgumentOutOfRangeException>(()=>adapter.Get(0));
        }
    }
}