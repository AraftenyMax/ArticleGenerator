using RandomArticleGenerator.Domain.Spaceships;
using System;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Spaceships
{
    class SpaceXShipsGateway : ISpaceshipsGateway
    {
        public Task<SpaceshipEntity> GetRandomSpaceship()
        {
            throw new NotImplementedException();
        }

        public Task<SpaceshipEntity> GetSpaceship(int shipId)
        {
            throw new NotImplementedException();
        }
    }
}
