using Microsoft.Extensions.DependencyInjection;
using POCSnowflakeIndexServer.Controllers;
using POCSnowflakeIndexServer.DAL;
using POCSnowflakeIndexServer.Helpers;
using POCSnowflakeIndexServer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCSnowflakeIndexServer
{
    public partial class ConnectForm : Form
    {
        internal static Boolean tested;
        internal static Boolean validated;
        private readonly IServiceProvider serviceProvider;

        public ConnectForm(IServiceProvider provider)
        {
            this.serviceProvider = provider;
            InitializeComponent();
        }
        public ConnectForm()
        {
            InitializeComponent();
        }

        #region Forms Object Events

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            lblTestConnectionInform.Visible = false;
            cmbAuthType.SelectedIndex = 0;
            radObjFieldsYes.Checked = true;
            tested = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            validated = ValidateFields();

            if (validated)
            {
                bool validateHost = ValidateHostDomain(txtHost.Text);
                if(validateHost)
                {
                    lblTestConnectionInform.Visible = true;
                    TryToConnect();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            validated = ValidateFields();
            if (validated)
            {
                bool validateHost = ValidateHostDomain(txtHost.Text);
                if (validateHost)
                {
                    if (!tested)
                    {
                        ShowAlert("Test your connection first");
                    }
                    else
                    {
                        ShowAlert("Connection Successfully tested. Opening the Page...");
                        MapFieldsToConnnectionStringBuilderProperties();
                        var form = serviceProvider.GetRequiredService<SchemaListForm>();
                        form.ShowDialog();
                        tested = false;
                    }
                }
            }
          
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TryToConnect();
            }

        }

        private void radObjFieldsYes_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtDatabase.Text = "";
            txtSchema.Text = "";
            txtWH.Text = "";
        }

        private void radObjFieldsNo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            txtDatabase.Text = "";
            txtSchema.Text = "";
            txtWH.Text = "";
        }

        #endregion

        #region Helper Events

        private void TryToConnect()
        {
            try
            {
                MapFieldsToConnnectionStringBuilderProperties();
                ConnectionStringBuilder.BuildString();

                using (DataAccess da = new SnowflakeDataAccess())
                {
                    da.ConnectionString = ConnectionStringBuilder.FinalConnectionString;
                    var result = da.TestConnectionAsync().Result;
                    DialogResult d = ShowAlertWithResult(result.ToString());
                    if (d == DialogResult.OK)
                    {
                        lblTestConnectionInform.Visible = false;
                    }      
                }
            }
            catch (Exception ex)
            {
                DialogResult d = ShowAlertWithResult(ex.Message.ToString());
                if (d == DialogResult.OK)
                {
                    lblTestConnectionInform.Visible = false;
                }
            }
        }

        private void MapFieldsToConnnectionStringBuilderProperties()
        {
    
            ConnectionStringBuilder.AuthType = cmbAuthType.SelectedIndex;
            ConnectionStringBuilder.Account = txtAccount.Text;
            ConnectionStringBuilder.Host = txtHost.Text;
            ConnectionStringBuilder.Username = txtUsername.Text;
            ConnectionStringBuilder.Password = txtPassword.Text;
            ConnectionStringBuilder.Database = txtDatabase.Text;
            ConnectionStringBuilder.Schema = txtSchema.Text;
            ConnectionStringBuilder.Warehouse = txtWH.Text;
        }

        private void ShowAlert(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateFields()
        {

            var controls = new[] { txtHost, txtUsername, txtPassword };

            bool isValid = true;
            foreach (var control in controls.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                errorProvider1.SetError(control, "Please fill the required field");
                isValid = false;
            }

            return isValid;
        }

        private bool ValidateHostDomain(string fqdnHost)
        {
            errorProviderHostRegex.Clear();
            var match = Regex.IsMatch(fqdnHost, ".+?\\..+?\\.?snowflakecomputing\\.com");

            if (!match)
            {
                errorProviderHostRegex.SetError(txtHost, "Account URI not in the correct format");
            }
            return match;
        }

        private DialogResult ShowAlertWithResult(string message)
        {
            DialogResult d = MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return d;
        }

        #endregion

 

 
    }
}
