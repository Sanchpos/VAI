using System;
using System.Linq;
using Vai.Data.Models;
using Xunit;

namespace Tests
{
    public class Base64ReaderTest
    {
        private class TestClass
        {
            public string InnerRunTests { get; set; }
            private Lazy<Base64Field<TestClass, double[]>> runtestsLazy;
            public Base64Field<TestClass, double[]> RunTests
            {
                get
                {
                    if (runtestsLazy != null) return runtestsLazy.Value;
                    runtestsLazy = new Lazy<Base64Field<TestClass, double[]>>(
                        () => new Base64Field<TestClass, double[]>(this, nameof(InnerRunTests)));
                    return runtestsLazy.Value;
                }
            }
        }
        
        [Fact]
        public void ReadWriteTest()
        {
            var testObj = new TestClass();
            var expectedVal = new[] { 0.2, 0.45662, 84 };
            testObj.RunTests.Value = expectedVal;
            var actualValue = testObj.RunTests.Value;
            Assert.True(actualValue.SequenceEqual(expectedVal));
        }
    }
}
