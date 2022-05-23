namespace OperationManager
{
    partial class Operations_Add
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
            this.TextBox_From = new System.Windows.Forms.TextBox();
            this.TextBox_To = new System.Windows.Forms.TextBox();
            this.TextBox_Cash = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_From
            // 
            this.TextBox_From.Location = new System.Drawing.Point(12, 12);
            this.TextBox_From.Name = "TextBox_From";
            this.TextBox_From.PlaceholderText = "Введите счёт отправителя";
            this.TextBox_From.Size = new System.Drawing.Size(257, 23);
            this.TextBox_From.TabIndex = 0;
            // 
            // TextBox_To
            // 
            this.TextBox_To.Location = new System.Drawing.Point(12, 41);
            this.TextBox_To.Name = "TextBox_To";
            this.TextBox_To.PlaceholderText = "Введите счёт получателя";
            this.TextBox_To.Size = new System.Drawing.Size(257, 23);
            this.TextBox_To.TabIndex = 1;
            // 
            // TextBox_Cash
            // 
            this.TextBox_Cash.Location = new System.Drawing.Point(12, 70);
            this.TextBox_Cash.Name = "TextBox_Cash";
            this.TextBox_Cash.PlaceholderText = "Введите сумму";
            this.TextBox_Cash.Size = new System.Drawing.Size(257, 23);
            this.TextBox_Cash.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(12, 99);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(257, 34);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Выполнить транзакцию";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Operations_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(281, 145);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TextBox_Cash);
            this.Controls.Add(this.TextBox_To);
            this.Controls.Add(this.TextBox_From);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Operations_Add";
            this.Text = "Транзакция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox_From;
        private TextBox TextBox_To;
        private TextBox TextBox_Cash;
        private Button ConfirmButton;
    }
}