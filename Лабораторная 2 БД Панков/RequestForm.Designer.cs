namespace Лабораторная_2_БД_Панков
{
    partial class RequestForm
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
            this.RequestList_ComboBox = new System.Windows.Forms.ComboBox();
            this.StartRequest_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Parameter_TextBox = new System.Windows.Forms.TextBox();
            this.dataGridView_RequestTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВEXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.техническиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсовыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountEtryLable = new System.Windows.Forms.Label();
            this.Loading_panel = new System.Windows.Forms.Panel();
            this.Loading_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Parameter_two_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Loading_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запрос:";
            // 
            // RequestList_ComboBox
            // 
            this.RequestList_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestList_ComboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestList_ComboBox.FormattingEnabled = true;
            this.RequestList_ComboBox.Location = new System.Drawing.Point(105, 28);
            this.RequestList_ComboBox.Name = "RequestList_ComboBox";
            this.RequestList_ComboBox.Size = new System.Drawing.Size(737, 34);
            this.RequestList_ComboBox.TabIndex = 1;
            this.RequestList_ComboBox.SelectedIndexChanged += new System.EventHandler(this.RequestList_ComboBox_SelectedIndexChanged);
            // 
            // StartRequest_Button
            // 
            this.StartRequest_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartRequest_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartRequest_Button.Location = new System.Drawing.Point(848, 25);
            this.StartRequest_Button.Name = "StartRequest_Button";
            this.StartRequest_Button.Size = new System.Drawing.Size(197, 34);
            this.StartRequest_Button.TabIndex = 2;
            this.StartRequest_Button.Text = "Выполнить";
            this.StartRequest_Button.UseVisualStyleBackColor = true;
            this.StartRequest_Button.Click += new System.EventHandler(this.StartRequest_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Параметр:";
            // 
            // Parameter_TextBox
            // 
            this.Parameter_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter_TextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parameter_TextBox.Location = new System.Drawing.Point(17, 94);
            this.Parameter_TextBox.Name = "Parameter_TextBox";
            this.Parameter_TextBox.Size = new System.Drawing.Size(1028, 34);
            this.Parameter_TextBox.TabIndex = 4;
            // 
            // dataGridView_RequestTable
            // 
            this.dataGridView_RequestTable.AllowUserToAddRows = false;
            this.dataGridView_RequestTable.AllowUserToDeleteRows = false;
            this.dataGridView_RequestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RequestTable.Location = new System.Drawing.Point(17, 200);
            this.dataGridView_RequestTable.Name = "dataGridView_RequestTable";
            this.dataGridView_RequestTable.ReadOnly = true;
            this.dataGridView_RequestTable.RowHeadersVisible = false;
            this.dataGridView_RequestTable.RowHeadersWidth = 51;
            this.dataGridView_RequestTable.RowTemplate.Height = 24;
            this.dataGridView_RequestTable.Size = new System.Drawing.Size(1025, 488);
            this.dataGridView_RequestTable.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 30);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВEXCELToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВEXCELToolStripMenuItem
            // 
            this.сохранитьВEXCELToolStripMenuItem.Name = "сохранитьВEXCELToolStripMenuItem";
            this.сохранитьВEXCELToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.сохранитьВEXCELToolStripMenuItem.Text = "Сохранить в EXCEL";
            this.сохранитьВEXCELToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВEXCELToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простыеToolStripMenuItem,
            this.сложныеToolStripMenuItem,
            this.техническиеToolStripMenuItem,
            this.курсовыеToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // простыеToolStripMenuItem
            // 
            this.простыеToolStripMenuItem.Name = "простыеToolStripMenuItem";
            this.простыеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.простыеToolStripMenuItem.Text = "Простые";
            // 
            // сложныеToolStripMenuItem
            // 
            this.сложныеToolStripMenuItem.Name = "сложныеToolStripMenuItem";
            this.сложныеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.сложныеToolStripMenuItem.Text = "Сложные";
            // 
            // техническиеToolStripMenuItem
            // 
            this.техническиеToolStripMenuItem.Name = "техническиеToolStripMenuItem";
            this.техническиеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.техническиеToolStripMenuItem.Text = "Технические";
            // 
            // курсовыеToolStripMenuItem
            // 
            this.курсовыеToolStripMenuItem.Name = "курсовыеToolStripMenuItem";
            this.курсовыеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.курсовыеToolStripMenuItem.Text = "Курсовые";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // CountEtryLable
            // 
            this.CountEtryLable.AutoSize = true;
            this.CountEtryLable.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountEtryLable.Location = new System.Drawing.Point(130, 65);
            this.CountEtryLable.Name = "CountEtryLable";
            this.CountEtryLable.Size = new System.Drawing.Size(228, 26);
            this.CountEtryLable.TabIndex = 13;
            this.CountEtryLable.Text = "| Записей: Не выбрано";
            // 
            // Loading_panel
            // 
            this.Loading_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loading_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.Loading_panel.Controls.Add(this.Loading_label);
            this.Loading_panel.Location = new System.Drawing.Point(17, 200);
            this.Loading_panel.Name = "Loading_panel";
            this.Loading_panel.Size = new System.Drawing.Size(1025, 488);
            this.Loading_panel.TabIndex = 15;
            // 
            // Loading_label
            // 
            this.Loading_label.AutoSize = true;
            this.Loading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loading_label.Location = new System.Drawing.Point(295, 221);
            this.Loading_label.Name = "Loading_label";
            this.Loading_label.Size = new System.Drawing.Size(430, 38);
            this.Loading_label.TabIndex = 0;
            this.Loading_label.Text = "Идет загрузка, подождите.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Параметр 2:";
            // 
            // Parameter_two_TextBox
            // 
            this.Parameter_two_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter_two_TextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parameter_two_TextBox.Location = new System.Drawing.Point(17, 160);
            this.Parameter_two_TextBox.Name = "Parameter_two_TextBox";
            this.Parameter_two_TextBox.Size = new System.Drawing.Size(1028, 34);
            this.Parameter_two_TextBox.TabIndex = 17;
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 700);
            this.Controls.Add(this.Parameter_two_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Loading_panel);
            this.Controls.Add(this.CountEtryLable);
            this.Controls.Add(this.dataGridView_RequestTable);
            this.Controls.Add(this.Parameter_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartRequest_Button);
            this.Controls.Add(this.RequestList_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.SizeChanged += new System.EventHandler(this.RequestForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RequestTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Loading_panel.ResumeLayout(false);
            this.Loading_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RequestList_ComboBox;
        private System.Windows.Forms.Button StartRequest_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Parameter_TextBox;
        private System.Windows.Forms.DataGridView dataGridView_RequestTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВEXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсовыеToolStripMenuItem;
        private System.Windows.Forms.Label CountEtryLable;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel Loading_panel;
        private System.Windows.Forms.Label Loading_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Parameter_two_TextBox;
        private System.Windows.Forms.ToolStripMenuItem техническиеToolStripMenuItem;
    }
}