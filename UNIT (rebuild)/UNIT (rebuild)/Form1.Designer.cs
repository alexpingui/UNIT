namespace UNIT_rebuild
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.YouWin = new System.Windows.Forms.PictureBox();
            this.MainMenuExit = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.YouWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            this.SuspendLayout();
            // 
            // YouWin
            // 
            this.YouWin.BackColor = System.Drawing.Color.Transparent;
            this.YouWin.Image = global::UNIT_rebuild.Properties.Resources.YouWin;
            this.YouWin.Location = new System.Drawing.Point(33, 118);
            this.YouWin.Name = "YouWin";
            this.YouWin.Size = new System.Drawing.Size(937, 595);
            this.YouWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.YouWin.TabIndex = 3;
            this.YouWin.TabStop = false;
            this.YouWin.Visible = false;
            // 
            // MainMenuExit
            // 
            this.MainMenuExit.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuExit.Image = global::UNIT_rebuild.Properties.Resources.MainMenuExit;
            this.MainMenuExit.Location = new System.Drawing.Point(583, 387);
            this.MainMenuExit.Name = "MainMenuExit";
            this.MainMenuExit.Size = new System.Drawing.Size(100, 100);
            this.MainMenuExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainMenuExit.TabIndex = 2;
            this.MainMenuExit.TabStop = false;
            this.MainMenuExit.Visible = false;
            this.MainMenuExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMenuExit_MouseClick);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::UNIT_rebuild.Properties.Resources.LevelPlay;
            this.Play.Location = new System.Drawing.Point(341, 387);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 100);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play.TabIndex = 1;
            this.Play.TabStop = false;
            this.Play.Visible = false;
            this.Play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Play_MouseClick);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Image = global::UNIT_rebuild.Properties.Resources.Pause;
            this.Pause.Location = new System.Drawing.Point(904, 12);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(90, 90);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 0;
            this.Pause.TabStop = false;
            this.Pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pause_MouseClick);
            this.Pause.MouseEnter += new System.EventHandler(this.Pause_MouseEnter);
            this.Pause.MouseLeave += new System.EventHandler(this.Pause_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 977);
            this.Controls.Add(this.MainMenuExit);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.YouWin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            ((System.ComponentModel.ISupportInitialize)(this.YouWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox MainMenuExit;
        private System.Windows.Forms.PictureBox YouWin;
    }
}

