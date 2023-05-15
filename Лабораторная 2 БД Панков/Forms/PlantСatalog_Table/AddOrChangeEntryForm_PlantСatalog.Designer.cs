namespace Лабораторная_2_БД_Панков.Forms
{
    partial class AddOrChangeEntryForm_PlantСatalog
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
            this.однолетнее_checkBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.название_растения_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.название_вида_comboBox = new System.Windows.Forms.ComboBox();
            this.срок_жизни_растения_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.срок_жизни_растения_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // однолетнее_checkBox
            // 
            this.однолетнее_checkBox.AutoSize = true;
            this.однолетнее_checkBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.однолетнее_checkBox.Location = new System.Drawing.Point(12, 213);
            this.однолетнее_checkBox.Name = "однолетнее_checkBox";
            this.однолетнее_checkBox.Size = new System.Drawing.Size(134, 26);
            this.однолетнее_checkBox.TabIndex = 82;
            this.однолетнее_checkBox.Text = "Однолетнее";
            this.однолетнее_checkBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(148, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 75;
            this.button2.Text = "На главную";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 80;
            this.label1.Text = "Срок жизни растения";
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(13, 249);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 74;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // название_растения_textBox
            // 
            this.название_растения_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.название_растения_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_растения_textBox.Location = new System.Drawing.Point(16, 34);
            this.название_растения_textBox.Name = "название_растения_textBox";
            this.название_растения_textBox.Size = new System.Drawing.Size(274, 30);
            this.название_растения_textBox.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 22);
            this.label7.TabIndex = 76;
            this.label7.Text = "Название растения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Вид";
            // 
            // название_вида_comboBox
            // 
            this.название_вида_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.название_вида_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_вида_comboBox.FormattingEnabled = true;
            this.название_вида_comboBox.Location = new System.Drawing.Point(16, 96);
            this.название_вида_comboBox.Name = "название_вида_comboBox";
            this.название_вида_comboBox.Size = new System.Drawing.Size(274, 30);
            this.название_вида_comboBox.TabIndex = 111;
            // 
            // срок_жизни_растения_numericUpDown
            // 
            this.срок_жизни_растения_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.срок_жизни_растения_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.срок_жизни_растения_numericUpDown.Location = new System.Drawing.Point(16, 167);
            this.срок_жизни_растения_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.срок_жизни_растения_numericUpDown.Name = "срок_жизни_растения_numericUpDown";
            this.срок_жизни_растения_numericUpDown.Size = new System.Drawing.Size(274, 30);
            this.срок_жизни_растения_numericUpDown.TabIndex = 114;
            // 
            // AddOrChangeEntryForm_PlantСatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 298);
            this.Controls.Add(this.срок_жизни_растения_numericUpDown);
            this.Controls.Add(this.название_вида_comboBox);
            this.Controls.Add(this.однолетнее_checkBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.название_растения_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(320, 345);
            this.Name = "AddOrChangeEntryForm_PlantСatalog";
            this.Text = "Добавление записей в \"Каталог\"";
            this.Load += new System.EventHandler(this.AddEntryForm_PlantСatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.срок_жизни_растения_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox однолетнее_checkBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.TextBox название_растения_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox название_вида_comboBox;
        private System.Windows.Forms.NumericUpDown срок_жизни_растения_numericUpDown;
    }
}