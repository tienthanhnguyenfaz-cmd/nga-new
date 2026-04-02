namespace Database_ASM_music_store
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TbxUserName = new TextBox();
            TbxPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 101);
            label1.Name = "label1";
            label1.Size = new Size(285, 54);
            label1.TabIndex = 0;
            label1.Text = "T's instrument ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 196);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 253);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // TbxUserName
            // 
            TbxUserName.Location = new Point(182, 193);
            TbxUserName.Name = "TbxUserName";
            TbxUserName.Size = new Size(458, 27);
            TbxUserName.TabIndex = 3;
            // 
            // TbxPassword
            // 
            TbxPassword.Location = new Point(182, 250);
            TbxPassword.Name = "TbxPassword";
            TbxPassword.Size = new Size(458, 27);
            TbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(350, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._530ac4c22a7c0925b71534757c2894bf;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(TbxPassword);
            Controls.Add(TbxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TbxUserName;
        private TextBox TbxPassword;
        private Button btnLogin;
    }
}
