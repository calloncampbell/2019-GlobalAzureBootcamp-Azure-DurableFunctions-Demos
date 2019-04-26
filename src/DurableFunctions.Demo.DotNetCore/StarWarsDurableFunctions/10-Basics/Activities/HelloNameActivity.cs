using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace DurableFunctions.Demo.DotNetCore.Basics.Activities
{
    public class HelloNameActivity
    {
        [FunctionName(nameof(HelloNameActivity))]
        public string Run(
            [ActivityTrigger] string name,
            ILogger logger)
        {
            return $"Hello {name}!";
        }
    }
}
