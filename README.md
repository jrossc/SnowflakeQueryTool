# Snowflake Query Tool
## Description

The Snowflake Query Tool is a Windows Desktop Application that is part of my proof of concept development demonstrating the execution of T-SQL queries from a Snowflake account.

The application references the [Snowflake Connector for .NET Library](https://docs.snowflake.com/en/user-guide/dotnet-driver.html) [(github repository)](https://github.com/snowflakedb/snowflake-connector-net) that is available for download via NuGet.

## Application Contents

The application contains six forms which represent the six phases of the development namely:

### Connection Forms

* Connection Establishment Form (ConnectForm.cs) - this form retrieves Snowflake account information such as the hostname, username and password of the account that is to be used in forming the connection string.
The connection string is set in a static variable and is used althroughout the other forms and is only active upon successful connection establishment and the whole time that the Schema Discovery form is opened

* Schema Discovery Form (SchemaListForm.cs) - this form is opened upon succeessful connection establishment. 
Upon opening the form, it runs a T-SQL query (show columns in account) to return a list of objects that is presented in a Tree View format.
The bottom part of the form features four different links to four other forms representing different scenarios in running T-SQL Queries. 
The forms can be opened upon selection of a parent node.

### Data Retrieval Forms

* Simple Query Form (SimpleQueryForm.cs) - This form enables a user to retrieve all data from a particular table, with or without filters 
by selecting from dropdown fields to form a query that is equivalent to running

> SELECT * FROM TABLE (WHERE filter = 'param' AND filter = 'param2'... etc)

* Simple Aggregation Form (SimpleAggregationForm.cs) - This form enables a user to retrieve all data from a particular table, without filters 
by selecting from dropdown fields to form a query that is equivalent to running

> SELECT '' AS 'ALIAS', (AGGREGATE)field FROM TABLE 

* One Column Aggregation Form (XAxisAggregationForm.cs) - This form enables a user to retrieve all data from a particular table, without filters 
by selecting from dropdown fields, including the `fieldA` to form a query that is equivalent to running

> SELECT fieldA AS 'ALIAS', (AGGREGATE)fieldB FROM TABLE GROUP BY fieldA

* Two Column Aggregation Form (XYAxisAggregationForm.cs) - This form enables a user to retrieve all data from a particular table, without filters 
by selecting from dropdown fields, including the `fieldA` and `fieldB` to form a query that is equivalent to running

> SELECT fieldA AS 'ALIAS', fieldB as 'ALIAS2' (AGGREGATE)fieldB FROM TABLE GROUP BY fieldA, fieldB

* Two Column Aggregation Form (XYAxisAggregationWithFilterForm.cs) - This form enables a user to retrieve all data from a particular table, with or without filters 
by selecting from dropdown fields, including the `fieldA` and `fieldB` to form a query that is equivalent to running

> SELECT fieldA AS 'ALIAS', fieldB as 'ALIAS2' (AGGREGATE)fieldB FROM TABLE (WHERE filter = 'param' AND filter = 'param2'... etc) GROUP BY fieldA, fieldB
