using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CoreUnitTests.Adapters
{
    class DatatypeTestItem1 : IEquatable<DatatypeTestItem1>
    {
        public string A { get; set; }
        public string B { get; set; }
        public DatatypeTestItem2 item { get; set; }

        public bool Equals(DatatypeTestItem1 other)
        {
            return A == other.A && B == other.B && item.Equals(other.item);
        }
    }
}
