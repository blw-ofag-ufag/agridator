namespace Agridator.Web.Data
{
    public class MigratorService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<MigratorService> _logger;

        public MigratorService(IServiceProvider serviceProvider, ILogger<MigratorService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // Create a new scope to retrieve scoped services
            using var scope = _serviceProvider.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetService<ApplicationDbContext>()
                    ?? throw new InvalidOperationException("context can't be null");

                    await context.Database.EnsureCreatedAsync(cancellationToken).ConfigureAwait(false);

                    await DataSeeder.SeedDataAsync(context, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred seeding the DB.");
            }
        }

        // noop
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
