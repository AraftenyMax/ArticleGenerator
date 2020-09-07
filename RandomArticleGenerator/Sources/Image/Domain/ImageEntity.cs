using RandomArticleGenerator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RandomArticleGenerator.Domain.Image
{
    public class ImageEntity : IEquatable<ImageEntity>
    {
        public string Url { get; set; }
        public byte[,] Bitmap { get; set; }

        public bool Equals(ImageEntity other)
        {
            bool urls = Url.Equals(other.Url);
            bool bitmaps = Bitmap.AreEqual(other.Bitmap);
            return urls && bitmaps;
        }
    }
}
