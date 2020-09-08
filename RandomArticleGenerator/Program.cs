using Microsoft.Extensions.DependencyInjection;
using RandomArticleGenerator.Adapters.HttpAdapter;
using RandomArticleGenerator.Adapters.JsonAdapter;
using RandomArticleGenerator.Adapters.OuterGatewayAdapter;
using RandomArticleGenerator.Gateways.Article;
using RandomArticleGenerator.Gateways.Image;
using RandomArticleGenerator.Gateways.News;
using RandomArticleGenerator.Gateways.Quote;
using RandomArticleGenerator.Gateways.Spaceships;
using RandomArticleGenerator.Gateways.Weather;
using System;

namespace RandomArticleGenerator
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IArticleGateway, ArticleGateway>();
            services.AddSingleton<ImageGateway, RandomImageGateway>();
            services.AddSingleton<INewsGateway, NewsApiGateway>();
            services.AddSingleton<IQuotesGateway, QuotableGateway>();
            services.AddSingleton<ISpaceshipsGateway, SpaceXShipsGateway>();
            services.AddSingleton<IWeatherGateway, OpenWeatherGateway>();
            services.AddSingleton<IDatatypeSerializer, JsonAppSerializer>();
            services.AddSingleton<IResourceResolver, ResourceResolverAdapter>();
            services.AddSingleton<IRequestAgent, HttpAdapter>();
            _serviceProvider = services.BuildServiceProvider(true);
        }
        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            IArticleGateway gateway = scope.ServiceProvider.GetRequiredService<IArticleGateway>();
            DisposeServices();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
