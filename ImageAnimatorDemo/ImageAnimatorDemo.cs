using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ImageAnimator = Kstudio.Forms.ImageAnimator;

namespace ImageAnimatorDemo
{
    public partial class ImageAnimatorDemo : Form
    {
        private Kstudio.Forms.ImageAnimator animator;

        public ImageAnimatorDemo()
        {
            InitializeComponent();

            this.radioButtonLoop.Tag = Kstudio.Forms.ImageAnimator.AnimationType.Loop;
            this.radioButtonPing.Tag = Kstudio.Forms.ImageAnimator.AnimationType.PinPong;
            this.radioButtonReverse.Tag = Kstudio.Forms.ImageAnimator.AnimationType.Reverse;

            this.radioButtonLoop.CheckedChanged += radioButton_CheckedChanged;
            this.radioButtonPing.CheckedChanged += radioButton_CheckedChanged;
            this.radioButtonReverse.CheckedChanged += radioButton_CheckedChanged;

            this.buttonStop.Click += buttonStop_Click;
            this.buttonStart.Click += buttonStart_Click;
            this.buttonPrev.Click += buttonPrev_Click;
            this.buttonNext.Click += buttonNext_Click;

            this.numericUpDownFramesPerSecond.ValueChanged += numericUpDownFramesPerSecond_ValueChanged;

            StartAnimation();
        }

        private void StartAnimation()
        {
            animator = new Kstudio.Forms.ImageAnimator();
            animator.UpdateFrame += animator_UpdateFrame;

            List<Image> images = new List<Image>();
            var parentDir = Path.GetDirectoryName(Application.ExecutablePath);
            parentDir = Path.GetDirectoryName(parentDir);
            parentDir = Path.GetDirectoryName(parentDir);
            parentDir = Path.Combine(parentDir, "Images");

            if (Directory.Exists(parentDir))
            {
                var files = Directory.GetFiles(parentDir, "*.png");
                foreach (var file in files)
                {
                    using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                        images.Add(Image.FromStream(stream));
                }
                animator.AddImages(images);
                animator.FramesPerSecond = (double) numericUpDownFramesPerSecond.Value;
                animator.Type = ImageAnimator.AnimationType.Loop;
                animator.Start();
            }
        }

        private void animator_UpdateFrame(object sender, Kstudio.Forms.ImageAnimator.ImageAnimatorEventArgs e)
        {
            if (Disposing || this.IsDisposed || this.panelDraw.IsDisposed || this.panelDraw.Disposing || !this.panelDraw.Visible)
                return;

            using (var gfs = this.panelDraw.CreateGraphics())
            {
                gfs.DrawImage(e.Image, 0, 0, e.Image.Width, e.Image.Height);
            }
            labelFrame.Text = e.Frame.ToString();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            animator.Stop();
            base.OnClosing(e);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            animator.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            animator.Stop();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            animator.PrevFrame();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            animator.NextFrame();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var control = (RadioButton)sender;
            if (control.Checked)
                animator.Type = (ImageAnimator.AnimationType)control.Tag;
        }

        private void numericUpDownFramesPerSecond_ValueChanged(object sender, EventArgs e)
        {
            animator.FramesPerSecond = (double)numericUpDownFramesPerSecond.Value;
        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Multiselect = true,
                InitialDirectory = @"H:\!!!My_Work\!_Maps\_3d models\People\!!!_Motions\Bip\Play\",
                Filter = "Bip animation files (*.bip)|*.bip"
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && dialog.FileNames.Length > 0)
            {
                List<Image> images = new List<Image>();
                foreach (var file in dialog.FileNames)
                {
                    using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                        images.Add(Image.FromStream(stream));
                }
                animator.AddImages(images);
            }
        }
    }
}
