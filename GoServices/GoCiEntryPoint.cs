using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using GoServices.ServerConfiguration;
using SirenOfShame.Lib;
using SirenOfShame.Lib.ServerConfiguration;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;

namespace GoServices
{
    [Export(typeof(ICiEntryPoint))]
    public class GoCiEntryPoint : ICiEntryPoint 
    {
        public ConfigureServerBase CreateConfigurationWindow(SirenOfShameSettings settings, CiEntryPointSetting ciEntryPointSetting)
        {
            return new ConfigureGo(settings, this, ciEntryPointSetting);
        }

        public string Name { get { return "Go"; } }
        public string DisplayName { get { return "Go"; } }

        public WatcherBase GetWatcher(SirenOfShameSettings settings)
        {
            return new GoWatcher(settings, this);
        }
    }
}
