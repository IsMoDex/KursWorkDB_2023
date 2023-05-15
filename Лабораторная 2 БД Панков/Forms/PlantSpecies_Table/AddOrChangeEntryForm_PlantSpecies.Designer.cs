namespace Лабораторная_2_БД_Панков.Forms
{
    partial class AddOrChangeEntryForm_PlantSpecies
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
            this.label3 = new System.Windows.Forms.Label();
            this.название_вида_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.название_семейства_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Семейство";
            // 
            // название_вида_textBox
            // 
            this.название_вида_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_вида_textBox.Location = new System.Drawing.Point(12, 34);
            this.название_вида_textBox.Name = "название_вида_textBox";
            this.название_вида_textBox.Size = new System.Drawing.Size(252, 30);
            this.название_вида_textBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Название вида";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(147, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 77;
            this.button2.Text = "На глвную";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(12, 139);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 76;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // название_семейства_comboBox
            // 
            this.название_семейства_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.название_семейства_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_семейства_comboBox.FormattingEnabled = true;
            this.название_семейства_comboBox.Location = new System.Drawing.Point(16, 103);
            this.название_семейства_comboBox.Name = "название_семейства_comboBox";
            this.название_семейства_comboBox.Size = new System.Drawing.Size(248, 30);
            this.название_семейства_comboBox.TabIndex = 112;
            // 
            // AddOrChangeEntryForm_PlantSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 188);
            this.Controls.Add(this.название_семейства_comboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.название_вида_textBox);
            this.Controls.Add(this.label2);
            this.Name = "AddOrChangeEntryForm_PlantSpecies";
            this.Text = "Добавление записей в \"Виды растений\"";
            this.Load += new System.EventHandler(this.AddEntryFormForm_PlantSpecies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox название_вида_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.ComboBox название_семейства_comboBox;
    }
}