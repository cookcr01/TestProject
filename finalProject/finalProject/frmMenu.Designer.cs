namespace finalProject
{
    partial class frmMenu
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
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.btnMenuSale = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(12, 187);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(196, 31);
            this.btnMenuAdd.TabIndex = 0;
            this.btnMenuAdd.Text = "Add Inventory";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Location = new System.Drawing.Point(253, 187);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(196, 31);
            this.btnMenuDelete.TabIndex = 1;
            this.btnMenuDelete.Text = "Delete Inventory";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            // 
            // btnMenuSale
            // 
            this.btnMenuSale.Location = new System.Drawing.Point(12, 130);
            this.btnMenuSale.Name = "btnMenuSale";
            this.btnMenuSale.Size = new System.Drawing.Size(196, 31);
            this.btnMenuSale.TabIndex = 2;
            this.btnMenuSale.Text = "Complete a sale";
            this.btnMenuSale.UseVisualStyleBackColor = true;
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.Location = new System.Drawing.Point(253, 130);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(196, 31);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(35, 22);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(403, 69);
            this.lblMainMenu.TabIndex = 4;
            this.lblMainMenu.Text = "Main Menu";
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(178, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 362);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.btnMenuSale);
            this.Controls.Add(this.btnMenuDelete);
            this.Controls.Add(this.btnMenuAdd);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Button btnMenuSale;
        private System.Windows.Forms.Button btnManageInventory;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnExit;
    }
}