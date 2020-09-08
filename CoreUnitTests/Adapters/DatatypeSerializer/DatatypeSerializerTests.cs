using NUnit.Framework;
using RandomArticleGenerator.Adapters.JsonAdapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUnitTests.Adapters
{
    class DatatypeSerializerTests
    {
        IDatatypeSerializer serializer;
        [SetUp]
        public void SetUp()
        {
            serializer = new JsonAppSerializer();
        }

        [Test]
        public void ConvertsSimpleEntity()
        {
            DatatypeTestItem2 expectedItem = new DatatypeTestItem2
            {
                A = "A is B",
                B = "B is C",
                C = 228
            };
            string rawObject = "{\"A\": \"A is B\", \"B\": \"B is C\", \"C\": 228}";
            DatatypeTestItem2 actualItem = serializer.Deserialize<DatatypeTestItem2>(rawObject);
            Assert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public void ConvertsNestedEntity()
        {
            DatatypeTestItem2 item2 = new DatatypeTestItem2
            {
                A = "A isn't B",
                B = "B isn't C",
                C = 229
            };
            DatatypeTestItem1 expectedItem = new DatatypeTestItem1
            {
                A = "Root A",
                B = "Root B",
                item = item2
            };
            string rawObject = "{\"A\": \"Root A\", \"B\": \"Root B\", " +
                "\"item\": {\"A\": \"A isn't B\", \"B\": \"B isn't C\", \"C\": 229}}";
            DatatypeTestItem1 actualItem = serializer.Deserialize<DatatypeTestItem1>(rawObject);
            Assert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public void ThrowsExceptionOnInvalidData()
        {
            string rawObject = "{\"A\": 12, \"B\": \"B is C\", \"C\": 'c'}";
            Exception ex = Assert.Throws<Exception>(delegate { serializer.Deserialize<DatatypeTestItem2>(rawObject); });
            Assert.AreEqual(ex.Message, "Exception occurred while parsing json response");
        }
    }
}
