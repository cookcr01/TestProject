namespace finalProject
{
    partial class frmCompleteASale
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtboxItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.btnSubmitDelete = new System.Windows.Forms.Button();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtBoxSalesTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(40, 60);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity : ";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 56);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(129, 85);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(134, 20);
            this.txtItemNumber.TabIndex = 7;
            // 
            // txtboxItemPrice
            // 
            this.txtboxItemPrice.Location = new System.Drawing.Point(129, 111);
            this.txtboxItemPrice.Name = "txtboxItemPrice";
            this.txtboxItemPrice.Size = new System.Drawing.Size(134, 20);
            this.txtboxItemPrice.TabIndex = 8;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(12, 85);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(93, 16);
            this.lblItemNumber.TabIndex = 9;
            this.lblItemNumber.Text = "Item Number : ";
            this.lblItemNumber.Click += new System.EventHandler(this.lblItemNumber_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(29, 115);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(76, 16);
            this.lblItemPrice.TabIndex = 10;
            this.lblItemPrice.Text = "Item Price : ";
            // 
            // btnSubmitDelete
            // 
            this.btnSubmitDelete.Location = new System.Drawing.Point(32, 164);
            this.btnSubmitDelete.Name = "btnSubmitDelete";
            this.btnSubmitDelete.Size = new System.Drawing.Size(101, 29);
            this.btnSubmitDelete.TabIndex = 11;
            this.btnSubmitDelete.Text = "Submit Delete";
            this.btnSubmitDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Location = new System.Drawing.Point(162, 164);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(101, 29);
            this.btnCancelDelete.TabIndex = 12;
            this.btnCancelDelete.Text = "Cancel Delete";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(23, 302);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 16);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price : ";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(129, 298);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(134, 20);
            this.txtBoxTotal.TabIndex = 14;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(40, 242);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 16);
            this.lblSubTotal.TabIndex = 15;
            this.lblSubTotal.Text = "Subtotal : ";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(129, 238);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(134, 20);
            this.txtBoxSubtotal.TabIndex = 16;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTax.Location = new System.Drawing.Point(27, 273);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(78, 16);
            this.lblSalesTax.TabIndex = 17;
            this.lblSalesTax.Text = "Sales Tax : ";
            // 
            // txtBoxSalesTax
            // 
            this.txtBoxSalesTax.Location = new System.Drawing.Point(129, 269);
            this.txtBoxSalesTax.Name = "txtBoxSalesTax";
            this.txtBoxSalesTax.Size = new System.Drawing.Size(134, 20);
            this.txtBoxSalesTax.TabIndex = 18;
            // 
            // frmCompleteASale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 357);
            this.Controls.Add(this.txtBoxSalesTax);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCancelDelete);
            this.Controls.Add(this.btnSubmitDelete);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtboxItemPrice);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Name = "frmCompleteASale";
            this.Text = "frmCompleteASale";
            this.Load += new System.EventHandler(this.frmCompleteASale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtboxItemPrice;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Button btnSubmitDelete;
        private System.Windows.Forms.Button btnCancelDelete;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtBoxSalesTax;
    }
}