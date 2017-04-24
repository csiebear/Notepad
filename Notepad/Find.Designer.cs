namespace Notepad
{
    partial class Find
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.CancelButton.Location = new System.Drawing.Point(312, 111);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 29);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.FindButton.Location = new System.Drawing.Point(203, 111);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(95, 29);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "尋找";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "尋找目標：";
            // 
            // TargetText
            // 
            this.TargetText.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.TargetText.Location = new System.Drawing.Point(127, 54);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(280, 27);
            this.TargetText.TabIndex = 6;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 161);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Find";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TargetText;
    }
}