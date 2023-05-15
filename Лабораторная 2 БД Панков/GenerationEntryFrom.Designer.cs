namespace Лабораторная_2_БД_Панков
{
    partial class GenerationEntryFrom
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
            this.CountEntryToGenerate_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectedTableComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.CountEntryToGenerate_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица для генерации";
            // 
            // CountEntryToGenerate_NumericUpDown
            // 
            this.CountEntryToGenerate_NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountEntryToGenerate_NumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountEntryToGenerate_NumericUpDown.Location = new System.Drawing.Point(15, 123);
            this.CountEntryToGenerate_NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CountEntryToGenerate_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountEntryToGenerate_NumericUpDown.Name = "CountEntryToGenerate_NumericUpDown";
            this.CountEntryToGenerate_NumericUpDown.Size = new System.Drawing.Size(274, 30);
            this.CountEntryToGenerate_NumericUpDown.TabIndex = 1;
            this.CountEntryToGenerate_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SelectedTableComboBox
            // 
            this.SelectedTableComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedTableComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedTableComboBox.FormattingEnabled = true;
            this.SelectedTableComboBox.Location = new System.Drawing.Point(16, 56);
            this.SelectedTableComboBox.Name = "SelectedTableComboBox";
            this.SelectedTableComboBox.Size = new System.Drawing.Size(273, 30);
            this.SelectedTableComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество записей";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(16, 159);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(162, 34);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(184, 159);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 34);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // GenerationEntryFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 203);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectedTableComboBox);
            this.Controls.Add(this.CountEntryToGenerate_NumericUpDown);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(320, 250);
            this.Name = "GenerationEntryFrom";
            this.Text = "GenerationEntryFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerationEntryFrom_FormClosing);
            this.Load += new System.EventHandler(this.GenerationEntryFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountEntryToGenerate_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CountEntryToGenerate_NumericUpDown;
        private System.Windows.Forms.ComboBox SelectedTableComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}