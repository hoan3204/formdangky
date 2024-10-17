namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtName = new TextBox();
            TxtPassword = new TextBox();
            TxtEmail = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(285, 327);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 86);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng ký:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 152);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 214);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(274, 86);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 4;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(274, 149);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(125, 27);
            TxtPassword.TabIndex = 5;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(274, 207);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(125, 27);
            TxtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 22);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 7;
            label4.Text = "Đăng ký tài khoản";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(TxtEmail);
            Controls.Add(TxtPassword);
            Controls.Add(TxtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtName;
        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private Label label4;
    }
}
