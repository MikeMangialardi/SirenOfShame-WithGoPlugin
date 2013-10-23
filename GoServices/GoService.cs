using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SirenOfShame.Lib;
using SirenOfShame.Lib.Settings;
using SirenOfShame.Lib.Watcher;
using log4net;

namespace GoServices
{
    public class GoService : ServiceBase 
    {

        private static readonly ILog _log = MyLogManager.GetLogger(typeof(GoService));

        public void GetProjects(string url, string username, string password, Action<GoBuildDefinition[]> getProjectsComplete, Action<Exception> getProjectsError)
        {
            try
            {
                var cctray = GetCcTray(url, username, password);

                var pipelineStages = cctray.Root.Elements("Project");
                var pipelines = GetUniquePipelineNames(pipelineStages);

                getProjectsComplete(pipelines.Select(p => new GoBuildDefinition(p, p)).ToArray());
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                getProjectsError(ex);
            }

        }

        public IList<GoBuildStatus> GetBuildsStatuses(string url, string userName, string password, IEnumerable<BuildDefinitionSetting> watchedBuildDefs)
        {
            var cctray = GetCcTray(url, userName, password);

            var pipelines =
                watchedBuildDefs.Select(
                    w => cctray.Root.Elements("Project").Where(x => x.Attribute("name").Value.Contains(w.Name)));

            return pipelines.Select(p => new GoBuildStatus(p)).ToList();
        }

        private XDocument GetCcTray(string url, string username, string password)
        {
            var webClient = new WebClient
            {
                Credentials = new NetworkCredential(username, password)
            };
            var cctrayUri = new Uri(UrlCombine(url, "/cctray.xml"));

            var result = webClient.DownloadString(cctrayUri);

            return XDocument.Parse(result);
        }

        private IEnumerable<string> GetUniquePipelineNames(IEnumerable<XElement> pipelineStages)
        {
            return pipelineStages.Select(GetPipelineName).Distinct();
        }

        private string GetPipelineName(XElement pipelineStage)
        {
            return pipelineStage.Attribute("name").Value.Split(' ').First();
        }

        private string UrlCombine(string url1, string url2)
        {
            var trimChars = new char[] {'\\', '/', ' '};
            return url1.TrimEnd(trimChars) + '/' + url2.TrimStart(trimChars);
        }
    }
}
