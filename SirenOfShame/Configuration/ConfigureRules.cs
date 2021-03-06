﻿using System;
using System.Linq;
using System.Windows.Forms;
using SirenOfShame.Lib.Settings;

namespace SirenOfShame.Configuration
{
    public partial class ConfigureRules : FormBase
    {
        private readonly SirenOfShameSettings _settings;

        public ConfigureRules(SirenOfShameSettings settings)
        {
            _settings = settings;
            InitializeComponent();
            ShowHideEditButton();
        }

        private void NewRuleClick(object sender, EventArgs e)
        {
            AddRule addRule = new AddRule(_settings);
            addRule.ShowDialog();
            DataBind();
        }

        private void ConfigureRulesLoad(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            _rulesList.Items.Clear();
            _rulesList.Items.AddRange(_settings.Rules.Select(r => r.AsListViewItem()).ToArray());
            ShowHideEditButton();
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (_rulesList.SelectedItems.Count == 0) return;
            ListViewItem i = _rulesList.SelectedItems[0];
            var rule = _settings.Rules.First(r => i.Tag == r);
            _settings.Rules.Remove(rule);
            DataBind();
            _settings.Save();
        }

        private void RulesListDoubleClick(object sender, EventArgs e)
        {
            OpenSelectedRuleForEdit();
        }

        private void OpenSelectedRuleForEdit()
        {
            ListViewItem item = _rulesList.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (item == null) return;
            Rule rule = (Rule) item.Tag;
            AddRule addRule = new AddRule(_settings, rule);
            addRule.ShowDialog();
            DataBind();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            var result = SosMessageBox.Show("Are you sure you want to delete all your rules?", "The obligatory 'are you sure?' dialog", "Yes, Delete Them All!", DialogResult.Yes, "Dude, terrible idea", DialogResult.No);
            if (result != DialogResult.Yes) return;
            _settings.ResetRules();
            _settings.ResetSirenSettings();
            DataBind();
        }

        private void _rulesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHideEditButton();
        }

        private void ShowHideEditButton()
        {
            _edit.Enabled = _rulesList.SelectedIndices.Count > 0;
        }

        private void EditClick(object sender, EventArgs e)
        {
            OpenSelectedRuleForEdit();
        }
    }
}