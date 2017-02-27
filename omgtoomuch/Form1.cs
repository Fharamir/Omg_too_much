using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace omgtoomuch
{
    public partial class Form1 : Form
    {
        ulong TotalRam;

        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_this(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transparency(object sender, EventArgs e)
        {
            this.TopMost = true;
            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;

            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - 50);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width - 10;
            bar.Width = this.Width - 12;
            label1.Location = new Point(this.Width - 8, label1.Location.Y);
            TotalRam = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (ulong)(1024 * 1024);
            bar.Maximum = 1000;
            bar.Minimum = 0;
            bar.Value = 0;

            TT.Interval = 30;
            TT.Start();
        }

        private void bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            TT.Stop();
        }

        private void bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            TT.Start();
        }

        private void Check(object sender, EventArgs e)
        {
            int val = 1000 - ((int)(Math.Round((double)(getAvailableRAM() * 100 / TotalRam),1)) * 10);
            if (val < 0) val = 0;
            if (val > 1000) val = 1000;

            if (val < 500)
            { ModifyProgressBarColor.SetState(bar, 1); }
            else
                if (val < 750)
                { ModifyProgressBarColor.SetState(bar, 3); }
                else
                { ModifyProgressBarColor.SetState(bar, 2); }

            bar.Value = val;
        }

        public ulong getAvailableRAM()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory / (ulong)(1024 * 1024);
        }
    }
}
