using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.Utility
{
    public static class EncryptionUtility
    {
        public static void EncryptConnectionStringsSection(string appConfigPath)
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = appConfigPath;

            var config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            var connectionStringsSection = config.ConnectionStrings;

            if(!connectionStringsSection.SectionInformation.IsLocked)
            {
                if(!connectionStringsSection.SectionInformation.IsProtected)
                {
                    connectionStringsSection.SectionInformation.ProtectSection(ProtectionProviders.TripleDESProvider);
                    connectionStringsSection.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Full);
                }
            }
        }
    }
}
