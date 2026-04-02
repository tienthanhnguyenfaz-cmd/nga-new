namespace Database_ASM_music_store
{
    partial class Supplier_management
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
            btnExitSup = new Button();
            btnInsertSup = new Button();
            btnDeleteSup = new Button();
            btnUpdateSup = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TbAddressSup = new TextBox();
            TbPhoneNumberSup = new TextBox();
            TbSupplierNameSup = new TextBox();
            TbSupplierID = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnExitSup
            // 
            btnExitSup.Location = new Point(603, 285);
            btnExitSup.Name = "btnExitSup";
            btnExitSup.Size = new Size(94, 29);
            btnExitSup.TabIndex = 64;
            btnExitSup.Text = "Exit";
            btnExitSup.UseVisualStyleBackColor = true;
            // 
            // btnInsertSup
            // 
            btnInsertSup.Location = new Point(603, 206);
            btnInsertSup.Name = "btnInsertSup";
            btnInsertSup.Size = new Size(94, 29);
            btnInsertSup.TabIndex = 63;
            btnInsertSup.Text = "Insert";
            btnInsertSup.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSup
            // 
            btnDeleteSup.Location = new Point(603, 127);
            btnDeleteSup.Name = "btnDeleteSup";
            btnDeleteSup.Size = new Size(94, 29);
            btnDeleteSup.TabIndex = 62;
            btnDeleteSup.Text = "Delete";
            btnDeleteSup.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSup
            // 
            btnUpdateSup.Location = new Point(603, 56);
            btnUpdateSup.Name = "btnUpdateSup";
            btnUpdateSup.Size = new Size(94, 29);
            btnUpdateSup.TabIndex = 61;
            btnUpdateSup.Text = "Update";
            btnUpdateSup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 235);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 55;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 185);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 54;
            label3.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 134);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 53;
            label2.Text = "Supplier Name ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 82);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 52;
            label1.Text = "Supplier ID";
            // 
            // TbAddressSup
            // 
            TbAddressSup.Location = new Point(140, 235);
            TbAddressSup.Name = "TbAddressSup";
            TbAddressSup.Size = new Size(283, 27);
            TbAddressSup.TabIndex = 51;
            // 
            // TbPhoneNumberSup
            // 
            TbPhoneNumberSup.Location = new Point(140, 182);
            TbPhoneNumberSup.Name = "TbPhoneNumberSup";
            TbPhoneNumberSup.Size = new Size(283, 27);
            TbPhoneNumberSup.TabIndex = 50;
            // 
            // TbSupplierNameSup
            // 
            TbSupplierNameSup.Location = new Point(139, 131);
            TbSupplierNameSup.Name = "TbSupplierNameSup";
            TbSupplierNameSup.Size = new Size(283, 27);
            TbSupplierNameSup.TabIndex = 44;
            // 
            // TbSupplierID
            // 
            TbSupplierID.Location = new Point(140, 79);
            TbSupplierID.Name = "TbSupplierID";
            TbSupplierID.Size = new Size(125, 27);
            TbSupplierID.TabIndex = 43;
            // 
            // listView1
            // 
            listView1.Location = new Point(714, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 585);
            listView1.TabIndex = 42;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Supplier_management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1229, 622);
            Controls.Add(btnExitSup);
            Controls.Add(btnInsertSup);
            Controls.Add(btnDeleteSup);
            Controls.Add(btnUpdateSup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbAddressSup);
            Controls.Add(TbPhoneNumberSup);
            Controls.Add(TbSupplierNameSup);
            Controls.Add(TbSupplierID);
            Controls.Add(listView1);
            Name = "Supplier_management";
            Text = "Supplier_management";
            Load += Supplier_management_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitSup;
        private Button btnInsertSup;
        private Button btnDeleteSup;
        private Button btnUpdateSup;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TbAddressSup;
        private TextBox TbPhoneNumberSup;
        private TextBox TbSupplierNameSup;
        private TextBox TbSupplierID;
        private ListView listView1;
    }
}