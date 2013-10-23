using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SirenOfShame.Lib.Exceptions;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;

namespace GoServices
{
    public class GoWatcher : WatcherBase
    {
        private readonly GoCiEntryPoint _goCiEntryPoint;
        private readonly GoService _service = new GoService();

        public GoWatcher(SirenOfShameSettings settings, GoCiEntryPoint goCiEntryPoint) : base(settings)
        {
            _goCiEntryPoint = goCiEntryPoint;
        }

        protected override IList<BuildStatus> GetBuildStatus()
        {
            var ciEntryPointSetting = this.CiEntryPointSetting;
            var watchedBuildDefs = GetAllWatchedBuildDefinitions();

            if (string.IsNullOrEmpty(ciEntryPointSetting.Url))
                throw new SosException("Buildbot URL is null or empty");

            try
            {
                return _service.GetBuildsStatuses(ciEntryPointSetting.Url,
                                                       ciEntryPointSetting.UserName,
                                                       ciEntryPointSetting.GetPassword(),
                                                       watchedBuildDefs).Cast<BuildStatus>().ToList();
            }
            catch (WebException ex)
            {
                if (
                    ex.Message.StartsWith("The remote name could not be resolved:") ||
                    ex.Message.Contains("Unable to connect to the remote server")
                    )
                {
                    throw new ServerUnavailableException();
                }
                throw;
            }
        }

        private IEnumerable<BuildDefinitionSetting> GetAllWatchedBuildDefinitions()
        {
            var activeBuildDefinitionSettings = CiEntryPointSetting.BuildDefinitionSettings.Where(bd => bd.Active && bd.BuildServer == _goCiEntryPoint.Name);
            return activeBuildDefinitionSettings;
        }

        public override void StopWatching()
        {

        }

        public override void Dispose()
        {

        }
    }
}
