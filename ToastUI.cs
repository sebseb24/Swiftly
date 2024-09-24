using Swiftly.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swiftly
{
    public partial class ToastUI : Form
    {
        private readonly int initialPosY;
        private readonly int finalPosY;

        private int posX;
        private int posY;

        private int hideStartTimer = 0;

        public ToastUI(ToastNotificationType type, string message)
        {
            InitializeComponent();

            // Content
            SetLogLevelFields(type);
            lb_ToastMessage.Text = message;

            // Position
            posX = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 3;

            finalPosY = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 3;
            initialPosY = finalPosY + this.Height + 50;
            posY = initialPosY;

            this.Location = new Point(posX, posY);

            this.Focus();
        }

        private void SetLogLevelFields(ToastNotificationType type)
        {
            Color color = Color.DimGray;
            string typeMessage = string.Empty;

            switch (type)
            {
                case ToastNotificationType.Info:
                    color = Color.Green;
                    typeMessage = "Info";
                    break;
                case ToastNotificationType.Warning:
                    color = Color.Yellow;
                    typeMessage = "Warning";
                    break;
                case ToastNotificationType.Error:
                    color = Color.Red;
                    typeMessage = "Error";
                    break;
                default:
                    break;
            }

            pn_ToastColor.BackColor = color;
            lb_ToastType.Text = typeMessage;
        }

        private void tm_ToastTimer_Tick(object sender, EventArgs e)
        {
            posY -= 10;
            this.Location = new Point(posX, posY);

            if (posY <= finalPosY)
            {
                tm_ToastTimer.Stop();
                tm_ToastHide.Start();
            }
        }

        private void tm_ToastHide_Tick(object sender, EventArgs e)
        {
            hideStartTimer++;

            if (hideStartTimer >= 150)
            {
                posY += 2;
                this.Location = new Point(posX, posY);

                if (posY >= initialPosY)
                {
                    tm_ToastHide.Stop();
                    this.Close();
                }
            }
        }

        private void ToastUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
