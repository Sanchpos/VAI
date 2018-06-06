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
            public string InnerTestField { get; set; }
            private Base64Field<TestClass, double[]> testField;
            public double[] TestProp
            {
                get
                {
                    if (testField == null)
                        testField = new Base64Field<TestClass, double[]>(this, nameof(InnerTestField));
                    return testField.Value;
                }
                set
                {
                    if (testField == null)
                        testField = new Base64Field<TestClass, double[]>(this, nameof(InnerTestField));
                    testField.Value = value;
                }
            }
        }
        
        [Fact]
        public void ReadWriteTest()
        {
            var testObj = new TestClass();
            var expectedVal = new[] { 0.2, 0.45662, 84 };
            testObj.TestProp= expectedVal;
            var actualValue = testObj.TestProp;
            Assert.True(actualValue.SequenceEqual(expectedVal));
        }
    }
}
