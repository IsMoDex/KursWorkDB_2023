namespace Лабораторная_2_БД_Панков
{
    partial class CompositeForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CountEntryLable = new System.Windows.Forms.Label();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.CountEntry_2_Lable = new System.Windows.Forms.Label();
            this.dataGridView_sub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sub)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CountEntryLable);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CountEntry_2_Lable);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_sub);
            this.splitContainer1.Size = new System.Drawing.Size(883, 537);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // CountEntryLable
            // 
            this.CountEntryLable.AutoSize = true;
            this.CountEntryLable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountEntryLable.Location = new System.Drawing.Point(12, 9);
            this.CountEntryLable.Name = "CountEntryLable";
            this.CountEntryLable.Size = new System.Drawing.Size(165, 19);
            this.CountEntryLable.TabIndex = 120;
            this.CountEntryLable.Text = "| Записей: Не выбрано";
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(12, 31);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersVisible = false;
            this.dataGridView_main.RowHeadersWidth = 51;
            this.dataGridView_main.RowTemplate.Height = 24;
            this.dataGridView_main.Size = new System.Drawing.Size(859, 259);
            this.dataGridView_main.TabIndex = 12;
            this.dataGridView_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellClick);
            // 
            // CountEntry_2_Lable
            // 
            this.CountEntry_2_Lable.AutoSize = true;
            this.CountEntry_2_Lable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountEntry_2_Lable.Location = new System.Drawing.Point(12, 0);
            this.CountEntry_2_Lable.Name = "CountEntry_2_Lable";
            this.CountEntry_2_Lable.Size = new System.Drawing.Size(165, 19);
            this.CountEntry_2_Lable.TabIndex = 121;
            this.CountEntry_2_Lable.Text = "| Записей: Не выбрано";
            // 
            // dataGridView_sub
            // 
            this.dataGridView_sub.AllowUserToAddRows = false;
            this.dataGridView_sub.AllowUserToDeleteRows = false;
            this.dataGridView_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sub.Location = new System.Drawing.Point(12, 22);
            this.dataGridView_sub.Name = "dataGridView_sub";
            this.dataGridView_sub.ReadOnly = true;
            this.dataGridView_sub.RowHeadersVisible = false;
            this.dataGridView_sub.RowHeadersWidth = 51;
            this.dataGridView_sub.RowTemplate.Height = 24;
            this.dataGridView_sub.Size = new System.Drawing.Size(859, 206);
            this.dataGridView_sub.TabIndex = 13;
            // 
            // CompositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 537);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CompositeForm";
            this.Text = "CompositeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompositeForm_FormClosed);
            this.Load += new System.EventHandler(this.CompositeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.DataGridView dataGridView_sub;
        private System.Windows.Forms.Label CountEntryLable;
        private System.Windows.Forms.Label CountEntry_2_Lable;
    }
}