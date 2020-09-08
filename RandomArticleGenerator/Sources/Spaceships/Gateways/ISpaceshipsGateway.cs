using RandomArticleGenerator.Domain.Spaceships;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Spaceships
{
    public interface ISpaceshipsGateway
    {
        Task<SpaceshipEntity> GetSpaceship(int shipId);
        Task<SpaceshipEntity> GetRandomSpaceship();
    }
}
