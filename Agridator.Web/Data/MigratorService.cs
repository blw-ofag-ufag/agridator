namespace Agridator.Web.Data
{
    public class MigratorService : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public MigratorService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
                //nope
            }
        }

        // noop
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
