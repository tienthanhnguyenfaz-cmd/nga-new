namespace Database_ASM_music_store
{
    partial class Admin_main_screen
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
            btnEmployee = new Button();
            btnSupplier = new Button();
            btnProduct = new Button();
            btnCustomer = new Button();
            btnExit = new Button();
            btnCategory = new Button();
            btnImport = new Button();
            btnOrder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(392, 180);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(94, 29);
            btnEmployee.TabIndex = 17;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(620, 210);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(94, 29);
            btnSupplier.TabIndex = 16;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(195, 210);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 29);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(531, 360);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(94, 29);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(392, 297);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(705, 279);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(94, 29);
            btnCategory.TabIndex = 12;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(231, 360);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(110, 279);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order ";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 81);
            label1.Name = "label1";
            label1.Size = new Size(419, 62);
            label1.TabIndex = 9;
            label1.Text = "Wellcome Admin!!!";
            // 
            // Admin_main_screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sad_gone;
            ClientSize = new Size(911, 497);
            Controls.Add(btnEmployee);
            Controls.Add(btnSupplier);
            Controls.Add(btnProduct);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            Controls.Add(btnCategory);
            Controls.Add(btnImport);
            Controls.Add(btnOrder);
            Controls.Add(label1);
            Name = "Admin_main_screen";
            Text = "Admin_main_screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployee;
        private Button btnSupplier;
        private Button btnProduct;
        private Button btnCustomer;
        private Button btnExit;
        private Button btnCategory;
        private Button btnImport;
        private Button btnOrder;
        private Label label1;
    }
}