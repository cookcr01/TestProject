namespace finalProject
{
    partial class frmDeleteInventory
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
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.btnSubmitDelete = new System.Windows.Forms.Button();
            this.btnCancelDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(40, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 51);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(134, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(12, 90);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(93, 16);
            this.lblItemNumber.TabIndex = 4;
            this.lblItemNumber.Text = "Item Number : ";
            this.lblItemNumber.Click += new System.EventHandler(this.lblItemNumber_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(29, 119);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(76, 16);
            this.lblItemPrice.TabIndex = 5;
            this.lblItemPrice.Text = "Item Price : ";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(120, 86);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(134, 20);
            this.txtItemNumber.TabIndex = 6;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(120, 115);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(134, 20);
            this.txtItemPrice.TabIndex = 7;
            // 
            // btnSubmitDelete
            // 
            this.btnSubmitDelete.Location = new System.Drawing.Point(32, 195);
            this.btnSubmitDelete.Name = "btnSubmitDelete";
            this.btnSubmitDelete.Size = new System.Drawing.Size(101, 29);
            this.btnSubmitDelete.TabIndex = 8;
            this.btnSubmitDelete.Text = "Submit Delete";
            this.btnSubmitDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancelDelete
            // 
            this.btnCancelDelete.Location = new System.Drawing.Point(153, 195);
            this.btnCancelDelete.Name = "btnCancelDelete";
            this.btnCancelDelete.Size = new System.Drawing.Size(101, 29);
            this.btnCancelDelete.TabIndex = 9;
            this.btnCancelDelete.Text = "Cancel Delete";
            this.btnCancelDelete.UseVisualStyleBackColor = true;
            // 
            // frmDeleteInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancelDelete);
            this.Controls.Add(this.btnSubmitDelete);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Name = "frmDeleteInventory";
            this.Text = "frmDeleteInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Button btnSubmitDelete;
        private System.Windows.Forms.Button btnCancelDelete;
    }
}