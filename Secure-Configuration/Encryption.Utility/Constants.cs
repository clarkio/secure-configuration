using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.Utility
{
    public static class ConfigurationConstants
    {
        public const string ConnectionStringsSectionName = "connectionStrings";
    }

    public static class ProtectionProviders
    {
        public const string TripleDESProvider = "TripleDESProvider";
        public const string MyProvider = "MyProvider";
        public const string RsaProvider = "RsaProtectedConfigurationProvider";
    }
}
