namespace Лабораторная_2_БД_Панков
{
    partial class Select_And_Delete_Line_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteLineButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentSelectTableLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DeleteLineButton
            // 
            this.DeleteLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteLineButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLineButton.Location = new System.Drawing.Point(550, 490);
            this.DeleteLineButton.Name = "DeleteLineButton";
            this.DeleteLineButton.Size = new System.Drawing.Size(238, 39);
            this.DeleteLineButton.TabIndex = 2;
            this.DeleteLineButton.Text = "Удалить выбранное";
            this.DeleteLineButton.UseVisualStyleBackColor = true;
            this.DeleteLineButton.Click += new System.EventHandler(this.DeleteLineButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(794, 490);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 39);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберете данные которые хотите удалить";
            // 
            // CurrentSelectTableLable
            // 
            this.CurrentSelectTableLable.AutoSize = true;
            this.CurrentSelectTableLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentSelectTableLable.Location = new System.Drawing.Point(426, 9);
            this.CurrentSelectTableLable.Name = "CurrentSelectTableLable";
            this.CurrentSelectTableLable.Size = new System.Drawing.Size(196, 22);
            this.CurrentSelectTableLable.TabIndex = 5;
            this.CurrentSelectTableLable.Text = "Текущая таблица: null";
            // 
            // Select_And_Delete_Line_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 541);
            this.Controls.Add(this.CurrentSelectTableLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteLineButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Select_And_Delete_Line_Form";
            this.Text = "Выбрать записи и удалить";
            this.Load += new System.EventHandler(this.Select_And_Delete_Line_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteLineButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentSelectTableLable;
    }
}