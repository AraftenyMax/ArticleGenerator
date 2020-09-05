using RandomArticleGenerator.Domain.Image;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Image
{
    public interface ImageGateway
    {
        ImageEntity GetImage();
    }
}
