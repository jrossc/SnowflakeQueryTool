
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using POCSnowflakeIndexServer.Controllers;
using POCSnowflakeIndexServer.Interfaces;
using POCSnowflakeIndexServer.Models;
using System;
using System.Collections;
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
    public partial class SchemaListForm : Form
    {
        private string JsonList;
        private readonly IServiceProvider serviceProvider;
        private ISpecificQueryService _ISchemaList;

        public SchemaListForm()
        {
            InitializeComponent();
        }
        public SchemaListForm(IServiceProvider serviceProvider, ISpecificQueryService ISchemaList)
        {
             InitializeComponent();
            this.serviceProvider = serviceProvider;
            _ISchemaList = ISchemaList;
        }

        #region Form Object Events
        private void SchemaListForm_Load(object sender, EventArgs e)
        {

            var ctrl = new SpecificQueryController();
            JsonList = _ISchemaList.Get().Result.ToString();
            StaticObjects.schemaListModelList = JsonConvert.DeserializeObject<SchemaListModels[]>(JsonList);
            FillTreeView(StaticObjects.schemaListModelList);
        }
        private void FillTreeView(SchemaListModels[] schemaArr)
        {
            StringBuilder sb = new StringBuilder();
            treeViewSchemaList.BeginUpdate();
            treeViewSchemaList.Nodes.Clear();


            string currentDatabaseParent = "";
            string currentSchemaParent = "";
            string currentTableParent = "";

            int databasecount = 0;
            int schemacount = 0;
            int tablecount = 0;
            int columncount = 0;


            foreach (var schema in schemaArr)
            {
                int order = Array.IndexOf(schemaArr, schema);
                if ((schema.column_name != "NUMBER") && (schema.schema_name != "INFORMATION_SCHEMA"))
                {
                    //PARENT
                    if (currentDatabaseParent == "")
                    {
                        treeViewSchemaList.Nodes.Add("Database: " + schema.database_name);
                        sb.AppendLine(schema.database_name);
                        currentDatabaseParent = schema.database_name;
                    }
                    else if (currentDatabaseParent != schema.database_name)
                    {
                        treeViewSchemaList.Nodes.Add("Database: " + schema.database_name);
                        sb.AppendLine(schema.database_name);
                        currentDatabaseParent = schema.database_name;
                        databasecount = databasecount + 1;
                        schemacount = schemacount + 1;
                        currentSchemaParent = "";
                        currentTableParent = "";
                        tablecount = 0;
                        columncount = 0;
                    }

                    //CHILD
                    if (currentSchemaParent == "")
                    {
                        treeViewSchemaList.Nodes[schemacount].Nodes.Add("Schema: " + schema.schema_name);
                        sb.AppendLine("     - " + schema.schema_name);
                        currentSchemaParent = schema.schema_name;
                    }
                    else if (currentSchemaParent != schema.schema_name)
                    {

                        treeViewSchemaList.Nodes[schemacount].Nodes.Add("Schema: " + schema.schema_name);
                        sb.AppendLine("     - " + schema.schema_name);
                        currentSchemaParent = schema.schema_name;
                        tablecount = tablecount + 1;
                        columncount = 0;
                        currentTableParent = "";
                    }


                    // GRANDCHILD
                    if (currentTableParent == "")
                    {
                        treeViewSchemaList.Nodes[schemacount].Nodes[tablecount].Nodes.Add("Table: " + schema.table_name);
                        sb.AppendLine("          - " + schema.table_name);
                        currentTableParent = schema.table_name;

                    }
                    else if (currentTableParent != schema.table_name)
                    {
                        treeViewSchemaList.Nodes[schemacount].Nodes[tablecount].Nodes.Add("Table: " + schema.table_name);
                        sb.AppendLine("          - " + schema.table_name);
                        currentTableParent = schema.table_name;
                        columncount = columncount + 1;
                    }


                    DataType dataType = new DataType();
                    dataType = JsonConvert.DeserializeObject<DataType>(schema.data_type);
                    sb.AppendLine("               - " + schema.column_name + "(" + dataType.Type + ")");


                    treeViewSchemaList.Nodes[schemacount].Nodes[tablecount].Nodes[columncount].Nodes.Add("Column: " + schema.column_name + " (" + dataType.Type.ToLower() + ")");
                }
            }


            treeViewSchemaList.EndUpdate();
            string finalList = sb.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] selectedNode = treeViewSchemaList.SelectedNode.Text.Split(':');

            if(selectedNode[0] == "Database")
            {
                StaticObjects.SelectedDatabase = selectedNode[1].Trim();
                var form2 = serviceProvider.GetRequiredService<SimpleQueryForm>();
                form2.ShowDialog(this);

            }
            else
            {
                lblSelectedDatabase.Text = "Select a parent node before proceeding...";
            }

        }
        private void treeViewSchemaList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var obs = treeViewSchemaList.SelectedNode;
            lblSelectedDatabase.Text = obs.Text;
        }
        private void btnGoToSimpleAggregation_Click(object sender, EventArgs e)
        {
            string[] selectedNode = treeViewSchemaList.SelectedNode.Text.Split(':');

            if (selectedNode[0] == "Database")
            {
                StaticObjects.SelectedDatabase = selectedNode[1].Trim();
                var form2 = serviceProvider.GetRequiredService<SimpleAggregationForm>();
                form2.ShowDialog(this);

            }
            else
            {
                lblSelectedDatabase.Text = "Select a parent node before proceeding...";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] selectedNode = treeViewSchemaList.SelectedNode.Text.Split(':');

            if (selectedNode[0] == "Database")
            {
                StaticObjects.SelectedDatabase = selectedNode[1].Trim();
                var form2 = serviceProvider.GetRequiredService<XAxisAggregationForm>();
                form2.ShowDialog(this);

            }
            else
            {
                lblSelectedDatabase.Text = "Select a parent node before proceeding...";
            }
        }
        private void btn2ColAggregation_Click(object sender, EventArgs e)
        {
            string[] selectedNode = treeViewSchemaList.SelectedNode.Text.Split(':');

            if (selectedNode[0] == "Database")
            {
                StaticObjects.SelectedDatabase = selectedNode[1].Trim();
                var form2 = serviceProvider.GetRequiredService<XYAxisAggregationForm>();
                form2.ShowDialog(this);
            }
            else
            {
                lblSelectedDatabase.Text = "Select a parent node before proceeding...";
            }
        }

        #endregion

        private void btn2colWithFilterAggregation_Click(object sender, EventArgs e)
        {
            string[] selectedNode = treeViewSchemaList.SelectedNode.Text.Split(':');

            if (selectedNode[0] == "Database")
            {
                StaticObjects.SelectedDatabase = selectedNode[1].Trim();
                var form2 = serviceProvider.GetRequiredService<XYAxisAggregationWithFilterForm>();
                form2.ShowDialog(this);
            }
            else
            {
                lblSelectedDatabase.Text = "Select a parent node before proceeding...";
            }
        }
    }
}
