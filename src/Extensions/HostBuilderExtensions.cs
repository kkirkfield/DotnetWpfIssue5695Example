using DotnetWpfIssue5695Example.ViewModels;
using DotnetWpfIssue5695Example.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetWpfIssue5695Example.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder AddServices(this IHostBuilder hostBuilder) =>
        hostBuilder.ConfigureServices(services =>
        {

        });

    public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder) =>
        hostBuilder.ConfigureServices(services =>
        {
            services.AddTransient<ExampleViewModel>();
        });

    public static IHostBuilder AddViews(this IHostBuilder hostBuilder) =>
        hostBuilder.ConfigureServices(services =>
        {
            services.AddTransient<ExampleView>();
            services.AddSingleton<MainWindow>();
        });
}
