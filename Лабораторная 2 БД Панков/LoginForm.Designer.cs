namespace Лабораторная_2_БД_Панков
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема: Учет хозяйственной \r\nдеятельности ботанических \r\nсадов страны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор: Панков Е.А ПИ-21Б";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(30, 150);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(218, 30);
            this.LoginTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(30, 208);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(218, 30);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveButton.Location = new System.Drawing.Point(30, 244);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(98, 34);
            this.LeaveButton.TabIndex = 6;
            this.LeaveButton.Text = "Выйти";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(150, 244);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(98, 34);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 288);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(300, 335);
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button EnterButton;
    }
}