namespace Database_ASM_music_store
{
    partial class Main_srceen
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
            label1 = new Label();
            btnOrder = new Button();
            btnImport = new Button();
            btnCategory = new Button();
            btnExit = new Button();
            btnCustomer = new Button();
            btnProduct = new Button();
            btnSupplier = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 81);
            label1.Name = "label1";
            label1.Size = new Size(487, 62);
            label1.TabIndex = 0;
            label1.Text = "Wellcome Employee!!!";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(128, 273);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order ";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(249, 354);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 2;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(723, 273);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(94, 29);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(410, 291);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(549, 354);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(94, 29);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(213, 204);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 29);
            btnProduct.TabIndex = 6;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(638, 204);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(94, 29);
            btnSupplier.TabIndex = 7;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.red_ball_angry;
            ClientSize = new Size(936, 491);
            Controls.Add(btnSupplier);
            Controls.Add(btnProduct);
            Controls.Add(btnCustomer);
            Controls.Add(btnExit);
            Controls.Add(btnCategory);
            Controls.Add(btnImport);
            Controls.Add(btnOrder);
            Controls.Add(label1);
            Name = "Main_srceen";
            Text = "Main srceen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOrder;
        private Button btnImport;
        private Button btnCategory;
        private Button btnExit;
        private Button btnCustomer;
        private Button btnProduct;
        private Button btnSupplier;
    }
}