using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
namespace ShoeStore2020.Data
{
    public class DAL
    {//הגדרת משתנים
        private static DAL instance;
        private OleDbConnection con;
        private DataSet ds;
        private Hashtable adapters;

        //בנאי המחלקה
        private DAL(string connectionString)
        {
            con = new OleDbConnection(connectionString);
            ds = new DataSet();
            adapters = new Hashtable();
        }
        //בניית עצם של  וחיבור למאגרDAL
        public static DAL GetInstance()
        {

            if (instance == null)
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                int x = path.IndexOf("\\bin");
                path = path.Substring(0, x) + "\\bin\\Debug\\GuyProjectShoes.accdb";
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\WindowsFormsApplication2\WindowsFormsApplication1\Data\projects.accdb
                instance = new DAL(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Persist Security Info=True");
            }
            return instance;
        }
       
        /// פעולה המוסיפה טבלה ל- Dataset
        /// ומכינה את האדפטר לביצוע כל פעולות העידכון
        /// "tableName">שם הטבלה<
        ///"sqlStat">שאילתת שליפה<
        public bool AddTable(string tableName, string sqlStat)
        {
            if (!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStat, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.Fill(ds, tableName);
                adapters.Add(tableName, adapter);
                return true;
            }
            return false;
        }
       
        //בנית פעולת השאילתא ב select
       
        public bool AddTable(string tableName)
        {
            return AddTable(tableName, "Select * from " + tableName);
        }
        //קבלת נתוני טבלה
        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }
        //מחיקת טבלה
        public bool RemoveTable(string tableName)
        {
            bool suceed = true;
            try
            {
                ds.Tables.Remove(tableName);
                adapters.Remove(tableName);
            }
            catch
            {
                suceed = false;
            }
            return suceed;
        }
        //עדכון נתונים במסד הנתונים
        public int ExecuteNonQuery(string sqlQry)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlQry;
            con.Open();
            int x = command.ExecuteNonQuery();
            con.Close();
            return x;
        }
        //שליפת הנתונים מהמאגר לפי השאילתא
        public object ExecuteScalarQuery(string sqlStr)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlStr;
            con.Open();
            object obj = command.ExecuteScalar();
            con.Close();
            return obj;

        }
        //עדכון נתונים למאגר
        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = (OleDbDataAdapter)adapters[tableName];
            adapter.Update(ds, tableName);
           
        }
        //עדכון לכל הטבלאות
        public void Update()
        {
            foreach (DataTable table in ds.Tables)
            {
                Update(table.TableName);
            }
        }
        //הוספת קשרי גומלין
        public void AddRelation(string relName, DataColumn primaryKey, DataColumn foreignKey)
        {
            try
            {
                ds.Relations.Add(relName, primaryKey, foreignKey);
            }
            catch { }
        }
        //הסרת קשרי גומלין
        public void RemoveRelation(string relName)
        {
            try
            {
                ds.Relations.Remove(relName);
            }
            catch { }
        }
        //הצגת טבלה לפי שאילתה
        
        public DataTable GetDisplayTable(string name, string sqlStat)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter(sqlStat, con);
            ad.Fill(dt);

            return dt;
        }


        
    }
}
