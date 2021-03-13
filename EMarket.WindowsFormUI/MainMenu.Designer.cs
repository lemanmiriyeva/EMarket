namespace EMarket.WindowsFormUI
{
    partial class MainMenu
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
            this.dgwBuyProducts = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.cbxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.nudProductCount = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBuyProducts
            // 
            this.dgwBuyProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBuyProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBuyProducts.Location = new System.Drawing.Point(24, 63);
            this.dgwBuyProducts.Name = "dgwBuyProducts";
            this.dgwBuyProducts.ReadOnly = true;
            this.dgwBuyProducts.Size = new System.Drawing.Size(692, 148);
            this.dgwBuyProducts.TabIndex = 0;
            this.dgwBuyProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBuyProducts_CellClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(604, 221);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(112, 39);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgwCart
            // 
            this.dgwCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(24, 266);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.Size = new System.Drawing.Size(692, 129);
            this.dgwCart.TabIndex = 2;
            this.dgwCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCart_CellClick);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.Location = new System.Drawing.Point(19, 404);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(147, 26);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(172, 404);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(54, 26);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By Name";
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Location = new System.Drawing.Point(488, 41);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(101, 13);
            this.lblSearchByCategory.TabIndex = 6;
            this.lblSearchByCategory.Text = "Search By Category";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(604, 12);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(112, 20);
            this.tbxSearchByName.TabIndex = 7;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // cbxSearchByCategory
            // 
            this.cbxSearchByCategory.FormattingEnabled = true;
            this.cbxSearchByCategory.Location = new System.Drawing.Point(604, 38);
            this.cbxSearchByCategory.Name = "cbxSearchByCategory";
            this.cbxSearchByCategory.Size = new System.Drawing.Size(112, 21);
            this.cbxSearchByCategory.TabIndex = 8;
            this.cbxSearchByCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByCategory_SelectedIndexChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAll.Location = new System.Drawing.Point(722, 299);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteOne.Location = new System.Drawing.Point(722, 256);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteOne.TabIndex = 10;
            this.btnDeleteOne.Text = "Delete One";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // nudProductCount
            // 
            this.nudProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudProductCount.Location = new System.Drawing.Point(551, 228);
            this.nudProductCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductCount.Name = "nudProductCount";
            this.nudProductCount.Size = new System.Drawing.Size(38, 26);
            this.nudProductCount.TabIndex = 11;
            this.nudProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(722, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinish.Location = new System.Drawing.Point(724, 384);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(107, 36);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProductUpdate.Location = new System.Drawing.Point(722, 63);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(109, 55);
            this.btnProductUpdate.TabIndex = 14;
            this.btnProductUpdate.Text = "Update Products";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 457);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.nudProductCount);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.cbxSearchByCategory);
            this.Controls.Add(this.tbxSearchByName);
            this.Controls.Add(this.lblSearchByCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dgwCart);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.dgwBuyProducts);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBuyProducts;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgwCart;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearchByCategory;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.ComboBox cbxSearchByCategory;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.NumericUpDown nudProductCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnProductUpdate;
    }
}

