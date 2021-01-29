using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace IdeasApp.Models
{
    public class EntryRepository : IDataAccessObject
    {
        private readonly SQLiteConnection _con;

        public EntryRepository(SQLiteConnection dbPath)
        {
            _con = dbPath;
        }

        public List<Entry> ReadAll()
        {
            var queryResult = runQuery("SELECT * FROM Tasks");
            return ConvertResultToEntryList(queryResult);
        }

        public void Create(Entry entry)
        {
            _con.Open();
            var insertCommand = new SQLiteCommand(
                "INSERT INTO Tasks(Category, TaskName, EstimatedTime, Deadline, Priority) " +
                "VALUES(@Category, @TaskName, @EstimatedTime, @Deadline, @Priority); ", _con);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("Category", entry.Category);
            insertCommand.Parameters.AddWithValue("TaskName", entry.TaskName);
            insertCommand.Parameters.AddWithValue("EstimatedTime", entry.EstimatedTime);
            insertCommand.Parameters.AddWithValue("Deadline", entry.Deadline);
            insertCommand.Parameters.AddWithValue("Priority", entry.Priority);

            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            _con.Close();
        }

        public void Update(Entry entry)
        {
            _con.Open();
            var updateCommand = new SQLiteCommand(
                "UPDATE Tasks SET " +
                "Category = @Category, " +
                "TaskName = @TaskName, " +
                "EstimatedTime = @EstimatedTime, " +
                "Deadline = @Deadline, " +
                "Priority = @Priority " +
                "WHERE Id=@Id;", _con);

            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("Category", entry.Category);
            updateCommand.Parameters.AddWithValue("TaskName", entry.TaskName);
            updateCommand.Parameters.AddWithValue("EstimatedTime", entry.EstimatedTime);
            updateCommand.Parameters.AddWithValue("Deadline", entry.Deadline);
            updateCommand.Parameters.AddWithValue("Priority", entry.Priority);
            updateCommand.Parameters.AddWithValue("Id", entry.Id);

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            _con.Close();
        }

        public void Delete(Entry entry)
        {
            _con.Open();
            var insertCommand = new SQLiteCommand(
                "Delete from Tasks where Id=@Id", _con);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("Id", entry.Id);

            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            _con.Close();
        }

        public Entry ReadById(int id)
        {
            var queryResult = runQuery($"SELECT * FROM Tasks WHERE Id = {id}");
            //return ConvertResultToEntryList(queryResult);
            return null;
        }


        private EnumerableRowCollection<DataRow> runQuery(string query)
        {
            var adapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();
            var command = new SQLiteCommand(query, _con);
            adapter.SelectCommand = command;
            _con.Open();
            command.ExecuteNonQuery();
            adapter.Fill(dataTable);
            _con.Close();
            return dataTable.AsEnumerable();
        }

        public List<Entry> ConvertResultToEntryList(EnumerableRowCollection<DataRow> QueryResult)
        {
            var Entries = (from row in QueryResult
                select new Entry
                {
                    Id = row.Field<long>("Id"),
                    Category = row.Field<string>("Category"),
                    TaskName = row.Field<string>("TaskName"),
                    Deadline = row.Field<DateTime>("Deadline"),
                    Priority = row.Field<string>("Priority"),
                    EstimatedTime = row.Field<int>("EstimatedTime")
                }).ToList();
            return Entries;
        }


        public Entry ConvertResultToEntry(DataRow QueryResult)
        {
            var entry = new Entry();
            entry.Id = QueryResult.Field<long>("Id");
            entry.Category = QueryResult.Field<string>("Category");
            entry.TaskName = QueryResult.Field<string>("TaskName");
            entry.Deadline = QueryResult.Field<DateTime>("Deadline");
            entry.Priority = QueryResult.Field<string>("Priority");
            entry.EstimatedTime = QueryResult.Field<int>("EstimatedTime");
            return entry;
        }
    }
}