
namespace POCSnowflakeIndexServer
{
    partial class XYAxisAggregationWithFilterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.cmbSchema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.cmbMeasureType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRunAggregation = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAxisX = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAxisY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Items.AddRange(new object[] {
            "Choose a database..."});
            this.cmbDatabase.Location = new System.Drawing.Point(68, 35);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(214, 21);
            this.cmbDatabase.TabIndex = 1;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // cmbSchema
            // 
            this.cmbSchema.FormattingEnabled = true;
            this.cmbSchema.Items.AddRange(new object[] {
            "Choose a schema..."});
            this.cmbSchema.Location = new System.Drawing.Point(68, 62);
            this.cmbSchema.Name = "cmbSchema";
            this.cmbSchema.Size = new System.Drawing.Size(214, 21);
            this.cmbSchema.TabIndex = 3;
            this.cmbSchema.SelectedIndexChanged += new System.EventHandler(this.cmbSchema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Schema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Choose a table..."});
            this.cmbTable.Location = new System.Drawing.Point(68, 89);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(404, 21);
            this.cmbTable.TabIndex = 5;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(11, 292);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ReadOnly = true;
            this.txtQuery.Size = new System.Drawing.Size(553, 133);
            this.txtQuery.TabIndex = 6;
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Items.AddRange(new object[] {
            "Choose a column..."});
            this.cmbColumn.Location = new System.Drawing.Point(90, 142);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(404, 21);
            this.cmbColumn.TabIndex = 8;
            this.cmbColumn.SelectedIndexChanged += new System.EventHandler(this.cmbColumn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Measure Field";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Location = new System.Drawing.Point(319, 249);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(129, 23);
            this.btnAddFilter.TabIndex = 9;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // cmbMeasureType
            // 
            this.cmbMeasureType.FormattingEnabled = true;
            this.cmbMeasureType.Items.AddRange(new object[] {
            "COUNT",
            "AVG",
            "SUM",
            "MIN",
            "MAX"});
            this.cmbMeasureType.Location = new System.Drawing.Point(90, 116);
            this.cmbMeasureType.Name = "cmbMeasureType";
            this.cmbMeasureType.Size = new System.Drawing.Size(121, 21);
            this.cmbMeasureType.TabIndex = 11;
            this.cmbMeasureType.SelectedIndexChanged += new System.EventHandler(this.cmbMeasureType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Measure Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRunAggregation
            // 
            this.btnRunAggregation.Location = new System.Drawing.Point(14, 432);
            this.btnRunAggregation.Name = "btnRunAggregation";
            this.btnRunAggregation.Size = new System.Drawing.Size(128, 23);
            this.btnRunAggregation.TabIndex = 12;
            this.btnRunAggregation.Text = "Run Aggregation";
            this.btnRunAggregation.UseVisualStyleBackColor = true;
            this.btnRunAggregation.Click += new System.EventHandler(this.btnRunAggregation_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(155, 434);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(206, 20);
            this.txtResult.TabIndex = 13;
            this.txtResult.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(398, 431);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 247);
            this.dataGridView1.TabIndex = 15;
            // 
            // cmbAxisX
            // 
            this.cmbAxisX.FormattingEnabled = true;
            this.cmbAxisX.Items.AddRange(new object[] {
            "Choose a column..."});
            this.cmbAxisX.Location = new System.Drawing.Point(68, 170);
            this.cmbAxisX.Name = "cmbAxisX";
            this.cmbAxisX.Size = new System.Drawing.Size(404, 21);
            this.cmbAxisX.TabIndex = 17;
            this.cmbAxisX.SelectedIndexChanged += new System.EventHandler(this.cmbAxisX_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Axis X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAxisY
            // 
            this.cmbAxisY.FormattingEnabled = true;
            this.cmbAxisY.Items.AddRange(new object[] {
            "Choose a column..."});
            this.cmbAxisY.Location = new System.Drawing.Point(68, 196);
            this.cmbAxisY.Name = "cmbAxisY";
            this.cmbAxisY.Size = new System.Drawing.Size(404, 21);
            this.cmbAxisY.TabIndex = 19;
            this.cmbAxisY.SelectedIndexChanged += new System.EventHandler(this.cmbAxisY_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Axis Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Operator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cmbOperator.Location = new System.Drawing.Point(68, 251);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(74, 21);
            this.cmbOperator.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Value";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(192, 251);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 23;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Choose a column..."});
            this.cmbFilter.Location = new System.Drawing.Point(68, 224);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(404, 21);
            this.cmbFilter.TabIndex = 25;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Filter";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XYAxisAggregationWithFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 737);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAxisY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbAxisX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRunAggregation);
            this.Controls.Add(this.cmbMeasureType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddFilter);
            this.Controls.Add(this.cmbColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSchema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDatabase);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "XYAxisAggregationWithFilterForm";
            this.Text = "TwoColumnAggregation";
            this.Load += new System.EventHandler(this.SimpleAggregationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.ComboBox cmbSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.ComboBox cmbMeasureType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRunAggregation;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbAxisX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAxisY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label10;
    }
}