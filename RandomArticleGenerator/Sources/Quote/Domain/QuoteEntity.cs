using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RandomArticleGenerator.Domain.Quote
{
    public class QuoteEntity : IEquatable<QuoteEntity>
    {
        public string Text { get; set; }
        public string Author { get; set; }

        public bool Equals(QuoteEntity other)
        {
            bool textsAreEqual = this.Text == other.Text;
            bool authorsAreEqual = this.Author == other.Author;

            return textsAreEqual && authorsAreEqual;
        }
    }
}
