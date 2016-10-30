namespace finalProject
{
    partial class frmAddInventory
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtBoxItemPrice = new System.Windows.Forms.TextBox();
            this.btnSubmitSale = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(134, 61);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(40, 65);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 16);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(12, 97);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(93, 16);
            this.lblItemNumber.TabIndex = 2;
            this.lblItemNumber.Text = "Item Number : ";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(134, 93);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(134, 20);
            this.txtItemNumber.TabIndex = 3;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(29, 132);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(76, 16);
            this.lblItemPrice.TabIndex = 4;
            this.lblItemPrice.Text = "Item Price : ";
            // 
            // txtBoxItemPrice
            // 
            this.txtBoxItemPrice.Location = new System.Drawing.Point(134, 128);
            this.txtBoxItemPrice.Name = "txtBoxItemPrice";
            this.txtBoxItemPrice.Size = new System.Drawing.Size(134, 20);
            this.txtBoxItemPrice.TabIndex = 5;
            // 
            // btnSubmitSale
            // 
            this.btnSubmitSale.Location = new System.Drawing.Point(43, 191);
            this.btnSubmitSale.Name = "btnSubmitSale";
            this.btnSubmitSale.Size = new System.Drawing.Size(101, 29);
            this.btnSubmitSale.TabIndex = 6;
            this.btnSubmitSale.Text = "Submit Sale";
            this.btnSubmitSale.UseVisualStyleBackColor = true;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(167, 191);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(101, 29);
            this.btnCancelSale.TabIndex = 7;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // frmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.btnSubmitSale);
            this.Controls.Add(this.txtBoxItemPrice);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Name = "frmAddInventory";
            this.Text = "frmAddInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtBoxItemPrice;
        private System.Windows.Forms.Button btnSubmitSale;
        private System.Windows.Forms.Button btnCancelSale;
    }
}