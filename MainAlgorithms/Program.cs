using MainAlgorithms;
using MainAlgorithms.Reserch;
using MainAlgorithms.Services;
using MainAlgorithms.Shuffle;
using MainAlgorithms.Sorting;
using Microsoft.Extensions.DependencyInjection;

#region Init DI
ServiceCollection services = new ServiceCollection();
ConfigureServices(services);
ServiceProvider serviceProvider = services.BuildServiceProvider();
#endregion
serviceProvider.GetService<SortRuner>()?.Run();
serviceProvider.GetService<ReadonlyRefVsReadonlyValTypes>()?.Test();


#region Methods
void ConfigureServices(ServiceCollection services)
{
    services.AddTransient<IStat, StatService>();
    services.AddTransient<FisherYeyts>();
    services.AddTransient<GuidShuffle>();
    services.AddTransient<ISort, Shake>();
    services.AddTransient<ISort, Bubble>();
    services.AddTransient<ISort, Comb>();
    services.AddTransient<ISort, Insert>();
    services.AddTransient<ISort, DefaultDotNet>();
    services.AddTransient<ISort, Select>();
    services.AddTransient<ISort, Quick>();
    services.AddTransient<ISort, Merge>();
    services.AddTransient<ISort, Heap>();
    services.AddTransient<ISort, Linq>();
    services.AddTransient<SortRuner>();
    services.AddTransient<ReadonlyRefVsReadonlyValTypes>();
}
#endregion