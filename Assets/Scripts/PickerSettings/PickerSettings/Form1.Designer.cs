
namespace PickerSettings
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
            this.ChanceToChangeDiractions = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChanceToChangeDiractions
            // 
            this.ChanceToChangeDiractions.Location = new System.Drawing.Point(408, 91);
            this.ChanceToChangeDiractions.Name = "ChanceToChangeDiractions";
            this.ChanceToChangeDiractions.Size = new System.Drawing.Size(256, 39);
            this.ChanceToChangeDiractions.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 39);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Chance to change directions";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(931, 75);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(317, 70);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm =>";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 763);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ChanceToChangeDiractions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChanceToChangeDiractions;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ConfirmButton;
    }
}

