using RandomArticleGenerator.Domain.Spaceships;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Spaceships
{
    public interface ISpaceshipsGateway
    {
        SpaceshipEntity GetSpaceship(int shipId);
        SpaceshipEntity GetRandomSpaceship();
    }
}
