namespace Лабораторная_2_БД_Панков
{
    partial class Type_Delete_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteLineButton = new System.Windows.Forms.Button();
            this.DeleteMeaningButton = new System.Windows.Forms.Button();
            this.DeleteAllDataInTableButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбирите тип удаления";
            // 
            // DeleteLineButton
            // 
            this.DeleteLineButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLineButton.Location = new System.Drawing.Point(44, 45);
            this.DeleteLineButton.Name = "DeleteLineButton";
            this.DeleteLineButton.Size = new System.Drawing.Size(238, 39);
            this.DeleteLineButton.TabIndex = 1;
            this.DeleteLineButton.Text = "Удаление строк";
            this.DeleteLineButton.UseVisualStyleBackColor = true;
            this.DeleteLineButton.Click += new System.EventHandler(this.DeleteLineButton_Click);
            // 
            // DeleteMeaningButton
            // 
            this.DeleteMeaningButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMeaningButton.Location = new System.Drawing.Point(44, 90);
            this.DeleteMeaningButton.Name = "DeleteMeaningButton";
            this.DeleteMeaningButton.Size = new System.Drawing.Size(238, 39);
            this.DeleteMeaningButton.TabIndex = 2;
            this.DeleteMeaningButton.Text = "Удаление по значению";
            this.DeleteMeaningButton.UseVisualStyleBackColor = true;
            this.DeleteMeaningButton.Click += new System.EventHandler(this.DeleteMeaningButton_Click);
            // 
            // DeleteAllDataInTableButton
            // 
            this.DeleteAllDataInTableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAllDataInTableButton.Location = new System.Drawing.Point(44, 135);
            this.DeleteAllDataInTableButton.Name = "DeleteAllDataInTableButton";
            this.DeleteAllDataInTableButton.Size = new System.Drawing.Size(238, 39);
            this.DeleteAllDataInTableButton.TabIndex = 3;
            this.DeleteAllDataInTableButton.Text = "Удалить все записи";
            this.DeleteAllDataInTableButton.UseVisualStyleBackColor = true;
            this.DeleteAllDataInTableButton.Click += new System.EventHandler(this.DeleteAllDataInTableButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(164, 180);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 39);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Type_Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 233);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteAllDataInTableButton);
            this.Controls.Add(this.DeleteMeaningButton);
            this.Controls.Add(this.DeleteLineButton);
            this.Controls.Add(this.label1);
            this.Name = "Type_Delete_Form";
            this.Text = "Тип удаления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteLineButton;
        private System.Windows.Forms.Button DeleteMeaningButton;
        private System.Windows.Forms.Button DeleteAllDataInTableButton;
        private System.Windows.Forms.Button CancelButton;
    }
}