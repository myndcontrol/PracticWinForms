namespace WinFormsApp1
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
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeColorButton.Location = new System.Drawing.Point(281, 138);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(218, 111);
            this.ChangeColorButton.TabIndex = 0;
            this.ChangeColorButton.Text = "Change Color";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButtonClick);
            this.ChangeColorButton.MouseEnter += new System.EventHandler(this.ChangeColorButton_MouseEnter);
            this.ChangeColorButton.MouseLeave += new System.EventHandler(this.ChangeColorButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeColorButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ChangeColorButton;
    }
}