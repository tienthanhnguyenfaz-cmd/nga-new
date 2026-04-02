namespace Database_ASM_music_store
{
    partial class Category
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TbDescription = new TextBox();
            TbCategoryName = new TextBox();
            TbCategoryID = new TextBox();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnExitCus
            // 
            btnExitCus.Location = new Point(631, 271);
            btnExitCus.Name = "btnExitCus";
            btnExitCus.Size = new Size(94, 29);
            btnExitCus.TabIndex = 81;
            btnExitCus.Text = "Exit";
            btnExitCus.UseVisualStyleBackColor = true;
            // 
            // btnInsertCus
            // 
            btnInsertCus.Location = new Point(631, 192);
            btnInsertCus.Name = "btnInsertCus";
            btnInsertCus.Size = new Size(94, 29);
            btnInsertCus.TabIndex = 80;
            btnInsertCus.Text = "Insert";
            btnInsertCus.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCus
            // 
            btnDeleteCus.Location = new Point(631, 113);
            btnDeleteCus.Name = "btnDeleteCus";
            btnDeleteCus.Size = new Size(94, 29);
            btnDeleteCus.TabIndex = 79;
            btnDeleteCus.Text = "Delete";
            btnDeleteCus.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCus
            // 
            btnUpdateCus.Location = new Point(631, 42);
            btnUpdateCus.Name = "btnUpdateCus";
            btnUpdateCus.Size = new Size(94, 29);
            btnUpdateCus.TabIndex = 78;
            btnUpdateCus.Text = "Update";
            btnUpdateCus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 173);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 74;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 119);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 73;
            label2.Text = "Category name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 72;
            label1.Text = "Category ID";
            // 
            // TbDescription
            // 
            TbDescription.Location = new Point(149, 170);
            TbDescription.Name = "TbDescription";
            TbDescription.Size = new Size(283, 27);
            TbDescription.TabIndex = 70;
            // 
            // TbCategoryName
            // 
            TbCategoryName.Location = new Point(149, 119);
            TbCategoryName.Name = "TbCategoryName";
            TbCategoryName.Size = new Size(283, 27);
            TbCategoryName.TabIndex = 67;
            // 
            // TbCategoryID
            // 
            TbCategoryID.Location = new Point(149, 67);
            TbCategoryID.Name = "TbCategoryID";
            TbCategoryID.Size = new Size(125, 27);
            TbCategoryID.TabIndex = 66;
            // 
            // listView1
            // 
            listView1.Location = new Point(746, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 585);
            listView1.TabIndex = 65;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1249, 604);
            Controls.Add(btnExitCus);
            Controls.Add(btnInsertCus);
            Controls.Add(btnDeleteCus);
            Controls.Add(btnUpdateCus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbDescription);
            Controls.Add(TbCategoryName);
            Controls.Add(TbCategoryID);
            Controls.Add(listView1);
            Name = "Category";
            Text = "Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExitCus;
        private Button btnInsertCus;
        private Button btnDeleteCus;
        private Button btnUpdateCus;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TbDescription;
        private TextBox TbCategoryName;
        private TextBox TbCategoryID;
        private ListView listView1;
    }
}