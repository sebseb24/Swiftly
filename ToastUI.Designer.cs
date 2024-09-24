namespace Swiftly
{
    partial class ToastUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastUI));
            pn_ToastColor = new Panel();
            pb_ToastImage = new PictureBox();
            lb_ToastType = new Label();
            lb_ToastMessage = new Label();
            tm_ToastTimer = new System.Windows.Forms.Timer(components);
            tm_ToastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pb_ToastImage).BeginInit();
            SuspendLayout();
            // 
            // pn_ToastColor
            // 
            pn_ToastColor.BackColor = Color.FromArgb(57, 155, 53);
            pn_ToastColor.Location = new Point(-2, -3);
            pn_ToastColor.Name = "pn_ToastColor";
            pn_ToastColor.Size = new Size(10, 65);
            pn_ToastColor.TabIndex = 0;
            // 
            // pb_ToastImage
            // 
            pb_ToastImage.Image = (Image)resources.GetObject("pb_ToastImage.Image");
            pb_ToastImage.Location = new Point(17, 12);
            pb_ToastImage.Name = "pb_ToastImage";
            pb_ToastImage.Size = new Size(32, 32);
            pb_ToastImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_ToastImage.TabIndex = 1;
            pb_ToastImage.TabStop = false;
            // 
            // lb_ToastType
            // 
            lb_ToastType.AutoSize = true;
            lb_ToastType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_ToastType.Location = new Point(55, 12);
            lb_ToastType.Name = "lb_ToastType";
            lb_ToastType.Size = new Size(37, 17);
            lb_ToastType.TabIndex = 2;
            lb_ToastType.Text = "Type";
            // 
            // lb_ToastMessage
            // 
            lb_ToastMessage.AutoSize = true;
            lb_ToastMessage.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_ToastMessage.Location = new Point(55, 31);
            lb_ToastMessage.Name = "lb_ToastMessage";
            lb_ToastMessage.Size = new Size(82, 13);
            lb_ToastMessage.TabIndex = 3;
            lb_ToastMessage.Text = "Toast Message";
            // 
            // tm_ToastTimer
            // 
            tm_ToastTimer.Enabled = true;
            tm_ToastTimer.Interval = 10;
            tm_ToastTimer.Tick += tm_ToastTimer_Tick;
            // 
            // tm_ToastHide
            // 
            tm_ToastHide.Interval = 10;
            tm_ToastHide.Tick += tm_ToastHide_Tick;
            // 
            // ToastUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(lb_ToastMessage);
            Controls.Add(lb_ToastType);
            Controls.Add(pb_ToastImage);
            Controls.Add(pn_ToastColor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastUI";
            StartPosition = FormStartPosition.Manual;
            Text = "ToastUI";
            Click += ToastUI_Click;
            ((System.ComponentModel.ISupportInitialize)pb_ToastImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_ToastColor;
        private PictureBox pb_ToastImage;
        private Label lb_ToastType;
        private Label lb_ToastMessage;
        private System.Windows.Forms.Timer tm_ToastTimer;
        private System.Windows.Forms.Timer tm_ToastHide;
    }
}