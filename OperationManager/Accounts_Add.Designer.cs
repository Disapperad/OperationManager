namespace OperationManager
{
    partial class Accounts_Add
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
            this.AccountID = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountID
            // 
            this.AccountID.Location = new System.Drawing.Point(12, 7);
            this.AccountID.Name = "AccountID";
            this.AccountID.PlaceholderText = "Введите номер счёта";
            this.AccountID.Size = new System.Drawing.Size(363, 27);
            this.AccountID.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(12, 40);
            this.FullName.Name = "FullName";
            this.FullName.PlaceholderText = "Введите полное имя (Опционально)";
            this.FullName.Size = new System.Drawing.Size(363, 27);
            this.FullName.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 73);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(363, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Accounts_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(387, 108);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.AccountID);
            this.Name = "Accounts_Add";
            this.Text = "Добавить счёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AccountID;
        private TextBox FullName;
        private Button AddButton;
    }
}