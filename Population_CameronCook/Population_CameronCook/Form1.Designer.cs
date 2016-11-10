namespace Population_CameronCook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.citiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.citiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnTotalPopulation = new System.Windows.Forms.Button();
            this.btnCityHighPop = new System.Windows.Forms.Button();
            this.btnCityofLowPop = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.population = new Population_CameronCook.population();
            this.citiesTableAdapter = new Population_CameronCook.populationTableAdapters.CitiesTableAdapter();
            this.tableAdapterManager = new Population_CameronCook.populationTableAdapters.TableAdapterManager();
            this.txtBoxPopulation = new System.Windows.Forms.TextBox();
            this.grpBoxPopulation = new System.Windows.Forms.GroupBox();
            this.radBtnMaxPopulation = new System.Windows.Forms.RadioButton();
            this.radBtnMinPopulation = new System.Windows.Forms.RadioButton();
            this.txtBoxLetter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnStartsWith = new System.Windows.Forms.RadioButton();
            this.radBtnExactMatch = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statLblDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSearchByPopulation = new System.Windows.Forms.Button();
            this.btnSearchByCityName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).BeginInit();
            this.citiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.population)).BeginInit();
            this.grpBoxPopulation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // citiesBindingNavigator
            // 
            this.citiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.citiesBindingNavigator.BindingSource = this.citiesBindingSource;
            this.citiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.citiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.citiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.citiesBindingNavigatorSaveItem});
            this.citiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.citiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.citiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.citiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.citiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.citiesBindingNavigator.Name = "citiesBindingNavigator";
            this.citiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.citiesBindingNavigator.Size = new System.Drawing.Size(489, 25);
            this.citiesBindingNavigator.TabIndex = 0;
            this.citiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // citiesBindingNavigatorSaveItem
            // 
            this.citiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.citiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citiesBindingNavigatorSaveItem.Image")));
            this.citiesBindingNavigatorSaveItem.Name = "citiesBindingNavigatorSaveItem";
            this.citiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.citiesBindingNavigatorSaveItem.Text = "Save Data";
            this.citiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.citiesBindingNavigatorSaveItem_Click);
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AutoGenerateColumns = false;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.citiesDataGridView.DataSource = this.citiesBindingSource;
            this.citiesDataGridView.Location = new System.Drawing.Point(12, 41);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.Size = new System.Drawing.Size(247, 265);
            this.citiesDataGridView.TabIndex = 1;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(279, 99);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(198, 23);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average Population (all cities)";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(279, 41);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(198, 23);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnTotalPopulation
            // 
            this.btnTotalPopulation.Location = new System.Drawing.Point(279, 70);
            this.btnTotalPopulation.Name = "btnTotalPopulation";
            this.btnTotalPopulation.Size = new System.Drawing.Size(198, 23);
            this.btnTotalPopulation.TabIndex = 4;
            this.btnTotalPopulation.Text = "Total Population";
            this.btnTotalPopulation.UseVisualStyleBackColor = true;
            this.btnTotalPopulation.Click += new System.EventHandler(this.btnTotalPopulation_Click);
            // 
            // btnCityHighPop
            // 
            this.btnCityHighPop.Location = new System.Drawing.Point(279, 128);
            this.btnCityHighPop.Name = "btnCityHighPop";
            this.btnCityHighPop.Size = new System.Drawing.Size(198, 23);
            this.btnCityHighPop.TabIndex = 5;
            this.btnCityHighPop.Text = "City of highest Population";
            this.btnCityHighPop.UseVisualStyleBackColor = true;
            this.btnCityHighPop.Click += new System.EventHandler(this.btnCityHighPop_Click);
            // 
            // btnCityofLowPop
            // 
            this.btnCityofLowPop.Location = new System.Drawing.Point(279, 157);
            this.btnCityofLowPop.Name = "btnCityofLowPop";
            this.btnCityofLowPop.Size = new System.Drawing.Size(198, 23);
            this.btnCityofLowPop.TabIndex = 6;
            this.btnCityofLowPop.Text = "City of lowest Population";
            this.btnCityofLowPop.UseVisualStyleBackColor = true;
            this.btnCityofLowPop.Click += new System.EventHandler(this.btnCityofLowPop_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cities";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cities";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.population;
            // 
            // population
            // 
            this.population.DataSetName = "population";
            this.population.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = this.citiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Population_CameronCook.populationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBoxPopulation
            // 
            this.txtBoxPopulation.Location = new System.Drawing.Point(46, 360);
            this.txtBoxPopulation.Name = "txtBoxPopulation";
            this.txtBoxPopulation.Size = new System.Drawing.Size(152, 20);
            this.txtBoxPopulation.TabIndex = 7;
            // 
            // grpBoxPopulation
            // 
            this.grpBoxPopulation.Controls.Add(this.radBtnMinPopulation);
            this.grpBoxPopulation.Controls.Add(this.radBtnMaxPopulation);
            this.grpBoxPopulation.Location = new System.Drawing.Point(12, 386);
            this.grpBoxPopulation.Name = "grpBoxPopulation";
            this.grpBoxPopulation.Size = new System.Drawing.Size(227, 44);
            this.grpBoxPopulation.TabIndex = 8;
            this.grpBoxPopulation.TabStop = false;
            // 
            // radBtnMaxPopulation
            // 
            this.radBtnMaxPopulation.AutoSize = true;
            this.radBtnMaxPopulation.Location = new System.Drawing.Point(6, 19);
            this.radBtnMaxPopulation.Name = "radBtnMaxPopulation";
            this.radBtnMaxPopulation.Size = new System.Drawing.Size(98, 17);
            this.radBtnMaxPopulation.TabIndex = 0;
            this.radBtnMaxPopulation.TabStop = true;
            this.radBtnMaxPopulation.Text = "Max Population";
            this.radBtnMaxPopulation.UseVisualStyleBackColor = true;
            this.radBtnMaxPopulation.CheckedChanged += new System.EventHandler(this.radBtnMaxPopulation_CheckedChanged);
            // 
            // radBtnMinPopulation
            // 
            this.radBtnMinPopulation.AutoSize = true;
            this.radBtnMinPopulation.Location = new System.Drawing.Point(110, 19);
            this.radBtnMinPopulation.Name = "radBtnMinPopulation";
            this.radBtnMinPopulation.Size = new System.Drawing.Size(95, 17);
            this.radBtnMinPopulation.TabIndex = 1;
            this.radBtnMinPopulation.TabStop = true;
            this.radBtnMinPopulation.Text = "Min Population";
            this.radBtnMinPopulation.UseVisualStyleBackColor = true;
            this.radBtnMinPopulation.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtBoxLetter
            // 
            this.txtBoxLetter.Location = new System.Drawing.Point(285, 360);
            this.txtBoxLetter.Name = "txtBoxLetter";
            this.txtBoxLetter.Size = new System.Drawing.Size(152, 20);
            this.txtBoxLetter.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnStartsWith);
            this.groupBox1.Controls.Add(this.radBtnExactMatch);
            this.groupBox1.Location = new System.Drawing.Point(250, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radBtnStartsWith
            // 
            this.radBtnStartsWith.AutoSize = true;
            this.radBtnStartsWith.Location = new System.Drawing.Point(110, 19);
            this.radBtnStartsWith.Name = "radBtnStartsWith";
            this.radBtnStartsWith.Size = new System.Drawing.Size(77, 17);
            this.radBtnStartsWith.TabIndex = 1;
            this.radBtnStartsWith.TabStop = true;
            this.radBtnStartsWith.Text = "Starts With";
            this.radBtnStartsWith.UseVisualStyleBackColor = true;
            // 
            // radBtnExactMatch
            // 
            this.radBtnExactMatch.AutoSize = true;
            this.radBtnExactMatch.Location = new System.Drawing.Point(6, 19);
            this.radBtnExactMatch.Name = "radBtnExactMatch";
            this.radBtnExactMatch.Size = new System.Drawing.Size(85, 17);
            this.radBtnExactMatch.TabIndex = 0;
            this.radBtnExactMatch.TabStop = true;
            this.radBtnExactMatch.Text = "Exact Match";
            this.radBtnExactMatch.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLblDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(489, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statLblDisplay
            // 
            this.statLblDisplay.Name = "statLblDisplay";
            this.statLblDisplay.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSearchByPopulation
            // 
            this.btnSearchByPopulation.Location = new System.Drawing.Point(48, 436);
            this.btnSearchByPopulation.Name = "btnSearchByPopulation";
            this.btnSearchByPopulation.Size = new System.Drawing.Size(149, 26);
            this.btnSearchByPopulation.TabIndex = 12;
            this.btnSearchByPopulation.Text = "Show by Population";
            this.btnSearchByPopulation.UseVisualStyleBackColor = true;
            this.btnSearchByPopulation.Click += new System.EventHandler(this.btnSearchByPopulation_Click);
            // 
            // btnSearchByCityName
            // 
            this.btnSearchByCityName.Location = new System.Drawing.Point(279, 433);
            this.btnSearchByCityName.Name = "btnSearchByCityName";
            this.btnSearchByCityName.Size = new System.Drawing.Size(149, 26);
            this.btnSearchByCityName.TabIndex = 13;
            this.btnSearchByCityName.Text = "Search By city name";
            this.btnSearchByCityName.UseVisualStyleBackColor = true;
            this.btnSearchByCityName.Click += new System.EventHandler(this.btnSearchByCityName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 484);
            this.Controls.Add(this.btnSearchByCityName);
            this.Controls.Add(this.btnSearchByPopulation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxLetter);
            this.Controls.Add(this.grpBoxPopulation);
            this.Controls.Add(this.txtBoxPopulation);
            this.Controls.Add(this.btnCityofLowPop);
            this.Controls.Add(this.btnCityHighPop);
            this.Controls.Add(this.btnTotalPopulation);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.citiesDataGridView);
            this.Controls.Add(this.citiesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).EndInit();
            this.citiesBindingNavigator.ResumeLayout(false);
            this.citiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.population)).EndInit();
            this.grpBoxPopulation.ResumeLayout(false);
            this.grpBoxPopulation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private population population;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private populationTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private populationTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator citiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton citiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnTotalPopulation;
        private System.Windows.Forms.Button btnCityHighPop;
        private System.Windows.Forms.Button btnCityofLowPop;
        private System.Windows.Forms.TextBox txtBoxPopulation;
        private System.Windows.Forms.GroupBox grpBoxPopulation;
        private System.Windows.Forms.RadioButton radBtnMinPopulation;
        private System.Windows.Forms.RadioButton radBtnMaxPopulation;
        private System.Windows.Forms.TextBox txtBoxLetter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnStartsWith;
        private System.Windows.Forms.RadioButton radBtnExactMatch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statLblDisplay;
        private System.Windows.Forms.Button btnSearchByPopulation;
        private System.Windows.Forms.Button btnSearchByCityName;
    }
}

