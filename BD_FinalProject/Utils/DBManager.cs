using System;

using System.Data.SqlClient;
using System.Data;

public class DBManager
{

	private static DBManager instance;

	private string sgbdConnString;
	private SqlConnection currentConnection;

	private DBManager()
	{
		this.sgbdConnString = "Data Source = mednat.ieeta.pt\\SQLSERVER, 8101; Initial Catalog = p5g6; User ID = p5g6; Password = N&Dp&p$#;";
	}

	public void connect()
	{
		try 
		{ 
			if (currentConnection == null)
				currentConnection = new SqlConnection(sgbdConnString); 
		}
		catch (SqlException e) 
		{
			System.Diagnostics.Debug.WriteLine(e.Message);
		}
	}

	public bool open()
	{
		if (currentConnection != null)
		{
			if (!isOpened())
				currentConnection.Open();
			return true;
		}
		return false;
	}

	public bool isOpened()
	{
		if (currentConnection == null) return false;
		return currentConnection.State == ConnectionState.Open;
	}

	public SqlDataReader executeQuery(String query, SqlParameter[] parameters)
	{
		try
		{
			SqlCommand cmd = new SqlCommand(query, currentConnection);

			if (parameters != null)
            {
				foreach (SqlParameter parameter in parameters)
				{
					cmd.Parameters.Add(parameter);
				}
			}

			return cmd.ExecuteReader();

		}
		catch (SqlException e)
		{
			System.Diagnostics.Debug.WriteLine(e.Message);
			return null; 
		}
	}

	public SqlParameterCollection executeSP(string spName, SqlParameter[] parameters)
    {

        try
        {
			SqlCommand cmd = new SqlCommand(spName, currentConnection);
			cmd.CommandType = CommandType.StoredProcedure;

			foreach (SqlParameter parameter in parameters)
            {
				cmd.Parameters.Add(parameter);
			}

			cmd.ExecuteNonQuery();
			return cmd.Parameters;

		}
		catch (SqlException e)
        {
			System.Diagnostics.Debug.WriteLine(e.Message);
			return null;
        }

    }

	public void close()
    {
		currentConnection.Close();
    }

	public static DBManager getInstance()
    {
		if (instance == null) instance = new DBManager();
		return instance;
    }

}
