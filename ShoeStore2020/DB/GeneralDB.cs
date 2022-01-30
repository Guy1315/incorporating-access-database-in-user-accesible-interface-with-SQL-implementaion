using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoeStore2020.Model;
using System.Data;
using ShoeStore2020.Data;
namespace ShoeStore2020.DB

{
    public abstract class GeneralDB
    {//המאפיינים
        protected DataTable table;
        protected int currentRow;
        protected string primaryKey;

        //  הבנאי פונה לדאל כדי להביא את נתוני הטבלה מהמאדר לזכרון .שיטה בונה
        public GeneralDB(string tableName, string primaryKey)
        {
            DAL.GetInstance().AddTable(tableName);
            table = DAL.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }
        //פעולות ניווט
        #region NAVIGATION
      
        /// מעדכן את השרה הנוכחית לשורה הראשונה
      
        public void GoToFirst()
        {
            if (IsEmpty())
                throw new Exception("ניווט על טבלה ריקה");
            currentRow = 0;
        }

       
        /// מעדכן את השורה הנוכחית לשורה האחרונה
        
        public void GoToLast()
        {
            if (IsEmpty())
                throw new Exception("ניווט על טבלה ריקה");
            currentRow = table.Rows.Count - 1;
        }
        
        /// עובר לשורה הבאה בטבלה. אם אנחנו בסוף חוזרים להתחלה
     
        public void MoveNext()
        {
            if (IsEmpty())
                throw new Exception("ניווט על טבלה ריקה");
            currentRow = (currentRow + 1) % table.Rows.Count;
        }
        
        /// moves to the previous object. If reaches the beginning, goes back
        /// to the end
       
        public void MovePrev()
        {
            if (IsEmpty())
                throw new Exception("ניווט על טבלה ריקה");
            if (this.currentRow == 0)
                currentRow = table.Rows.Count - 1;
            else
                --currentRow;
        }

        
        /// חיפוש האובייקט באמצעות המפתח
           ///"key">the key being looked for
        /// <returns>true if found and false if no such row  exists
        public bool Find(object key)
        {
            int r = 0;
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(key))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }


        #endregion

        #region GENERAL OPERATIONS
        
        /// מחזיר מספר השורות בטבלה
       
        /// <returns>number of rows</returns>
        public int Size()
        {
            return table.Rows.Count;
        }
        
        /// בודק האם הטבלה ריקה
        
        /// <returns> true if empty, false if not empty<

        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }
        public virtual void Save()
        {
           
           DAL.GetInstance().Update(table.TableName);
        }
        #endregion

        public DataRow[] Filter(string filterString)
        {
            if (filterString.Trim().Length == 0)
                return table.Select();
            return table.Select(filterString);
        }
        #region CRUD

        //הוספה קריאה עדכוןומחיקה
        //מוסיפה שורה לטבלה עם שימוש בממשק
        public void Add(IEntity obj)
        {
            DataRow dr = table.NewRow();
            obj.Populate(dr);
            table.Rows.Add(dr);
            Find(dr[primaryKey]);

        }
        ////עדכון נתונים עם ממשק באובייקט
        public void UpdateRow(IEntity obj)
        {
            DataRow dr = GetCurrentRow();
            obj.Populate(dr);

        }
        public virtual void DeleteCurrentRow()
        {
            DataRow dr = GetCurrentRow();
            table.Rows.Remove(dr);
            dr.Delete();
            if (IsEmpty())
                this.currentRow = -1;
            if (this.currentRow == Size())
                this.currentRow = 0;
        }
        #endregion
        //מאחזר שורה נוכחית בטבלה
        public virtual DataRow GetCurrentRow()
        {
            return table.Rows[currentRow];
        }
       public DataTable GetTable() { return this.table; }

    }

}

