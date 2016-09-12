namespace ImageAnimatorDemo
{
    partial class ImageAnimatorDemo
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
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.numericUpDownFramesPerSecond = new System.Windows.Forms.NumericUpDown();
            this.radioButtonReverse = new System.Windows.Forms.RadioButton();
            this.labelFrame = new System.Windows.Forms.Label();
            this.radioButtonPing = new System.Windows.Forms.RadioButton();
            this.radioButtonLoop = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramesPerSecond)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(233, 107);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(65, 23);
            this.buttonAddFiles.TabIndex = 22;
            this.buttonAddFiles.Text = "Add Files";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFramesPerSecond
            // 
            this.numericUpDownFramesPerSecond.Location = new System.Drawing.Point(136, 110);
            this.numericUpDownFramesPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFramesPerSecond.Name = "numericUpDownFramesPerSecond";
            this.numericUpDownFramesPerSecond.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownFramesPerSecond.TabIndex = 21;
            this.numericUpDownFramesPerSecond.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // radioButtonReverse
            // 
            this.radioButtonReverse.AutoSize = true;
            this.radioButtonReverse.Location = new System.Drawing.Point(233, 70);
            this.radioButtonReverse.Name = "radioButtonReverse";
            this.radioButtonReverse.Size = new System.Drawing.Size(65, 17);
            this.radioButtonReverse.TabIndex = 20;
            this.radioButtonReverse.Text = "Reverse";
            this.radioButtonReverse.UseVisualStyleBackColor = true;
            // 
            // labelFrame
            // 
            this.labelFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFrame.Location = new System.Drawing.Point(0, 0);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(558, 18);
            this.labelFrame.TabIndex = 19;
            this.labelFrame.Text = "Frame: ";
            this.labelFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonPing
            // 
            this.radioButtonPing.AutoSize = true;
            this.radioButtonPing.Location = new System.Drawing.Point(119, 70);
            this.radioButtonPing.Name = "radioButtonPing";
            this.radioButtonPing.Size = new System.Drawing.Size(68, 17);
            this.radioButtonPing.TabIndex = 18;
            this.radioButtonPing.Text = "Pin Pong";
            this.radioButtonPing.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoop
            // 
            this.radioButtonLoop.AutoSize = true;
            this.radioButtonLoop.Checked = true;
            this.radioButtonLoop.Location = new System.Drawing.Point(24, 70);
            this.radioButtonLoop.Name = "radioButtonLoop";
            this.radioButtonLoop.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLoop.TabIndex = 17;
            this.radioButtonLoop.TabStop = true;
            this.radioButtonLoop.Text = "Loop";
            this.radioButtonLoop.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(249, 31);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(50, 23);
            this.buttonNext.TabIndex = 16;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(194, 31);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(50, 23);
            this.buttonPrev.TabIndex = 15;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(105, 31);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(24, 31);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(23, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(512, 188);
            this.panelDraw.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Frames per second: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAddFiles);
            this.panel1.Controls.Add(this.numericUpDownFramesPerSecond);
            this.panel1.Controls.Add(this.radioButtonReverse);
            this.panel1.Controls.Add(this.labelFrame);
            this.panel1.Controls.Add(this.radioButtonPing);
            this.panel1.Controls.Add(this.radioButtonLoop);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 145);
            this.panel1.TabIndex = 24;
            // 
            // ImageAnimatorDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ImageAnimatorDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageAnimator Demo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramesPerSecond)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.NumericUpDown numericUpDownFramesPerSecond;
        private System.Windows.Forms.RadioButton radioButtonReverse;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.RadioButton radioButtonPing;
        private System.Windows.Forms.RadioButton radioButtonLoop;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

