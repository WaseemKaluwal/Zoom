namespace Zoom
{
    partial class Form1
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
            pnlContainer = new Panel();
            pictureBox1 = new PictureBox();
            btnZoomIn = new Button();
            btnZoomOut = new Button();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pictureBox1);
            pnlContainer.Dock = DockStyle.Right;
            pnlContainer.Location = new Point(118, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(632, 429);
            pnlContainer.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels;
            pictureBox1.Location = new Point(3, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(12, 88);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(94, 29);
            btnZoomIn.TabIndex = 1;
            btnZoomIn.Text = "Zoom In";
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(12, 246);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(94, 29);
            btnZoomOut.TabIndex = 2;
            btnZoomOut.Text = "Zoom Out";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 429);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            Controls.Add(pnlContainer);
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private PictureBox pictureBox1;
    }
}
