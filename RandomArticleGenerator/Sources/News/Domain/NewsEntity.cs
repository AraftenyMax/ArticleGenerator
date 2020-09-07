using RandomArticleGenerator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RandomArticleGenerator.Domain.News
{
    public class NewsEntity : IEquatable<NewsEntity>
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public byte[,] Image { get; set; }
        public string Url { get; set; }

        public bool Equals(NewsEntity other)
        {
            bool authorsAreEqual = this.Author == other.Author;
            bool descriptionsAreEqual = this.Description == other.Description;
            bool imagesAreEqual = this.Image.AreEqual(other.Image);
            bool urlsAreEqual = this.Url == other.Url;

            return authorsAreEqual && descriptionsAreEqual && imagesAreEqual && urlsAreEqual;
        }
    }
}
