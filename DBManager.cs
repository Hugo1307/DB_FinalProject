using System;

using System.Data.SqlClient;

public class DBManager
{

	string sgbdConnectionString;

	public DBManager(string sgbdConnectionString)
	{
		this.sgbdConnectionString = sgbdConnectionString;
	}

	public SqlConnection connect()
    {
		return new SqlConnection(sgbdConnectionString);

	}

}
