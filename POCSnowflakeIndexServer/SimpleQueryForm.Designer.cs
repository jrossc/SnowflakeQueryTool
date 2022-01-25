
namespace POCSnowflakeIndexServer
{
    partial class SimpleQueryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSQFQuery = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSQFAddFilter = new System.Windows.Forms.Button();
            this.txtSQFValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSQFOperator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSQFColumn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSQFTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSQFSchema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSQFDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtSQFQuery);
            this.flowLayoutPanel2.Controls.Add(this.btnGenerate);
            this.flowLayoutPanel2.Controls.Add(this.progressBar1);
            this.flowLayoutPanel2.Controls.Add(this.lblStatus);
            this.flowLayoutPanel2.Controls.Add(this.btnReset);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(32, 73);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1132, 148);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // txtSQFQuery
            // 
            this.txtSQFQuery.Enabled = false;
            this.txtSQFQuery.Location = new System.Drawing.Point(3, 3);
            this.txtSQFQuery.Multiline = true;
            this.txtSQFQuery.Name = "txtSQFQuery";
            this.txtSQFQuery.ReadOnly = true;
            this.txtSQFQuery.Size = new System.Drawing.Size(558, 140);
            this.txtSQFQuery.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(567, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(648, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(843, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "lblStatus";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(896, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(32, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 558);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSQFAddFilter
            // 
            this.btnSQFAddFilter.Location = new System.Drawing.Point(1038, 3);
            this.btnSQFAddFilter.Name = "btnSQFAddFilter";
            this.btnSQFAddFilter.Size = new System.Drawing.Size(75, 23);
            this.btnSQFAddFilter.TabIndex = 8;
            this.btnSQFAddFilter.Text = "AddFilter";
            this.btnSQFAddFilter.UseVisualStyleBackColor = true;
            this.btnSQFAddFilter.Click += new System.EventHandler(this.btnSQFAddFilter_Click);
            // 
            // txtSQFValue
            // 
            this.txtSQFValue.Location = new System.Drawing.Point(932, 3);
            this.txtSQFValue.Name = "txtSQFValue";
            this.txtSQFValue.Size = new System.Drawing.Size(100, 20);
            this.txtSQFValue.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSQFOperator
            // 
            this.cmbSQFOperator.FormattingEnabled = true;
            this.cmbSQFOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "LIKE"});
            this.cmbSQFOperator.Location = new System.Drawing.Point(822, 3);
            this.cmbSQFOperator.Name = "cmbSQFOperator";
            this.cmbSQFOperator.Size = new System.Drawing.Size(64, 21);
            this.cmbSQFOperator.TabIndex = 12;
            this.cmbSQFOperator.SelectedIndexChanged += new System.EventHandler(this.cmbSQFOperator_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operator";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSQFColumn
            // 
            this.cmbSQFColumn.FormattingEnabled = true;
            this.cmbSQFColumn.Items.AddRange(new object[] {
            "Choose a column"});
            this.cmbSQFColumn.Location = new System.Drawing.Point(615, 3);
            this.cmbSQFColumn.Name = "cmbSQFColumn";
            this.cmbSQFColumn.Size = new System.Drawing.Size(147, 21);
            this.cmbSQFColumn.TabIndex = 9;
            this.cmbSQFColumn.SelectedIndexChanged += new System.EventHandler(this.cmbSQFColumn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Column";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSQFTable
            // 
            this.cmbSQFTable.FormattingEnabled = true;
            this.cmbSQFTable.Items.AddRange(new object[] {
            "Choose a table..."});
            this.cmbSQFTable.Location = new System.Drawing.Point(408, 3);
            this.cmbSQFTable.Name = "cmbSQFTable";
            this.cmbSQFTable.Size = new System.Drawing.Size(153, 21);
            this.cmbSQFTable.TabIndex = 5;
            this.cmbSQFTable.SelectedIndexChanged += new System.EventHandler(this.cmbSQFTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSQFSchema
            // 
            this.cmbSQFSchema.FormattingEnabled = true;
            this.cmbSQFSchema.Items.AddRange(new object[] {
            "Choose a schema..."});
            this.cmbSQFSchema.Location = new System.Drawing.Point(241, 3);
            this.cmbSQFSchema.Name = "cmbSQFSchema";
            this.cmbSQFSchema.Size = new System.Drawing.Size(121, 21);
            this.cmbSQFSchema.TabIndex = 3;
            this.cmbSQFSchema.SelectedIndexChanged += new System.EventHandler(this.cmbSQFSchema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Schema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSQFDatabase
            // 
            this.cmbSQFDatabase.FormattingEnabled = true;
            this.cmbSQFDatabase.Items.AddRange(new object[] {
            "Choose a database..."});
            this.cmbSQFDatabase.Location = new System.Drawing.Point(62, 3);
            this.cmbSQFDatabase.Name = "cmbSQFDatabase";
            this.cmbSQFDatabase.Size = new System.Drawing.Size(121, 21);
            this.cmbSQFDatabase.TabIndex = 1;
            this.cmbSQFDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbSQFDatabase_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbSQFDatabase);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cmbSQFSchema);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cmbSQFTable);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.cmbSQFColumn);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.cmbSQFOperator);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txtSQFValue);
            this.flowLayoutPanel1.Controls.Add(this.btnSQFAddFilter);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1132, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SimpleQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 821);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SimpleQueryForm";
            this.Text = "SimpleQueryForm";
            this.Load += new System.EventHandler(this.SimpleQueryForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtSQFQuery;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSQFAddFilter;
        private System.Windows.Forms.TextBox txtSQFValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSQFOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSQFColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSQFTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSQFSchema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSQFDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReset;
    }
}