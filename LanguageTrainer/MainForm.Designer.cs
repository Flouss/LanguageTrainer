namespace LanguageTrainer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImages = new System.Windows.Forms.Button();
            this.btnTexts = new System.Windows.Forms.Button();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImages);
            this.panel1.Controls.Add(this.btnTexts);
            this.panel1.Controls.Add(this.btnNumbers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnImages
            // 
            this.btnImages.Image = ((System.Drawing.Image)(resources.GetObject("btnImages.Image")));
            this.btnImages.Location = new System.Drawing.Point(537, 149);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(171, 153);
            this.btnImages.TabIndex = 2;
            this.btnImages.Text = "Images";
            this.btnImages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImages.UseVisualStyleBackColor = true;
            // 
            // btnTexts
            // 
            this.btnTexts.Image = ((System.Drawing.Image)(resources.GetObject("btnTexts.Image")));
            this.btnTexts.Location = new System.Drawing.Point(305, 149);
            this.btnTexts.Name = "btnTexts";
            this.btnTexts.Size = new System.Drawing.Size(171, 153);
            this.btnTexts.TabIndex = 1;
            this.btnTexts.Text = "Texts";
            this.btnTexts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTexts.UseVisualStyleBackColor = true;
            this.btnTexts.Click += new System.EventHandler(this.btnTexts_Click);
            // 
            // btnNumbers
            // 
            this.btnNumbers.Image = ((System.Drawing.Image)(resources.GetObject("btnNumbers.Image")));
            this.btnNumbers.Location = new System.Drawing.Point(61, 149);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(171, 153);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Language Trainer";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.Button btnTexts;
    }
}

