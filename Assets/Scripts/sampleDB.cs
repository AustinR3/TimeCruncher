using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class sampleDB : MonoBehaviour {

	void Start () {

		// Create database
		string connection = "URI=file:" + Application.persistentDataPath + "/" + "My_Database";
		
		// Open connection
		IDbConnection dbcon = new SqliteConnection(connection);
		dbcon.Open();

		// Create table
		IDbCommand dbcmd;
		dbcmd = dbcon.CreateCommand();
		string q_createTable = "CREATE TABLE IF NOT EXISTS level_table1 (id INTEGER PRIMARY KEY, val INTEGER )";
		
		dbcmd.CommandText = q_createTable;
		dbcmd.ExecuteReader();

		// Insert values in table
		IDbCommand cmnd = dbcon.CreateCommand();
		cmnd.CommandText = "INSERT or IGNORE INTO level_table1 (id, val) VALUES (100, 1), (101, 2), (102, 3), (103, 4)";
		cmnd.ExecuteNonQuery();

		// Read and print all values in table
		IDbCommand cmnd_read = dbcon.CreateCommand();
		IDataReader reader;
		string query ="SELECT * FROM level_table1";
		cmnd_read.CommandText = query;
		reader = cmnd_read.ExecuteReader();

		while (reader.Read())
		{
			Debug.Log("id: " + reader[0].ToString());
			Debug.Log("val: " + reader[1].ToString());
		}

		// Close connection
		dbcon.Close();

	}
	
	void Update () {
		
	}
}