using ImageResizerFunction.ImageProcessors;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp.Web.DependencyInjection;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddImageSharp();
        services.TryAddTransient<RasterImageProcessor>();
        services.TryAddTransient<PassThroughImageProcessor>();
    })
    .Build();

host.Run();
