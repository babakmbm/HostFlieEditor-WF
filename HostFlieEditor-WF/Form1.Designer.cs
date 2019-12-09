namespace HostFlieEditor_WF
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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ShowTextButton = new System.Windows.Forms.Button();
            this.AddUrlButton = new System.Windows.Forms.Button();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(0, 330);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(800, 117);
            this.OutputBox.TabIndex = 1;
            // 
            // ShowTextButton
            // 
            this.ShowTextButton.Location = new System.Drawing.Point(521, 40);
            this.ShowTextButton.Name = "ShowTextButton";
            this.ShowTextButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowTextButton.Size = new System.Drawing.Size(219, 41);
            this.ShowTextButton.TabIndex = 2;
            this.ShowTextButton.Text = "Show Text";
            this.ShowTextButton.UseVisualStyleBackColor = true;
            this.ShowTextButton.Click += new System.EventHandler(this.ShowTextButton_Click);
            // 
            // AddUrlButton
            // 
            this.AddUrlButton.Location = new System.Drawing.Point(521, 114);
            this.AddUrlButton.Name = "AddUrlButton";
            this.AddUrlButton.Size = new System.Drawing.Size(219, 40);
            this.AddUrlButton.TabIndex = 3;
            this.AddUrlButton.Text = "ADD URL";
            this.AddUrlButton.UseVisualStyleBackColor = true;
            this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
            // 
            // UrlBox
            // 
            this.UrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.Location = new System.Drawing.Point(12, 114);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(474, 36);
            this.UrlBox.TabIndex = 4;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.AddUrlButton);
            this.Controls.Add(this.ShowTextButton);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "Block Website";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ShowTextButton;
        private System.Windows.Forms.Button AddUrlButton;
        private System.Windows.Forms.TextBox UrlBox;
    }
}

