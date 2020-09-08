using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CoreUnitTests.Adapters
{
    class DatatypeTestItem2 : IEquatable<DatatypeTestItem2>
    {
        public string A { get; set; }
        public string B { get; set; }
        public int C { get; set; }

        public bool Equals(DatatypeTestItem2 other)
        {
            return A == other.A && B == other.B && C == other.C;
        }
    }
}
