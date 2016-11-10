namespace VisualC_Assignment4
{
    partial class StartForm
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
            this.MoneyPictureBox = new System.Windows.Forms.PictureBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SavedButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoneyPictureBox
            // 
            this.MoneyPictureBox.Location = new System.Drawing.Point(170, 54);
            this.MoneyPictureBox.Name = "MoneyPictureBox";
            this.MoneyPictureBox.Size = new System.Drawing.Size(332, 320);
            this.MoneyPictureBox.TabIndex = 0;
            this.MoneyPictureBox.TabStop = false;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(259, 380);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(160, 46);
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "Open a New Order";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // SavedButton
            // 
            this.SavedButton.Location = new System.Drawing.Point(259, 432);
            this.SavedButton.Name = "SavedButton";
            this.SavedButton.Size = new System.Drawing.Size(160, 46);
            this.SavedButton.TabIndex = 2;
            this.SavedButton.Text = "Open A Saved Order";
            this.SavedButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(259, 484);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 46);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(168, 9);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(334, 29);
            this.orderLabel.TabIndex = 4;
            this.orderLabel.Text = "Order Your Computer Today!";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 545);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavedButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.MoneyPictureBox);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Sharp Computers!";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoneyPictureBox;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SavedButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label orderLabel;
    }
}