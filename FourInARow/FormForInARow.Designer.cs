namespace FourInARow
{
    partial class FormForInARow
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
            this.BtnFourInARow = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFourInARow
            // 
            this.BtnFourInARow.Location = new System.Drawing.Point(55, 72);
            this.BtnFourInARow.Name = "BtnFourInARow";
            this.BtnFourInARow.Size = new System.Drawing.Size(188, 61);
            this.BtnFourInARow.TabIndex = 0;
            this.BtnFourInARow.Text = "Four In A Row";
            this.BtnFourInARow.UseVisualStyleBackColor = true;
            this.BtnFourInARow.Click += new System.EventHandler(this.BtnFourInARow_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(339, 74);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(423, 335);
            this.TxtResult.TabIndex = 1;
            // 
            // FormForInARow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnFourInARow);
            this.Name = "FormForInARow";
            this.Text = "For In A Row";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFourInARow;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

