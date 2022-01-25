using Newtonsoft.Json;
using POCSnowflakeIndexServer.Interfaces;
using POCSnowflakeIndexServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCSnowflakeIndexServer
{
    public partial class XYAxisAggregationWithFilterForm : Form
    {
        private string Database;
        private string Schema;
        private string Table;
        private string Column;
        private string Aggregate;
        private string XAxisLabel;
        private string YAxisLabel;  
        private string Operator;
        private string Value;
        private string Filter;
        private int counter = 0;
        private string filterFormat;
        private IQueryAsParameterService _service;
        private List<string> _filters;

        public XYAxisAggregationWithFilterForm()
        {
            InitializeComponent();
        }

        public XYAxisAggregationWithFilterForm(IQueryAsParameterService ISimpleAggregationService)
        {
            _service = ISimpleAggregationService;
            InitializeComponent();
        }

        #region Form Object Events
        private void SimpleAggregationForm_Load(object sender, EventArgs e)
        {
            InitialLoad();
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            cmbSchema.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbColumn.SelectedIndex = 0;
            cmbMeasureType.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            _filters.Clear();
            UpdateQueryTextBox();
            txtResult.Text = "";
        }

        private void btnRunAggregation_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ClearSelection();
                txtResult.Text = "";
                var dt = (DataTable)_service.Get(txtQuery.Text).Result;
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;

                txtResult.Text = dt.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

        }

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedIndex > 0)
            {
                Database = cmbDatabase.SelectedItem.ToString();
            }

            cmbSchema.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbColumn.SelectedIndex = 0;
            cmbMeasureType.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0; 
            cmbFilter.SelectedIndex = 0;

            var firstItem = cmbSchema.Items[0];
            cmbSchema.Items.Clear();
            cmbSchema.Items.Add(firstItem);

            if (cmbDatabase.SelectedIndex > 0)
                LoadSchemaCollection();

            bool enabled = EnableGenerateButton();

            if (enabled)
            {
                btnAddFilter.Enabled = true;
            }
            else
            {
                btnAddFilter.Enabled = false;
            }

            counter = 0;
            UpdateQueryTextBox();
        }

        private void cmbSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSchema.SelectedIndex > 0)
            {
                Schema = cmbSchema.SelectedItem.ToString();
            }
            cmbTable.SelectedIndex = 0;
            cmbColumn.SelectedIndex = 0;
            cmbMeasureType.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            UpdateQueryTextBox();

            var firstItem = cmbTable.Items[0];
            cmbTable.Items.Clear();
            cmbTable.Items.Add(firstItem);

            firstItem = cmbColumn.Items[0];
            cmbColumn.Items.Clear();
            cmbColumn.Items.Add(firstItem);

            firstItem = cmbAxisX.Items[0];
            cmbAxisX.Items.Clear();
            cmbAxisX.Items.Add(firstItem);

            firstItem = cmbAxisY.Items[0];
            cmbAxisY.Items.Clear();
            cmbAxisY.Items.Add(firstItem);

            firstItem = cmbFilter.Items[0];
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(firstItem);

            if (cmbSchema.SelectedIndex > 0)
                LoadTableCollection();

            bool enabled = EnableGenerateButton();

            if (enabled)
            {
                btnAddFilter.Enabled = true;
            }
            else
            {
                btnAddFilter.Enabled = false;
            }

            counter = 0;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex > 0)
            {
                Table = cmbTable.SelectedItem.ToString();
            }
            cmbColumn.SelectedIndex = 0;
            cmbMeasureType.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
            UpdateQueryTextBox();

            bool enabled = EnableGenerateButton();

            var firstItem = cmbColumn.Items[0];
            cmbColumn.Items.Clear();
            cmbColumn.Items.Add(firstItem);

            firstItem = cmbAxisX.Items[0];
            cmbAxisX.Items.Clear();
            cmbAxisX.Items.Add(firstItem);

            firstItem = cmbAxisY.Items[0];
            cmbAxisY.Items.Clear();
            cmbAxisY.Items.Add(firstItem);

            firstItem = cmbFilter.Items[0];
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(firstItem);

            LoadColumnCollection(cmbMeasureType.SelectedItem.ToString());

            if (enabled)
            {
                btnAddFilter.Enabled = true;
            }
            else
            {
                btnAddFilter.Enabled = false;
            }

            counter = 0;

        }

        private void cmbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Column = cmbColumn.SelectedItem.ToString();
            UpdateQueryTextBox();
        }

        private void cmbMeasureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstItem = cmbColumn.Items[0];
            cmbColumn.Items.Clear();
            cmbColumn.Items.Add(firstItem);

            cmbAxisX.Items.Clear();
            cmbAxisX.Items.Add(firstItem);

            cmbAxisY.Items.Clear();
            cmbAxisY.Items.Add(firstItem);

            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(firstItem);

            Aggregate = cmbMeasureType.SelectedItem.ToString();
            UpdateQueryTextBox();
            LoadColumnCollection(Operator);

            cmbColumn.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
        }

        private void cmbAxisX_SelectedIndexChanged(object sender, EventArgs e)
        {
            XAxisLabel = cmbAxisX.SelectedItem.ToString();
            UpdateQueryTextBox();
        }


        private void cmbAxisY_SelectedIndexChanged(object sender, EventArgs e)
        {
            YAxisLabel = cmbAxisY.SelectedItem.ToString();
            UpdateQueryTextBox();
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


        #endregion

        #region Helpers
        private void InitialLoad()
        {
            _filters = new List<string>();
            Database = "";
            Schema = "";
            Table = "";
            Column = "";
            Operator = "";
            Value = "";
            XAxisLabel = "";
            YAxisLabel = "";
            cmbDatabase.SelectedIndex = 0;
            cmbSchema.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbColumn.SelectedIndex = 0;
            cmbMeasureType.SelectedIndex = 0;
            cmbAxisX.SelectedIndex = 0;
            cmbAxisY.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;

            LoadDatabaseCollection();
            btnAddFilter.Enabled = false;

            //load database collection first before setting the index to 1
            cmbDatabase.SelectedIndex = 1;
        }

        private void LoadDatabaseCollection()
        {
            var collection = StaticObjects.schemaListModelList.Where(db => db.database_name == StaticObjects.SelectedDatabase)
                                                              .GroupBy(e => e.database_name)
                                                              .Select(grp => grp.First());


            foreach (var item in collection)
            {
                cmbDatabase.Items.Add(item.database_name);
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
                cmbSchema.Items.Add(item.schema_name);
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
                cmbTable.Items.Add(item.table_name);
            }
        }

        private void LoadColumnCollection()
        {
            var collection = StaticObjects.schemaListModelList.Where(filter => filter.database_name == Database && filter.schema_name == Schema && filter.table_name == Table)
                            .GroupBy(e => e.column_name)
                            .Select(grp => grp.First()).ToList();


            foreach (var item in collection)
            {
                cmbColumn.Items.Add(item.column_name);
            }
        }

        private void LoadColumnCollection(string selectedItem)
        {
            var collection = StaticObjects.schemaListModelList.Where(filter => filter.database_name == Database && filter.schema_name == Schema && filter.table_name == Table)
                            .GroupBy(e => e.column_name)
                            .Select(grp => grp.First()).ToList();


            foreach (var item in collection)
            {

                cmbAxisX.Items.Add(item.column_name); //load to axis x dd all columns
                cmbAxisY.Items.Add(item.column_name); //load to axis y dd all columns
                cmbFilter.Items.Add(item.column_name);//load to filter dd all columns

                if (selectedItem.ToUpper() == "COUNT")
                    cmbColumn.Items.Add(item.column_name);
                else //columns should be of numeric type
                {
                    var dataType = JsonConvert.DeserializeObject<DataType>(item.data_type);
                    if ((dataType.Type.ToUpper() == "REAL") || (dataType.Type.ToUpper() == "FIXED"))
                    {
                        cmbColumn.Items.Add(item.column_name);
                    }

                }
            }
        }

        private bool EnableGenerateButton()
        {
            bool res = false;

            if ((cmbDatabase.SelectedIndex > 0) && (cmbSchema.SelectedIndex > 0) && (cmbTable.SelectedIndex > 0))
                res = true;

            return res;
        }

        private void UpdateQueryTextBox()
        {
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
            if (Column.Contains("Choose a column..."))
            {
                Column = "<column>";
            }
            if (XAxisLabel.Contains("Choose a column..."))
            {
                XAxisLabel = "<XAxisLabel>";
            }
            if (YAxisLabel.Contains("Choose a column..."))
            {
                YAxisLabel = "<YAxisLabel>";
            }

            if (Column.Any(x => Char.IsWhiteSpace(x)))
            {
                Column = "\"" + Column + "\"";
            }
            if (XAxisLabel.Any(x => Char.IsWhiteSpace(x)))
            {
                XAxisLabel = "\"" + XAxisLabel + "\"";
            }
            if (YAxisLabel.Any(x => Char.IsWhiteSpace(x)))
            {
                YAxisLabel = "\"" + YAxisLabel + "\"";
            }

            string finalQuery = string.Format(@"SELECT {0} as ""X AXIS LABEL"", {1} as ""Y AXIS LABEL"", {2}({3}) AS ""YX VALUE"" FROM ""{4}"".""{5}"".""{6}""", XAxisLabel, YAxisLabel, Aggregate, Column, Database, Schema, Table) + Environment.NewLine;

            foreach (string filter in _filters)
            {
                if(_filters.Contains("WHERE"))
                {
                    finalQuery = finalQuery + filter;
                }
                else
                {
                    finalQuery = finalQuery + Environment.NewLine + filter;
                }
              
            }

            finalQuery = finalQuery + Environment.NewLine + string.Format(@"GROUP BY {0}, {1} ", XAxisLabel, YAxisLabel);
            finalQuery = finalQuery + Environment.NewLine + string.Format(@"ORDER BY {0}, {1} ", XAxisLabel, YAxisLabel);

            txtQuery.Text = finalQuery;
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

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            string currentString = txtQuery.Text;
            Operator = cmbOperator.SelectedItem.ToString();

            var selectedColumnVM = StaticObjects.schemaListModelList.Where(f => (f.column_name == Filter) && (f.database_name == Database) && (f.schema_name == Schema) && (f.table_name == Table))
                                                            .Select(g => new SchemaListModels() { column_name = g.column_name, database_name = g.database_name, data_type = g.data_type, schema_name = g.schema_name, table_name = g.table_name });

            var dataType = JsonConvert.DeserializeObject<DataType>(selectedColumnVM.FirstOrDefault().data_type);
            Value = txtValue.Text;

            if (Column.Any(x => Char.IsWhiteSpace(x)))
            {
                Column = "\"" + Column + "\"";
            }

            if ((cmbColumn.SelectedIndex > 0) && (!String.IsNullOrWhiteSpace(Value)))
            {
                if (counter == 0)
                {
                    filterFormat = string.Format("WHERE {0} {1} {2}", Filter, Operator, Value);
                    currentString = currentString + Environment.NewLine + filterFormat + Environment.NewLine;
                    counter++;
                }
                else if (counter > 0)
                {
                    filterFormat = string.Format("AND {0} {1} {2}", Filter, Operator, Value);
                    currentString = currentString + filterFormat + Environment.NewLine;
                    counter++;
                }
            }

            _filters.Add(filterFormat);
            UpdateQueryTextBox();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter = cmbFilter.SelectedItem.ToString();
        }
    }
}
