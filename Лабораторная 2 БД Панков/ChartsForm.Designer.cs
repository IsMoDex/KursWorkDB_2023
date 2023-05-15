namespace Лабораторная_2_БД_Панков
{
    partial class ChartsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоРастенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийВозрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоУчастковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всегоРастенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Loading_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.menuStrip1.SuspendLayout();
            this.Loading_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диаграммаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоРастенийToolStripMenuItem,
            this.среднийВозрастToolStripMenuItem,
            this.количествоУчастковToolStripMenuItem,
            this.всегоРастенийToolStripMenuItem,
            this.количествоСотрудниковToolStripMenuItem});
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            // 
            // количествоРастенийToolStripMenuItem
            // 
            this.количествоРастенийToolStripMenuItem.Name = "количествоРастенийToolStripMenuItem";
            this.количествоРастенийToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.количествоРастенийToolStripMenuItem.Text = "Количество растений";
            // 
            // среднийВозрастToolStripMenuItem
            // 
            this.среднийВозрастToolStripMenuItem.Name = "среднийВозрастToolStripMenuItem";
            this.среднийВозрастToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.среднийВозрастToolStripMenuItem.Text = "Средний возраст";
            // 
            // количествоУчастковToolStripMenuItem
            // 
            this.количествоУчастковToolStripMenuItem.Name = "количествоУчастковToolStripMenuItem";
            this.количествоУчастковToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.количествоУчастковToolStripMenuItem.Text = "Количество участков";
            // 
            // всегоРастенийToolStripMenuItem
            // 
            this.всегоРастенийToolStripMenuItem.Name = "всегоРастенийToolStripMenuItem";
            this.всегоРастенийToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.всегоРастенийToolStripMenuItem.Text = "Всего растений";
            // 
            // количествоСотрудниковToolStripMenuItem
            // 
            this.количествоСотрудниковToolStripMenuItem.Name = "количествоСотрудниковToolStripMenuItem";
            this.количествоСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.количествоСотрудниковToolStripMenuItem.Text = "Количество сотрудников";
            // 
            // Loading_panel
            // 
            this.Loading_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loading_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.Loading_panel.Controls.Add(this.label2);
            this.Loading_panel.Location = new System.Drawing.Point(12, 27);
            this.Loading_panel.Name = "Loading_panel";
            this.Loading_panel.Size = new System.Drawing.Size(776, 443);
            this.Loading_panel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(162, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Идет загрузка, подождите.";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(12, 27);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(776, 443);
            this.cartesianChart1.TabIndex = 0;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.Loading_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChartsForm";
            this.Text = "Диаграммы";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            this.SizeChanged += new System.EventHandler(this.ChartsForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Loading_panel.ResumeLayout(false);
            this.Loading_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоРастенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийВозрастToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоУчастковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всегоРастенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСотрудниковToolStripMenuItem;
        private System.Windows.Forms.Panel Loading_panel;
        private System.Windows.Forms.Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}