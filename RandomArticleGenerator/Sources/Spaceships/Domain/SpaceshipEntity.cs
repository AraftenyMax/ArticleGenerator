using RandomArticleGenerator.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RandomArticleGenerator.Domain.Spaceships
{
    public class SpaceshipEntity : IEquatable<SpaceshipEntity>
    {
        public string Name { get; set; }
        public byte[,] Image { get; set; }
        public bool Active { get; set; }
        public int Height { get; set; }
        public int Mass { get; set; }

        public bool Equals(SpaceshipEntity other)
        {
            bool namesAreEqual = this.Name == other.Name;
            bool imagesAreEqual = this.Image.AreEqual(other.Image);
            bool activesAreEqual = this.Active == other.Active;
            bool heightsAreEqual = this.Height == other.Height;
            bool massesAreEqual = this.Mass == other.Mass;

            return namesAreEqual && imagesAreEqual && activesAreEqual && heightsAreEqual && massesAreEqual;
        }
    }
}
