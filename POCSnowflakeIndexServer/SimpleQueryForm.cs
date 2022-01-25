using Newtonsoft.Json;
using POCSnowflakeIndexServer.Controllers;
using POCSnowflakeIndexServer.Interfaces;
using POCSnowflakeIndexServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCSnowflakeIndexServer
{
    public partial class SimpleQueryForm : Form
    {
        private string Database;
        private string Schema;
        private string Table;
        private string Column;
        private string Aggregate;
        private string Operator;
        private string Value;
        private int counter = 0;
        private string filterFormat;

        private readonly IQueryAsParameterService _service;


        public SimpleQueryForm()
        {
            var currentScreen = Screen.FromControl(this).Bounds;
            InitializeComponent();
        }

        public SimpleQueryForm(IQueryAsParameterService service)
        {
            var currentScreen = Screen.FromControl(this).Bounds;
            InitializeComponent();
            _service = service;
        }

        #region Form Object Events
        private void SimpleQueryForm_Load(object sender, EventArgs e)
        {

            this.Resize += SimpleQueryForm_Resize;
            this.dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
            InitialLoad();
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int cols = dataGridView1.Columns.Count;
            int counter = 0;

            while (counter <= cols - 1)
            {
                if (counter != cols - 1)
                    this.dataGridView1.Columns[counter].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                else
                    this.dataGridView1.Columns[counter].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                counter++;
            }
        }

        private void SimpleQueryForm_Resize(object sender, EventArgs e)
        {
            FormWindowState LastWindowState = FormWindowState.Minimized;

            var currentScreen = Screen.FromControl(this).Bounds;

            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {

                    var heightForGridView = (double)currentScreen.Height - 302;
                    var widthForGridView = (double)currentScreen.Width - 187;
                    dataGridView1.Size = new Size(Convert.ToInt32(widthForGridView), Convert.ToInt32(heightForGridView));

                    cmbSQFTable.Size = new Size(160, 21);
                    cmbSQFColumn.Size = new Size(300, 21);
                    flowLayoutPanel1.Size = new Size(1560, 55);

                }
                if (WindowState == FormWindowState.Normal)
                {
                    if (currentScreen.Width >= 1024)
                        dataGridView1.Size = new Size(currentScreen.Width - 808, currentScreen.Width - 466);
                    cmbSQFTable.Size = new Size(144, 21);
                    cmbSQFColumn.Size = new Size(144, 21);
                    flowLayoutPanel1.Size = new Size(1132, 55);
                }
            }
        }

        private void btnSQFAddFilter_Click(object sender, EventArgs e)
        {

            string currentString = txtSQFQuery.Text;
            Operator = cmbSQFOperator.SelectedItem.ToString();

            var selectedColumnVM = StaticObjects.schemaListModelList.Where(f => (f.column_name == Column) && (f.database_name == Database) && (f.schema_name == Schema) && (f.table_name == Table))
                                                            .Select(g => new SchemaListModels() { column_name = g.column_name, database_name = g.database_name, data_type = g.data_type, schema_name = g.schema_name, table_name = g.table_name });

            var dataType = JsonConvert.DeserializeObject<DataType>(selectedColumnVM.FirstOrDefault().data_type);
            Value = txtSQFValue.Text;

            if (Column.Any(x => Char.IsWhiteSpace(x)))
            {
                Column = "\"" + Column + "\"";
            }

            if ((cmbSQFColumn.SelectedIndex > 0) && (!String.IsNullOrWhiteSpace(Value)))
            {
                if (counter == 0)
                {
                    filterFormat = string.Format("WHERE {0} {1} {2}", Column, Operator, Value);
                    currentString = currentString + Environment.NewLine + filterFormat + Environment.NewLine;
                    counter++;
                }
                else if (counter > 0)
                {
                    filterFormat = string.Format("AND {0} {1} {2}", Column, Operator, Value);
                    currentString = currentString + filterFormat + Environment.NewLine;
                    counter++;
                }
            }
            txtSQFQuery.Text = currentString;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbSQFDatabase.SelectedIndex = 0;
            cmbSQFDatabase.SelectedIndex = 1;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Visible = false;
                progressBar1.Visible = true;
                dataGridView1.ClearSelection();
                var dt = (DataTable)_service.Get(txtSQFQuery.Text).Result;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = dt.Rows.Count;

                var progress = new Progress<int>(percent =>
                {
                    progressBar1.Value = percent;

                });
                var progress2 = new Progress<int>(percent =>
                {

                    lblStatus.Text = (percent) * 100 + "% loaded";

                });

                await Task.Run(() => GenerateProgressBar(dt, progress));

                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }


        }

        private void cmbSQFDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSQFDatabase.SelectedIndex > 0)
            {
                Database = cmbSQFDatabase.SelectedItem.ToString();
            }

            cmbSQFSchema.SelectedIndex = 0;
            cmbSQFTable.SelectedIndex = 0;
            cmbSQFColumn.SelectedIndex = 0;
            cmbSQFOperator.SelectedIndex = 0;
            //Map();
            UpdateQueryTextBox();



            var firstItem = cmbSQFSchema.Items[0];
            cmbSQFSchema.Items.Clear();
            cmbSQFSchema.Items.Add(firstItem);

            if (cmbSQFDatabase.SelectedIndex > 0)
                LoadSchemaCollection();

            bool enabled = EnableGenerateButton();

            if (enabled)
            {
                btnGenerate.Enabled = true;
            }
            else
            {
                btnGenerate.Enabled = false;
            }

            counter = 0;
        }

        private void cmbSQFSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSQFSchema.SelectedIndex > 0)
            {
                Schema = cmbSQFSchema.SelectedItem.ToString();
            }
            cmbSQFTable.SelectedIndex = 0;
            cmbSQFColumn.SelectedIndex = 0;
            cmbSQFOperator.SelectedIndex = 0;
           // Map();
            UpdateQueryTextBox();

            var firstItem = cmbSQFTable.Items[0];
            cmbSQFTable.Items.Clear();
            cmbSQFTable.Items.Add(firstItem);

            if (cmbSQFSchema.SelectedIndex > 0)
                LoadTableCollection();

            bool enabled = EnableGenerateButton();

            if (enabled)
            {
                btnGenerate.Enabled = true;
            }
            else
            {
                btnGenerate.Enabled = false;
            }

            counter = 0;

        }

        private void cmbSQFTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSQFTable.SelectedIndex > 0)
            {
                Table = cmbSQFTable.SelectedItem.ToString();
            }
            cmbSQFColumn.SelectedIndex = 0;
            cmbSQFOperator.SelectedIndex = 0;
            //Map();
            UpdateQueryTextBox();

            bool enabled = EnableGenerateButton();

            var firstItem = cmbSQFColumn.Items[0];
            cmbSQFColumn.Items.Clear();
            cmbSQFColumn.Items.Add(firstItem);

            if (cmbSQFTable.SelectedIndex > 0)
                LoadColumnCollection();

            if (enabled)
            {
                btnGenerate.Enabled = true;
            }
            else
            {
                btnGenerate.Enabled = false;
            }

            counter = 0;
        }

        private void cmbSQFColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Column = cmbSQFColumn.SelectedItem.ToString();
        }

        private void cmbSQFOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSQFColumn.SelectedIndex = 0;
        }

        #endregion

        #region Helpers
        private void UpdateQueryTextBox()
        {
            string selectAll = "SELECT * FROM ";

            if (Database.Contains("Choose a database..."))
            {
                Database = "";
            }
            if (Schema.Contains("Choose a schema..."))
            {
                Schema = "";
            }
            if (Table.Contains("Choose a table..."))
            {
                Table = "";
            }

            string finalQuery = selectAll + Database.ToUpper();

            if (!@String.IsNullOrWhiteSpace(Schema))
            {
                finalQuery = selectAll + "\"" + Database.ToUpper() + "\".\"" + Schema.ToUpper() + "\"";

                if (!@String.IsNullOrWhiteSpace(Table))
                {
                    finalQuery = selectAll + "\"" + Database.ToUpper() +"\".\"" + Schema.ToUpper()  +"\".\"" + Table.ToUpper() + "\"";
                }

            }

            txtSQFQuery.Text = finalQuery;

        }

        private bool EnableGenerateButton()
        {
            bool res = false;

            if ((cmbSQFDatabase.SelectedIndex > 0) && (cmbSQFSchema.SelectedIndex > 0) && (cmbSQFTable.SelectedIndex > 0))
                res = true;

            return res;
        }

        private void InitialLoad()
        {
            Database = "";
            Schema = "";
            Table = "";
            Column = "";
            Operator = "";
            Value = "";
            cmbSQFDatabase.SelectedIndex = 0;
            cmbSQFSchema.SelectedIndex = 0;
            cmbSQFTable.SelectedIndex = 0;
            cmbSQFColumn.SelectedIndex = 0;
            cmbSQFOperator.SelectedIndex = 0;

            //Map();
            UpdateQueryTextBox();
            LoadDatabaseCollection();
            btnGenerate.Enabled = false;
            progressBar1.Visible = false;
            lblStatus.Visible = false;

            cmbSQFDatabase.SelectedIndex = 1;


        }

        private void LoadDatabaseCollection()
        {
            var collection = StaticObjects.schemaListModelList.Where(db => db.database_name == StaticObjects.SelectedDatabase)
                                                              .GroupBy(e => e.database_name)
                                                              .Select(grp => grp.First());


            foreach (var item in collection)
            {
                cmbSQFDatabase.Items.Add(item.database_name);
            }
        }

        private void LoadSchemaCollection()
        {

            var collection = StaticObjects.schemaListModelList.Where(filter => filter.database_name == Database)
                                      .GroupBy(e => e.schema_name)
                                      .Select(grp => grp.First())
                                      .ToList();

            foreach (var item in collection)
            {
                cmbSQFSchema.Items.Add(item.schema_name);
            }

        }

        private void LoadTableCollection()
        {
            var collection = StaticObjects.schemaListModelList
                .Where(filter => filter.database_name == Database && filter.schema_name == Schema)
                                                  .GroupBy(e => e.table_name)
                                                 .Select(grp => grp.First()).ToList();
                                                 
            foreach (var item in collection)
            {
                cmbSQFTable.Items.Add(item.table_name);
            }
        }

        private void LoadColumnCollection()
        {
            var collection = StaticObjects.schemaListModelList.Where(filter => filter.database_name == Database && filter.schema_name == Schema && filter.table_name == Table)
                            .GroupBy(e => e.column_name)
                            .Select(grp => grp.First()).ToList();
                                     

            foreach (var item in collection)
            {
                cmbSQFColumn.Items.Add(item.column_name);
            }
        }

        //private void Map()
        //{
        //    Database = cmbSQFDatabase.SelectedItem.ToString();
        //    Schema = cmbSQFSchema.SelectedItem.ToString();
        //    Table = cmbSQFTable.SelectedItem.ToString();
        //    Column = cmbSQFColumn.SelectedItem.ToString();
        //    Operator = cmbSQFOperator.SelectedItem.ToString();
        //    Value = txtSQFValue.Text;
        //}

        private void GenerateProgressBar(DataTable dt, IProgress<int> progress)
        {
            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                if (progress != null)
                    progress.Report(i);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowError(Exception ex)
        {
            if (!String.IsNullOrWhiteSpace(ex.InnerException.ToString()))
            {
                MessageBox.Show("Error: " + ex.Message + Environment.NewLine + Environment.NewLine + ex.InnerException + Environment.NewLine + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error: " + ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }



        #endregion
    }
}
