
namespace POCSnowflakeIndexServer
{
    partial class SchemaListForm
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
            this.treeViewSchemaList = new System.Windows.Forms.TreeView();
            this.lblSchemaDiscovered = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnGoToSimpleAggregation = new System.Windows.Forms.Button();
            this.lblSelectedDatabase = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2ColAggregation = new System.Windows.Forms.Button();
            this.btn2colWithFilterAggregation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewSchemaList
            // 
            this.treeViewSchemaList.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewSchemaList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSchemaList.Location = new System.Drawing.Point(15, 35);
            this.treeViewSchemaList.Name = "treeViewSchemaList";
            this.treeViewSchemaList.Size = new System.Drawing.Size(1099, 688);
            this.treeViewSchemaList.TabIndex = 0;
            this.treeViewSchemaList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSchemaList_AfterSelect);
            // 
            // lblSchemaDiscovered
            // 
            this.lblSchemaDiscovered.AutoSize = true;
            this.lblSchemaDiscovered.Location = new System.Drawing.Point(12, 19);
            this.lblSchemaDiscovered.Name = "lblSchemaDiscovered";
            this.lblSchemaDiscovered.Size = new System.Drawing.Size(103, 13);
            this.lblSchemaDiscovered.TabIndex = 1;
            this.lblSchemaDiscovered.Text = "Schema Discovered";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(186, 752);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Go To Simple Query Form";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnGoToSimpleAggregation
            // 
            this.btnGoToSimpleAggregation.Location = new System.Drawing.Point(333, 752);
            this.btnGoToSimpleAggregation.Name = "btnGoToSimpleAggregation";
            this.btnGoToSimpleAggregation.Size = new System.Drawing.Size(149, 23);
            this.btnGoToSimpleAggregation.TabIndex = 3;
            this.btnGoToSimpleAggregation.Text = "Go To Simple Aggregation";
            this.btnGoToSimpleAggregation.UseVisualStyleBackColor = true;
            this.btnGoToSimpleAggregation.Click += new System.EventHandler(this.btnGoToSimpleAggregation_Click);
            // 
            // lblSelectedDatabase
            // 
            this.lblSelectedDatabase.AutoSize = true;
            this.lblSelectedDatabase.Location = new System.Drawing.Point(845, 19);
            this.lblSelectedDatabase.Name = "lblSelectedDatabase";
            this.lblSelectedDatabase.Size = new System.Drawing.Size(9, 13);
            this.lblSelectedDatabase.TabIndex = 4;
            this.lblSelectedDatabase.Text = "l";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 752);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go To One Column Aggregation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2ColAggregation
            // 
            this.btn2ColAggregation.Location = new System.Drawing.Point(690, 752);
            this.btn2ColAggregation.Name = "btn2ColAggregation";
            this.btn2ColAggregation.Size = new System.Drawing.Size(187, 23);
            this.btn2ColAggregation.TabIndex = 6;
            this.btn2ColAggregation.Text = "Go To Two Column Aggregation";
            this.btn2ColAggregation.UseVisualStyleBackColor = true;
            this.btn2ColAggregation.Click += new System.EventHandler(this.btn2ColAggregation_Click);
            // 
            // btn2colWithFilterAggregation
            // 
            this.btn2colWithFilterAggregation.Location = new System.Drawing.Point(883, 752);
            this.btn2colWithFilterAggregation.Name = "btn2colWithFilterAggregation";
            this.btn2colWithFilterAggregation.Size = new System.Drawing.Size(228, 23);
            this.btn2colWithFilterAggregation.TabIndex = 7;
            this.btn2colWithFilterAggregation.Text = "Go To Two Column With Filter Aggregation";
            this.btn2colWithFilterAggregation.UseVisualStyleBackColor = true;
            this.btn2colWithFilterAggregation.Click += new System.EventHandler(this.btn2colWithFilterAggregation_Click);
            // 
            // SchemaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 785);
            this.Controls.Add(this.btn2colWithFilterAggregation);
            this.Controls.Add(this.btn2ColAggregation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSelectedDatabase);
            this.Controls.Add(this.btnGoToSimpleAggregation);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblSchemaDiscovered);
            this.Controls.Add(this.treeViewSchemaList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchemaListForm";
            this.Text = "SchemaListForm";
            this.Load += new System.EventHandler(this.SchemaListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSchemaList;
        private System.Windows.Forms.Label lblSchemaDiscovered;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnGoToSimpleAggregation;
        private System.Windows.Forms.Label lblSelectedDatabase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2ColAggregation;
        private System.Windows.Forms.Button btn2colWithFilterAggregation;
    }
}