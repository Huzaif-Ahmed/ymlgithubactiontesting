using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Awstestingyml;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public Dictionary<string, string> FunctionHandler(ILambdaContext context)
    {
        return new Dictionary<string, string>
        {
            {"ENV_VAR_1", Environment.GetEnvironmentVariable("ENV_VAR_1") ?? "NOT_SET"},
            {"ENV_VAR_2", Environment.GetEnvironmentVariable("ENV_VAR_2") ?? "NOT_SET"},
            {"AWS_REGION", Environment.GetEnvironmentVariable("AWS_REGION") ?? "NOT_SET"}
        };
    }
}
