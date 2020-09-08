using RandomArticleGenerator.Domain.Image;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Image
{
    public interface ImageGateway
    {
        Task<ImageEntity> GetImage();
    }
}
