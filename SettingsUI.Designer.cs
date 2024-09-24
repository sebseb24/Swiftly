namespace Swiftly
{
    partial class SettingsUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            lv_Profiles = new ListView();
            bt_CreateProfile = new Button();
            flb_Name = new Label();
            tb_NameSelection = new TextBox();
            flb_Input = new Label();
            cb_OutputSelection = new ComboBox();
            cb_InputSelection = new ComboBox();
            label1 = new Label();
            bt_Save = new Button();
            flb_IsActive = new Label();
            cb_IsActive = new CheckBox();
            bt_Delete = new Button();
            SuspendLayout();
            // 
            // lv_Profiles
            // 
            lv_Profiles.Location = new Point(12, 12);
            lv_Profiles.Name = "lv_Profiles";
            lv_Profiles.Size = new Size(178, 130);
            lv_Profiles.TabIndex = 0;
            lv_Profiles.UseCompatibleStateImageBehavior = false;
            lv_Profiles.View = View.List;
            lv_Profiles.MouseClick += lv_Profiles_MouseClick;
            // 
            // bt_CreateProfile
            // 
            bt_CreateProfile.Location = new Point(12, 148);
            bt_CreateProfile.Name = "bt_CreateProfile";
            bt_CreateProfile.Size = new Size(178, 23);
            bt_CreateProfile.TabIndex = 1;
            bt_CreateProfile.Text = "New Profile";
            bt_CreateProfile.UseVisualStyleBackColor = true;
            bt_CreateProfile.Click += bt_CreateProfile_Click;
            // 
            // flb_Name
            // 
            flb_Name.AutoSize = true;
            flb_Name.Location = new Point(196, 12);
            flb_Name.Name = "flb_Name";
            flb_Name.Size = new Size(48, 15);
            flb_Name.TabIndex = 2;
            flb_Name.Text = "Name : ";
            // 
            // tb_NameSelection
            // 
            tb_NameSelection.Location = new Point(299, 9);
            tb_NameSelection.Name = "tb_NameSelection";
            tb_NameSelection.Size = new Size(232, 23);
            tb_NameSelection.TabIndex = 3;
            // 
            // flb_Input
            // 
            flb_Input.AutoSize = true;
            flb_Input.Location = new Point(196, 41);
            flb_Input.Name = "flb_Input";
            flb_Input.Size = new Size(89, 15);
            flb_Input.TabIndex = 5;
            flb_Input.Text = "Output Device :";
            // 
            // cb_OutputSelection
            // 
            cb_OutputSelection.FormattingEnabled = true;
            cb_OutputSelection.Location = new Point(299, 38);
            cb_OutputSelection.Name = "cb_OutputSelection";
            cb_OutputSelection.Size = new Size(232, 23);
            cb_OutputSelection.TabIndex = 6;
            // 
            // cb_InputSelection
            // 
            cb_InputSelection.FormattingEnabled = true;
            cb_InputSelection.Location = new Point(299, 67);
            cb_InputSelection.Name = "cb_InputSelection";
            cb_InputSelection.Size = new Size(232, 23);
            cb_InputSelection.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 70);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Input Device :";
            // 
            // bt_Save
            // 
            bt_Save.Location = new Point(456, 148);
            bt_Save.Name = "bt_Save";
            bt_Save.Size = new Size(75, 23);
            bt_Save.TabIndex = 9;
            bt_Save.Text = "Save";
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // flb_IsActive
            // 
            flb_IsActive.AutoSize = true;
            flb_IsActive.Location = new Point(196, 100);
            flb_IsActive.Name = "flb_IsActive";
            flb_IsActive.Size = new Size(46, 15);
            flb_IsActive.TabIndex = 11;
            flb_IsActive.Text = "Active :";
            // 
            // cb_IsActive
            // 
            cb_IsActive.AutoSize = true;
            cb_IsActive.Location = new Point(299, 100);
            cb_IsActive.Name = "cb_IsActive";
            cb_IsActive.Size = new Size(15, 14);
            cb_IsActive.TabIndex = 12;
            cb_IsActive.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            bt_Delete.Location = new Point(375, 148);
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Size = new Size(75, 23);
            bt_Delete.TabIndex = 13;
            bt_Delete.Text = "Delete";
            bt_Delete.UseVisualStyleBackColor = true;
            bt_Delete.Click += bt_Delete_Click;
            // 
            // SettingsUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 177);
            Controls.Add(bt_Delete);
            Controls.Add(cb_IsActive);
            Controls.Add(flb_IsActive);
            Controls.Add(bt_Save);
            Controls.Add(cb_InputSelection);
            Controls.Add(label1);
            Controls.Add(cb_OutputSelection);
            Controls.Add(flb_Input);
            Controls.Add(tb_NameSelection);
            Controls.Add(flb_Name);
            Controls.Add(bt_CreateProfile);
            Controls.Add(lv_Profiles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_Profiles;
        private Button bt_CreateProfile;
        private Label flb_Name;
        private TextBox tb_NameSelection;
        private Label flb_Input;
        private ComboBox cb_OutputSelection;
        private ComboBox cb_InputSelection;
        private Label label1;
        private Button bt_Save;
        private Label flb_IsActive;
        private CheckBox cb_IsActive;
        private Button bt_Delete;
    }
}