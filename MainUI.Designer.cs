namespace Swiftly
{
    partial class Swiftly
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swiftly));
            flb_profile = new Label();
            flb_Output = new Label();
            flb_Input = new Label();
            lb_selectedProfile = new Label();
            lb_selectedOutput = new Label();
            lb_selectedInput = new Label();
            bt_Settings = new Button();
            flb_Hotkey = new Label();
            lb_SelectedHotkey = new Label();
            ni_NotifyIcon = new NotifyIcon(components);
            cms_NotifyIconMenuStrip = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            cms_NotifyIconMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // flb_profile
            // 
            flb_profile.AutoSize = true;
            flb_profile.Location = new Point(12, 9);
            flb_profile.Name = "flb_profile";
            flb_profile.Size = new Size(47, 15);
            flb_profile.TabIndex = 0;
            flb_profile.Text = "Profile :";
            // 
            // flb_Output
            // 
            flb_Output.AutoSize = true;
            flb_Output.Location = new Point(12, 24);
            flb_Output.Name = "flb_Output";
            flb_Output.Size = new Size(89, 15);
            flb_Output.TabIndex = 1;
            flb_Output.Text = "Output Device :";
            // 
            // flb_Input
            // 
            flb_Input.AutoSize = true;
            flb_Input.Location = new Point(12, 39);
            flb_Input.Name = "flb_Input";
            flb_Input.Size = new Size(79, 15);
            flb_Input.TabIndex = 2;
            flb_Input.Text = "Input Device :";
            // 
            // lb_selectedProfile
            // 
            lb_selectedProfile.AutoSize = true;
            lb_selectedProfile.Location = new Point(147, 9);
            lb_selectedProfile.Name = "lb_selectedProfile";
            lb_selectedProfile.Size = new Size(20, 15);
            lb_selectedProfile.TabIndex = 3;
            lb_selectedProfile.Text = "na";
            // 
            // lb_selectedOutput
            // 
            lb_selectedOutput.AutoSize = true;
            lb_selectedOutput.Location = new Point(147, 24);
            lb_selectedOutput.Name = "lb_selectedOutput";
            lb_selectedOutput.Size = new Size(20, 15);
            lb_selectedOutput.TabIndex = 4;
            lb_selectedOutput.Text = "na";
            // 
            // lb_selectedInput
            // 
            lb_selectedInput.AutoSize = true;
            lb_selectedInput.Location = new Point(147, 39);
            lb_selectedInput.Name = "lb_selectedInput";
            lb_selectedInput.Size = new Size(20, 15);
            lb_selectedInput.TabIndex = 5;
            lb_selectedInput.Text = "na";
            // 
            // bt_Settings
            // 
            bt_Settings.Location = new Point(12, 72);
            bt_Settings.Name = "bt_Settings";
            bt_Settings.Size = new Size(75, 23);
            bt_Settings.TabIndex = 6;
            bt_Settings.Text = "Settings";
            bt_Settings.UseVisualStyleBackColor = true;
            bt_Settings.Click += bt_Settings_Click;
            // 
            // flb_Hotkey
            // 
            flb_Hotkey.AutoSize = true;
            flb_Hotkey.Location = new Point(12, 54);
            flb_Hotkey.Name = "flb_Hotkey";
            flb_Hotkey.Size = new Size(55, 15);
            flb_Hotkey.TabIndex = 7;
            flb_Hotkey.Text = "Hot Key :";
            // 
            // lb_SelectedHotkey
            // 
            lb_SelectedHotkey.AutoSize = true;
            lb_SelectedHotkey.Location = new Point(147, 54);
            lb_SelectedHotkey.Name = "lb_SelectedHotkey";
            lb_SelectedHotkey.Size = new Size(20, 15);
            lb_SelectedHotkey.TabIndex = 8;
            lb_SelectedHotkey.Text = "na";
            // 
            // ni_NotifyIcon
            // 
            ni_NotifyIcon.ContextMenuStrip = cms_NotifyIconMenuStrip;
            ni_NotifyIcon.Icon = (Icon)resources.GetObject("ni_NotifyIcon.Icon");
            ni_NotifyIcon.Text = "Swiftly";
            ni_NotifyIcon.Visible = true;
            ni_NotifyIcon.MouseDoubleClick += ni_NotifyIcon_MouseDoubleClick;
            // 
            // cms_NotifyIconMenuStrip
            // 
            cms_NotifyIconMenuStrip.ImageScalingSize = new Size(32, 32);
            cms_NotifyIconMenuStrip.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            cms_NotifyIconMenuStrip.Name = "cms_NotifyIconMenuStrip";
            cms_NotifyIconMenuStrip.Size = new Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Swiftly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(386, 100);
            Controls.Add(lb_SelectedHotkey);
            Controls.Add(flb_Hotkey);
            Controls.Add(bt_Settings);
            Controls.Add(lb_selectedInput);
            Controls.Add(lb_selectedOutput);
            Controls.Add(lb_selectedProfile);
            Controls.Add(flb_Input);
            Controls.Add(flb_Output);
            Controls.Add(flb_profile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            StartPosition = FormStartPosition.Manual;
            WindowState = FormWindowState.Minimized;
            FormClosing += Swiftly_FormClosing;
            cms_NotifyIconMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label flb_profile;
        private Label flb_Output;
        private Label flb_Input;
        private Label lb_selectedProfile;
        private Label lb_selectedOutput;
        private Label lb_selectedInput;
        private Button bt_Settings;
        private Label flb_Hotkey;
        private Label lb_SelectedHotkey;
        private NotifyIcon ni_NotifyIcon;
        private ContextMenuStrip cms_NotifyIconMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
