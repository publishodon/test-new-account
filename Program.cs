namespace App
{
    using System.Threading.Tasks;
    using Ninject;
    using Softozor.Publishodon;
    using Softozor.Publishodon.Logging;
    using log4net;
    using App.Properties;

    internal class Program
    {

        private static readonly ILog Log = LoggingSetup.CreateLog(Resources.log4net, typeof(Program), nameof(Program));

        private static async Task<int> Main(string[] args)
        {
            Log.Info("starting application");
            using var kernel = KernelFactory.Create();
            var bootstrapper = kernel.Get<Bootstrapper>();
            var result = await bootstrapper.RunAsync(args);
            return (int) result;
        }
    }
}