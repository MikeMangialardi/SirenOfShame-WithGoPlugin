using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirenOfShame.Lib;
using SirenOfShame.Lib.Helpers;
using SirenOfShame.Lib.ServerConfiguration;
using SirenOfShame.Lib.Settings;
using log4net;

namespace GoServices.ServerConfiguration
{
    public partial class ConfigureGo : ConfigureServerBase
    {
        private SirenOfShameSettings _settings;
        private GoCiEntryPoint _goCiEntryPoint;
        private CiEntryPointSetting _ciEntryPointSetting;
        private GoService _service = new GoService();
        private static readonly ILog _log = MyLogManager.GetLogger(typeof(ConfigureGo));

        public ConfigureGo(SirenOfShameSettings sosSettings, GoCiEntryPoint goCiEntryPoint, CiEntryPointSetting ciEntryPointSetting)
        {
            _settings = sosSettings;
            _goCiEntryPoint = goCiEntryPoint;
            _ciEntryPointSetting = ciEntryPointSetting;

            InitializeComponent();

            _url.Text = _ciEntryPointSetting.Url;
            _userName.Text = _ciEntryPointSetting.UserName;
            _password.Text = _ciEntryPointSetting.GetPassword();

            if (!string.IsNullOrEmpty(_url.Text))
            {
                ReloadProjects();
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            ReloadProjects();
        }

        private void ReloadProjects()
        {
            try
            {
                _projects.Nodes.Clear();
                _projects.Nodes.Add("Loading...");
                _service.GetProjects(_url.Text, _userName.Text, _password.Text, GetProjectsComplete, GetProjectsError);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetProjectsError(Exception ex)
        {
            _projects.Nodes.Clear();
            _log.Error(ex);
            MessageBox.Show("Error connecting to server: " + ex.Message);
        }

        private void GetProjectsComplete(GoBuildDefinition[] buildDefinitions)
        {
            _ciEntryPointSetting.Url = _url.Text;
            _ciEntryPointSetting.UserName = _userName.Text;
            _ciEntryPointSetting.SetPassword(_password.Text);
            Settings.Save();

            _projects.Nodes.Clear();
            var goBuildDefinitions = buildDefinitions.OrderBy(i => i.Name);
            foreach (var project in goBuildDefinitions)
            {
                bool exists = Settings.BuildExistsAndIsActive(_goCiEntryPoint.Name, project.Name);

                var node = new ThreeStateTreeNode(project.Name)
                {
                    Tag = project,
                    State = exists ? CheckBoxState.Checked : CheckBoxState.Unchecked
                };
                _projects.Nodes.Add(node);
            }
        }

        private void ProjectsAfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is GoBuildDefinition)
            {
                var buildDefinition = (GoBuildDefinition)e.Node.Tag;
                var buildDefSetting = _ciEntryPointSetting.FindAddBuildDefinition(buildDefinition, _goCiEntryPoint.Name);
                buildDefSetting.Active = e.Node.Checked;
                Settings.Save();
            }
            ((ThreeStateTreeNode)e.Node).UpdateStateOfRelatedNodes();
        }
    }
}
