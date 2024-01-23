namespace AppSignalR
{
    public class SU
    {
        public SU(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<AppHub>("/appHub");
            });
        }
    }
    public class AppHub : Hub
    {
        public async Task ReloadTableOnDataChanged(string user, string message)
        {
            await Clients.All.SendAsync("SendMessage", user, message);
        }
    }
}
