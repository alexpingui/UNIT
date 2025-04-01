namespace UNIT_rebuild
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPlay
            // 
            this.MainPlay.BackColor = System.Drawing.Color.Transparent;
            this.MainPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPlay.Image = global::UNIT_rebuild.Properties.Resources.MainPlay;
            this.MainPlay.Location = new System.Drawing.Point(402, 335);
            this.MainPlay.Name = "MainPlay";
            this.MainPlay.Size = new System.Drawing.Size(200, 200);
            this.MainPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPlay.TabIndex = 0;
            this.MainPlay.TabStop = false;
            this.MainPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPlay_MouseClick);
            this.MainPlay.MouseEnter += new System.EventHandler(this.MainPlay_MouseEnter);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 977);
            this.Controls.Add(this.MainPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.MainPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPlay;
    }
}