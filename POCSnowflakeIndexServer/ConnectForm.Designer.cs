
namespace POCSnowflakeIndexServer
{
    partial class ConnectForm
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
            this.lblAuthType = new System.Windows.Forms.Label();
            this.cmbAuthType = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblSchema = new System.Windows.Forms.Label();
            this.txtSchema = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWH = new System.Windows.Forms.TextBox();
            this.lblWH = new System.Windows.Forms.Label();
            this.lblTestConnectionInform = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radObjFieldsYes = new System.Windows.Forms.RadioButton();
            this.radObjFieldsNo = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHostRegex = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostRegex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(12, 42);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(102, 13);
            this.lblAuthType.TabIndex = 0;
            this.lblAuthType.Text = "Authentication Type";
            // 
            // cmbAuthType
            // 
            this.cmbAuthType.FormattingEnabled = true;
            this.cmbAuthType.Items.AddRange(new object[] {
            "Username/Password"});
            this.cmbAuthType.Location = new System.Drawing.Point(132, 34);
            this.cmbAuthType.Name = "cmbAuthType";
            this.cmbAuthType.Size = new System.Drawing.Size(240, 21);
            this.cmbAuthType.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 148);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 141);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(132, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(11, 26);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(130, 19);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(240, 20);
            this.txtDatabase.TabIndex = 7;
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Location = new System.Drawing.Point(13, 63);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(46, 13);
            this.lblSchema.TabIndex = 8;
            this.lblSchema.Text = "Schema";
            // 
            // txtSchema
            // 
            this.txtSchema.Location = new System.Drawing.Point(130, 56);
            this.txtSchema.Name = "txtSchema";
            this.txtSchema.Size = new System.Drawing.Size(240, 20);
            this.txtSchema.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(39, 432);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test...";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(131, 432);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(226, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(132, 70);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(392, 20);
            this.txtAccount.TabIndex = 14;
            this.txtAccount.Visible = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(13, 77);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "Account";
            this.lblAccount.Visible = false;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(132, 104);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(392, 20);
            this.txtHost.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Host";
            // 
            // txtWH
            // 
            this.txtWH.Location = new System.Drawing.Point(129, 93);
            this.txtWH.Name = "txtWH";
            this.txtWH.Size = new System.Drawing.Size(240, 20);
            this.txtWH.TabIndex = 18;
            // 
            // lblWH
            // 
            this.lblWH.AutoSize = true;
            this.lblWH.Location = new System.Drawing.Point(12, 100);
            this.lblWH.Name = "lblWH";
            this.lblWH.Size = new System.Drawing.Size(62, 13);
            this.lblWH.TabIndex = 17;
            this.lblWH.Text = "Warehouse";
            // 
            // lblTestConnectionInform
            // 
            this.lblTestConnectionInform.AutoSize = true;
            this.lblTestConnectionInform.Location = new System.Drawing.Point(484, 442);
            this.lblTestConnectionInform.Name = "lblTestConnectionInform";
            this.lblTestConnectionInform.Size = new System.Drawing.Size(167, 13);
            this.lblTestConnectionInform.TabIndex = 19;
            this.lblTestConnectionInform.Text = "Testing connection. Please wait...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.lblDatabase);
            this.groupBox1.Controls.Add(this.txtWH);
            this.groupBox1.Controls.Add(this.lblSchema);
            this.groupBox1.Controls.Add(this.lblWH);
            this.groupBox1.Controls.Add(this.txtSchema);
            this.groupBox1.Location = new System.Drawing.Point(3, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 155);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Do you want to enter object fields?";
            // 
            // radObjFieldsYes
            // 
            this.radObjFieldsYes.AutoSize = true;
            this.radObjFieldsYes.Location = new System.Drawing.Point(212, 217);
            this.radObjFieldsYes.Name = "radObjFieldsYes";
            this.radObjFieldsYes.Size = new System.Drawing.Size(43, 17);
            this.radObjFieldsYes.TabIndex = 22;
            this.radObjFieldsYes.TabStop = true;
            this.radObjFieldsYes.Text = "Yes";
            this.radObjFieldsYes.UseVisualStyleBackColor = true;
            this.radObjFieldsYes.CheckedChanged += new System.EventHandler(this.radObjFieldsYes_CheckedChanged);
            // 
            // radObjFieldsNo
            // 
            this.radObjFieldsNo.AutoSize = true;
            this.radObjFieldsNo.Location = new System.Drawing.Point(270, 217);
            this.radObjFieldsNo.Name = "radObjFieldsNo";
            this.radObjFieldsNo.Size = new System.Drawing.Size(39, 17);
            this.radObjFieldsNo.TabIndex = 23;
            this.radObjFieldsNo.TabStop = true;
            this.radObjFieldsNo.Text = "No";
            this.radObjFieldsNo.UseVisualStyleBackColor = true;
            this.radObjFieldsNo.CheckedChanged += new System.EventHandler(this.radObjFieldsNo_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderHostRegex
            // 
            this.errorProviderHostRegex.ContainerControl = this;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 499);
            this.Controls.Add(this.radObjFieldsNo);
            this.Controls.Add(this.radObjFieldsYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTestConnectionInform);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbAuthType);
            this.Controls.Add(this.lblAuthType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostRegex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthType;
        private System.Windows.Forms.ComboBox cmbAuthType;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.TextBox txtSchema;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWH;
        private System.Windows.Forms.Label lblWH;
        private System.Windows.Forms.Label lblTestConnectionInform;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radObjFieldsYes;
        private System.Windows.Forms.RadioButton radObjFieldsNo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProviderHostRegex;
    }
}

