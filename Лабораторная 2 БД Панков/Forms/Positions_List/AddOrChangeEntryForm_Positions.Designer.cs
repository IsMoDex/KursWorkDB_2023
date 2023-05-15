namespace Лабораторная_2_БД_Панков.Forms
{
    partial class AddOrChangeEntryForm_Positions
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
            this.button2 = new System.Windows.Forms.Button();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.название_должности_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(151, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(16, 70);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 35;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // название_должности_textBox
            // 
            this.название_должности_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_должности_textBox.Location = new System.Drawing.Point(16, 34);
            this.название_должности_textBox.Name = "название_должности_textBox";
            this.название_должности_textBox.Size = new System.Drawing.Size(243, 30);
            this.название_должности_textBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название должности";
            // 
            // AddOrChangeEntryForm_Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 118);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.название_должности_textBox);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(290, 165);
            this.Name = "AddOrChangeEntryForm_Positions";
            this.Text = "Добавление записей в \"Должности\"";
            this.Load += new System.EventHandler(this.AddOrChangeEntryForm_Positions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.TextBox название_должности_textBox;
        private System.Windows.Forms.Label label2;
    }
}