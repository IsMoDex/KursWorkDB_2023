namespace Лабораторная_2_БД_Панков.Forms.Cities_List
{
    partial class AddOrChangeEntryForm_Cities
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
            this.название_города_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // название_города_textBox
            // 
            this.название_города_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_города_textBox.Location = new System.Drawing.Point(19, 35);
            this.название_города_textBox.Name = "название_города_textBox";
            this.название_города_textBox.Size = new System.Drawing.Size(243, 30);
            this.название_города_textBox.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Название города";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(154, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 44;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(19, 71);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 43;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // AddOrChangeEntryForm_Cities_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 118);
            this.Controls.Add(this.название_города_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.MinimumSize = new System.Drawing.Size(295, 165);
            this.Name = "AddOrChangeEntryForm_Cities_2";
            this.Text = "AddOrChangeEntryForm_Cities_2";
            this.Load += new System.EventHandler(this.AddOrChangeEntryForm_Cities_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox название_города_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
    }
}