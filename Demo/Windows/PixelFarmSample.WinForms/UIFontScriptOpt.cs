﻿//MIT, 2020, WinterDev
using System;
using System.Windows.Forms;
using Typography.OpenFont;

namespace SampleWinForms
{
    public partial class UIFontScriptOpt : UserControl
    {
        public UIFontScriptOpt()
        {
            InitializeComponent();

            this.cmbHintTech.Items.Add(Typography.Contours.HintTechnique.None);
            this.cmbHintTech.Items.Add(Typography.Contours.HintTechnique.TrueTypeInstruction);
            this.cmbHintTech.Items.Add(Typography.Contours.HintTechnique.TrueTypeInstruction_VerticalOnly);
            this.cmbHintTech.SelectedIndex = 0;
        }

        private void CustomUIFontScriptOpt_Load(object sender, EventArgs e)
        {

        }
        UnicodeLangBits _langBits;
        Typography.OpenFont.ScriptLang _scriptLang;
        public Typography.OpenFont.ScriptLang ScriptLang => _scriptLang;
        public bool Selected => chkSelected.Checked;

        public Typography.Contours.HintTechnique HintTechnique => (Typography.Contours.HintTechnique)cmbHintTech.SelectedItem;
        public void SetInfo(Typography.OpenFont.ScriptLang scriptLang, UnicodeLangBits langBits)
        {
            _scriptLang = scriptLang;
            _langBits = langBits;
            this.label1.Text = _scriptLang.fullname + "," + _scriptLang.shortname + "," + langBits.ToString();
        }


    }
}
