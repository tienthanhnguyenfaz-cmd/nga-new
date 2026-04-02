namespace Database_ASM_music_store
{
    partial class Customer_management
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
            btnExitCus = new Button();
            btnInsertCus = new Button();
            btnDeleteCus = new Button();
            btnUpdateCus = new Button();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TbPhoneNumberCus = new TextBox();
            TbAddressCus = new TextBox();
            TbEmailCus = new TextBox();
            TbCustomerName = new TextBox();
            TbCustomerID = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnExitCus
            // 
            btnExitCus.Location = new Point(595, 271);
            btnExitCus.Name = "btnExitCus";
            btnExitCus.Size = new Size(94, 29);
            btnExitCus.TabIndex = 64;
            btnExitCus.Text = "Exit";
            btnExitCus.UseVisualStyleBackColor = true;
            // 
            // btnInsertCus
            // 
            btnInsertCus.Location = new Point(595, 192);
            btnInsertCus.Name = "btnInsertCus";
            btnInsertCus.Size = new Size(94, 29);
            btnInsertCus.TabIndex = 63;
            btnInsertCus.Text = "Insert";
            btnInsertCus.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCus
            // 
            btnDeleteCus.Location = new Point(595, 113);
            btnDeleteCus.Name = "btnDeleteCus";
            btnDeleteCus.Size = new Size(94, 29);
            btnDeleteCus.TabIndex = 62;
            btnDeleteCus.Text = "Delete";
            btnDeleteCus.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCus
            // 
            btnUpdateCus.Location = new Point(595, 42);
            btnUpdateCus.Name = "btnUpdateCus";
            btnUpdateCus.Size = new Size(94, 29);
            btnUpdateCus.TabIndex = 61;
            btnUpdateCus.Text = "Update";
            btnUpdateCus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 288);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 58;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 232);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 57;
            label6.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 179);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 54;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 53;
            label2.Text = "Customer name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 76);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 52;
            label1.Text = "Customer ID";
            // 
            // TbPhoneNumberCus
            // 
            TbPhoneNumberCus.Location = new Point(149, 176);
            TbPhoneNumberCus.Name = "TbPhoneNumberCus";
            TbPhoneNumberCus.Size = new Size(283, 27);
            TbPhoneNumberCus.TabIndex = 50;
            // 
            // TbAddressCus
            // 
            TbAddressCus.Location = new Point(149, 285);
            TbAddressCus.Name = "TbAddressCus";
            TbAddressCus.Size = new Size(283, 27);
            TbAddressCus.TabIndex = 47;
            // 
            // TbEmailCus
            // 
            TbEmailCus.Location = new Point(149, 232);
            TbEmailCus.Name = "TbEmailCus";
            TbEmailCus.Size = new Size(283, 27);
            TbEmailCus.TabIndex = 46;
            // 
            // TbCustomerName
            // 
            TbCustomerName.Location = new Point(149, 125);
            TbCustomerName.Name = "TbCustomerName";
            TbCustomerName.Size = new Size(283, 27);
            TbCustomerName.TabIndex = 44;
            TbCustomerName.TextChanged += TbNameEm_TextChanged;
            // 
            // TbCustomerID
            // 
            TbCustomerID.Location = new Point(149, 73);
            TbCustomerID.Name = "TbCustomerID";
            TbCustomerID.Size = new Size(125, 27);
            TbCustomerID.TabIndex = 43;
            // 
            // listView1
            // 
            listView1.Location = new Point(710, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 585);
            listView1.TabIndex = 42;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Customer_management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1232, 609);
            Controls.Add(btnExitCus);
            Controls.Add(btnInsertCus);
            Controls.Add(btnDeleteCus);
            Controls.Add(btnUpdateCus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbPhoneNumberCus);
            Controls.Add(TbAddressCus);
            Controls.Add(TbEmailCus);
            Controls.Add(TbCustomerName);
            Controls.Add(TbCustomerID);
            Controls.Add(listView1);
            Name = "Customer_management";
            Text = "Customer_management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitCus;
        private Button btnInsertCus;
        private Button btnDeleteCus;
        private Button btnUpdateCus;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TbPhoneNumberCus;
        private TextBox TbAddressCus;
        private TextBox TbEmailCus;
        private TextBox TbCustomerName;
        private TextBox TbCustomerID;
        private ListView listView1;
    }
}