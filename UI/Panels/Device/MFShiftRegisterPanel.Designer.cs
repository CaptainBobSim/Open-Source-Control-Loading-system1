﻿
namespace MobiFlight.UI.Panels.Settings
{
    partial class MFShiftRegisterPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFShiftRegisterPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mfNumModulesComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfModulesLabel = new System.Windows.Forms.Label();
            this.mfPin1Label = new System.Windows.Forms.Label();
            this.mfPin1ComboBox = new System.Windows.Forms.ComboBox();
            this.mfPin3Label = new System.Windows.Forms.Label();
            this.mfPin3ComboBox = new System.Windows.Forms.ComboBox();
            this.mfPin2Label = new System.Windows.Forms.Label();
            this.mfPin2ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mfNumModulesComboBox);
            this.groupBox1.Controls.Add(this.numberOfModulesLabel);
            this.groupBox1.Controls.Add(this.mfPin1Label);
            this.groupBox1.Controls.Add(this.mfPin1ComboBox);
            this.groupBox1.Controls.Add(this.mfPin3Label);
            this.groupBox1.Controls.Add(this.mfPin3ComboBox);
            this.groupBox1.Controls.Add(this.mfPin2Label);
            this.groupBox1.Controls.Add(this.mfPin2ComboBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // mfNumModulesComboBox
            // 
            resources.ApplyResources(this.mfNumModulesComboBox, "mfNumModulesComboBox");
            this.mfNumModulesComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mfNumModulesComboBox.FormattingEnabled = true;
            this.mfNumModulesComboBox.Name = "mfNumModulesComboBox";
            this.toolTip1.SetToolTip(this.mfNumModulesComboBox, resources.GetString("mfNumModulesComboBox.ToolTip"));
            this.mfNumModulesComboBox.SelectedIndexChanged += new System.EventHandler(this.value_Changed);
            this.mfNumModulesComboBox.SelectedValueChanged += new System.EventHandler(this.value_Changed);
            // 
            // numberOfModulesLabel
            // 
            resources.ApplyResources(this.numberOfModulesLabel, "numberOfModulesLabel");
            this.numberOfModulesLabel.Name = "numberOfModulesLabel";
            this.toolTip1.SetToolTip(this.numberOfModulesLabel, resources.GetString("numberOfModulesLabel.ToolTip"));
            // 
            // mfPin1Label
            // 
            resources.ApplyResources(this.mfPin1Label, "mfPin1Label");
            this.mfPin1Label.Name = "mfPin1Label";
            this.toolTip1.SetToolTip(this.mfPin1Label, resources.GetString("mfPin1Label.ToolTip"));
            // 
            // mfPin1ComboBox
            // 
            resources.ApplyResources(this.mfPin1ComboBox, "mfPin1ComboBox");
            this.mfPin1ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mfPin1ComboBox.FormattingEnabled = true;
            this.mfPin1ComboBox.Name = "mfPin1ComboBox";
            this.toolTip1.SetToolTip(this.mfPin1ComboBox, resources.GetString("mfPin1ComboBox.ToolTip"));
            this.mfPin1ComboBox.SelectedIndexChanged += new System.EventHandler(this.value_Changed);
            this.mfPin1ComboBox.SelectedValueChanged += new System.EventHandler(this.value_Changed);
            // 
            // mfPin3Label
            // 
            resources.ApplyResources(this.mfPin3Label, "mfPin3Label");
            this.mfPin3Label.Name = "mfPin3Label";
            this.toolTip1.SetToolTip(this.mfPin3Label, resources.GetString("mfPin3Label.ToolTip"));
            // 
            // mfPin3ComboBox
            // 
            resources.ApplyResources(this.mfPin3ComboBox, "mfPin3ComboBox");
            this.mfPin3ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mfPin3ComboBox.FormattingEnabled = true;
            this.mfPin3ComboBox.Name = "mfPin3ComboBox";
            this.toolTip1.SetToolTip(this.mfPin3ComboBox, resources.GetString("mfPin3ComboBox.ToolTip"));
            this.mfPin3ComboBox.SelectedIndexChanged += new System.EventHandler(this.value_Changed);
            this.mfPin3ComboBox.SelectedValueChanged += new System.EventHandler(this.value_Changed);
            // 
            // mfPin2Label
            // 
            resources.ApplyResources(this.mfPin2Label, "mfPin2Label");
            this.mfPin2Label.Name = "mfPin2Label";
            this.toolTip1.SetToolTip(this.mfPin2Label, resources.GetString("mfPin2Label.ToolTip"));
            // 
            // mfPin2ComboBox
            // 
            resources.ApplyResources(this.mfPin2ComboBox, "mfPin2ComboBox");
            this.mfPin2ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mfPin2ComboBox.FormattingEnabled = true;
            this.mfPin2ComboBox.Name = "mfPin2ComboBox";
            this.toolTip1.SetToolTip(this.mfPin2ComboBox, resources.GetString("mfPin2ComboBox.ToolTip"));
            this.mfPin2ComboBox.SelectedIndexChanged += new System.EventHandler(this.value_Changed);
            this.mfPin2ComboBox.SelectedValueChanged += new System.EventHandler(this.value_Changed);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.toolTip1.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
            this.textBox1.TextChanged += new System.EventHandler(this.value_Changed);
            // 
            // MFShiftRegisterPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MFShiftRegisterPanel";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mfNumModulesComboBox;
        private System.Windows.Forms.Label numberOfModulesLabel;
        private System.Windows.Forms.Label mfPin1Label;
        private System.Windows.Forms.ComboBox mfPin1ComboBox;
        private System.Windows.Forms.Label mfPin3Label;
        private System.Windows.Forms.ComboBox mfPin3ComboBox;
        private System.Windows.Forms.Label mfPin2Label;
        private System.Windows.Forms.ComboBox mfPin2ComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}
