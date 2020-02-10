using System.Collections.Specialized;

namespace badlife
{
    public class AppConfiguration : IConfiguration
    {
        private readonly NameValueCollection _appSettings;
        public AppConfiguration(NameValueCollection appSettings)
        {
            _appSettings = appSettings;
        }

        public string InputPath => _appSettings.Get("InputPath");
    }
}