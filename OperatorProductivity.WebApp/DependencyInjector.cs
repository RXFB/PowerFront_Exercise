using MediatR;
using OperatorProductivity.Application.DTO;
using OperatorProductivity.Application.Handlers;
using OperatorProductivity.Application.Queries;
using OperatorProductivity.Data;
using OperatorProductivity.Data.SQLServer;
using System.Reflection;

public static class DependencyInjector
{
    public static IServiceCollection InjectDependencies(this IServiceCollection services)
    {
        services.AddMediatR((t) => { t.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });
        services.AddTransient<IRequestHandler<GetFilterValuesQuery, FilterValuesDTO>, GetFilterValuesQueryHandler>();
        services.AddTransient<IRequestHandler<GetOperatorProductivityResultQuery, OperatorProductivityResultDTO>, GetOperatorProductivityResultQueryHandler>();
        services.AddTransient<IChatRepository, SQLServerChatRepository>();
        return services;
    }
}
