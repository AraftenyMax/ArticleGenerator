using RandomArticleGenerator.Domain.Spaceships;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Spaceships
{
    public interface SpaceshipsGateway
    {
        SpaceshipEntity GetSpaceship(int shipId);
    }
}
