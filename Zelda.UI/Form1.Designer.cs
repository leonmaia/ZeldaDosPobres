namespace ZeldaDosPobres.UI
{
    partial class Form1
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
            this.masmorra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.masmorra)).BeginInit();
            this.SuspendLayout();
            // 
            // masmorra
            // 
            this.masmorra.Image = global::ZeldaDosPobres.UI.Properties.Resources.dungeon600x400;
            this.masmorra.Location = new System.Drawing.Point(0, 0);
            this.masmorra.Name = "masmorra";
            this.masmorra.Size = new System.Drawing.Size(600, 400);
            this.masmorra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.masmorra.TabIndex = 0;
            this.masmorra.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.masmorra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.masmorra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox masmorra;
    }
}

