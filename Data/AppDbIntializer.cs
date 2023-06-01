namespace Gara.Data
{
    public class AppDbIntializer
    {
        public static void seed (IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope =applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContex>();
                context.Database.EnsureVreated();

            }
        }
    }
}
