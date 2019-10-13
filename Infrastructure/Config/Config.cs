using System.Collections.Generic;

namespace CooperativaXZ
{
    public static class Config
    {
        const string EnvironmentNameKey = "environmentName";
        const string ApiUrlKey = "apiUrl";
        const string ApiKeyKey = "apiKey";

        readonly static Dictionary<AppEnvironment, Dictionary<string, string>> Configurations = new Dictionary<AppEnvironment, Dictionary<string, string>>
        {
            [AppEnvironment.Debug] = new Dictionary<string, string>
            {
                [EnvironmentNameKey] = "dev",
                [ApiUrlKey] = "https://localhost:3000/",
                [ApiKeyKey] = "58A491CF-51D6-469D-AA47-C16A291236F0",
            },
            [AppEnvironment.QA] = new Dictionary<string, string>
            {
                [EnvironmentNameKey] = "qa",
                [ApiUrlKey] = "https://localhost:3000/",
                [ApiKeyKey] = "58A491CF-51D6-469D-AA47-C16A291236F0",
            },
            [AppEnvironment.Production] = new Dictionary<string, string>
            {
                [EnvironmentNameKey] = "prd",
                [ApiUrlKey] = "https://localhost:3000/",
                [ApiKeyKey] = "58A491CF-51D6-469D-AA47-C16A291236F0",
            },
        };

        /// <summary>
        /// Stores the Application Environment.
        /// </summary>
        static AppEnvironment selectedEnvironment = AppEnvironment.Debug;

        /// <summary>
        /// Sets the Application Environment that will be used for this configuration.
        /// </summary>
        /// <param name="environment">The Application Environment.</param>
        public static void SetEnvironment(AppEnvironment environment) => selectedEnvironment = environment;

        public static string EnvironmentName => Configurations[selectedEnvironment][EnvironmentNameKey];

        public static string ApiUrl => Configurations[selectedEnvironment][ApiUrlKey];

        public static string ApiKey => Configurations[selectedEnvironment][ApiKeyKey];
    }
}
