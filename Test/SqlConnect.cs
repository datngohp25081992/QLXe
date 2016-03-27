using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SqlLibs
{
    /// <summary>
    /// Class này dùng để kết nối tới PostgreSQL
    /// </summary>
    public class SqlConnect
    {
        #region Xử lý lỗi
        public static bool Error = false;
        public static string ErrorMessage = "";
        static void ShowError(string st)
        {
            MessageBox.Show(st, "SqlLibs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Hàm thông báo lỗi nếu có lỗi kết nối CSDL
        /// </summary>
        public static void ShowErrorDetail()
        {
            if (!Error) return;
            ShowError(ErrorMessage);
        }
        #endregion
        public static SqlConnection connection = new SqlConnection();
        #region Xâu kết nối và hàm thiết lập
        /// <summary>
        /// Xâu kết nối
        /// </summary>
        public static string ConnectionString
        {
            get { return connection.ConnectionString; }
            set
            {
                Error = false;
                try
                {
                    connection = new SqlConnection(value);
                    connection.Open();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Error = true;
                    ErrorMessage = ex.Message;
                }
            }
        }

        public static void SetConnection(string DataSource, string InitialCatalog, string UserId, string Password)
        {
            ConnectionString = "Data Source=" + DataSource + ";Initial Catalog=" + InitialCatalog + ";Uid=" + UserId + ";pwd=" + Password;
        }

        public static string GetConnection(string DataSource, string InitialCatalog, string UserId, string Password)
        {
            return "Data Source=" + DataSource + ";Initial Catalog=" + InitialCatalog + ";Uid=" + UserId + ";pwd=" + Password;
        }

        #endregion
        #region Các phương thức trả về một DataTable từ một câu lệnh truy vấn
        /// <summary>
        /// Phương thức lấy dữ liệu từ một xâu truy vấn
        /// </summary>
        /// <param name="Query">Câu lệnh Select</param>
        /// <returns>DataTable chứa dữ liệu truy vấn</returns>
    
        public static DataTable GetData(string Query)
        {
            DataTable tbl = new DataTable();
            Error = false;
            try
            {
                connection.Open();
                SqlDataAdapter adp = new SqlDataAdapter(Query, connection);
                adp.Fill(tbl);
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return tbl;
        }
        public static object GetObject(string Query)
        {
            object ret = null;
            Error = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                ret = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return ret;
        }
        /// <summary>
        /// Phương thức lấy toàn bộ dữ liệu của một bảng
        /// </summary>
        /// <param name="TableName">Tên bảng cần lấy dữ liệu</param>
        /// <returns></returns>
        public static DataTable SelectAll(string TableName)
        {
            return (GetData("select * from " + TableName));
        }
        /// <summary>
        /// Phương thức lấy toàn bộ dữ liệu của một bảng
        /// </summary>
        /// <param name="TableName">Tên bảng cần lấy dữ liệu</param>
        /// <param name="OrderByColumn">Tên cột cần sắp xếp</param>
        /// <returns></returns>
        public static DataTable SelectAll(string TableName, string OrderByColumn)
        {
            return (GetData("select * from " + TableName + " order by " + OrderByColumn));
        }
        /// <summary>
        /// Phương thức lấy dữ liệu của một bảng với điều kiện cho trước
        /// </summary>
        /// <param name="TableName">Tên bảng cần lấy dữ liệu</param>
        /// <param name="Condition">Điều kiện lọc</param>
        /// <returns></returns>
        public DataTable SelectWhere(string TableName, string Condition)
        {
            return (GetData("select * from " + TableName + " where " + Condition));
        }
        #endregion
        #region Các phương thức sửa đổi dữ liệu
        /// <summary>
        /// Phương thức cho phép thực thi một câu lệnh sửa đổi dữ liệu
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQuery(string Query)
        {            
            Error = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public static object ExecuteQueryAndReturnIdentityValue(string Query)
        {
            Error = false;
            object ob = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query + "; SELECT SCOPE_IDENTITY();");
                command.Connection = connection;
                ob = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            return ob;
        }

        /// <summary>
        /// Phương thức thực thi một câu lệnh truy vấn sử dụng TRANSACTION
        /// </summary>
        /// <param name="Query">Câu lệnh Insert, Update hoặc Delete</param>
        public static void ExecuteQueryUsingTran(string Query)
        {
            ExecuteQuery("BEGIN Transaction; set XACT_ABORT ON; " + Query + "; COMMIT;");
        }
        public static void InsertToTable(string TableName, string[] Columns, object[] Values)
        {
            if (Columns.Length != Values.Length)
            {
                ShowError("Số phần tử trong hai mảng Columns và Values phải bằng nhau");
                return;
            }
            string Query = "INSERT INTO " + TableName + "(";
            foreach (string st in Columns)
            {
                Query += st + ",";
            }
            Query = Query.Substring(0, Query.Length - 1) + ") VALUES(";
            foreach (object st in Values)
            {
                if (st==null)
                    Query += "null, ";
                else
                    if (st.ToString().IndexOf("'::money") > 0)
                        Query += st.ToString() + ", ";
                    else
                    {
                        if (st.GetType() == typeof(double) || st.GetType() == typeof(int) || st.GetType() == typeof(float))
                            Query +=  st.ToString() + ",";
                        else
                            Query += "N'" + st.ToString() + "',";
                    }
            }
            Query = Query.Substring(0, Query.Length - 1) + ")";
            ExecuteQueryUsingTran(Query);
        }

        public static string InsertToTableString(string TableName, string[] Columns, object[] Values)
        {
            if (Columns.Length != Values.Length)
            {
                ShowError("Số phần tử trong hai mảng Columns và Values phải bằng nhau");
                return "LOI";
            }
            string Query = "INSERT INTO " + TableName + "(";
            foreach (string st in Columns)
            {
                Query += st + ",";
            }
            Query = Query.Substring(0, Query.Length - 1) + ") VALUES(";
            foreach (object st in Values)
            {
                if (st == null)
                    Query += "null, ";
                else
                    if (st.ToString().IndexOf("'::money") > 0)
                        Query += st.ToString() + ", ";
                    else
                    {
                        if (st.GetType() == typeof(double) || st.GetType() == typeof(int) || st.GetType() == typeof(float))
                            Query += st.ToString() + ",";
                        else
                            Query += "N'" + st.ToString() + "',";
                    }
            }
            Query = Query.Substring(0, Query.Length - 1) + ")";
            return Query;
        }

        public static string InsertToTableString(string TableName, object[] Values)
        {
            string Query = "INSERT INTO " + TableName + " VALUES(";
            foreach (object st in Values)
            {
                if (st == null)
                    Query += "null, ";
                else
                    if (st.ToString().IndexOf("'::money") > 0)
                        Query += st.ToString() + ", ";
                    else
                        Query += "N'" + st.ToString() + "',";

            }
            Query = Query.Substring(0, Query.Length - 1) + ")";
            return Query;
        }

        public static void InsertToTable(string TableName, object[] Values)
        {
            string Query = "INSERT INTO " + TableName + " VALUES(";
            foreach (object st in Values)
            {
                if (st==null)
                    Query += "null, ";
                else
                    if (st.ToString().IndexOf("'::money") > 0)
                    Query +=  st.ToString() + ", ";
                else
                    Query += "N'" + st.ToString() + "',";

            }
                    Query = Query.Substring(0, Query.Length - 1) + ")";
            ExecuteQueryUsingTran(Query);
        }

        public static string UpdateToTableString(string TableName, string[] Columns, object[] Values, string Condition)
        {
            if (Columns.Length != Values.Length)
            {
                ShowError("Số phần tử trong hai mảng Columns và Values phải bằng nhau");
                return "";
            }
            string Query = "UPDATE " + TableName + " SET ";
            for (int i = 0; i < Columns.Length; i++)
            {
                if (Values[i] == null)
                    Query += "null, ";
                else
                    if (Values[i].ToString().IndexOf("'::money") > 0)
                        Query += Columns[i] + "= " + Values[i].ToString() + ", ";
                    else
                        Query += Columns[i] + "=N'" + Values[i].ToString() + "',";
            }
            if (Condition == "")
                Query = Query.Substring(0, Query.Length - 1);
            else
                Query = Query.Substring(0, Query.Length - 1) + " WHERE " + Condition;
            return Query;
        }

        public static void UpdateToTable(string TableName, string[] Columns, object[] Values, string Condition)
        {
            if (Columns.Length != Values.Length)
            {
                ShowError("Số phần tử trong hai mảng Columns và Values phải bằng nhau");
                return;
            }
            string Query = "UPDATE " + TableName + " SET ";
            for (int i = 0; i < Columns.Length; i++)
            {
                if (Values[i] == null)
                    Query += "null, ";
                else
                    if (Values[i].ToString().IndexOf("'::money")>0)
                        Query += Columns[i] + "= " + Values[i].ToString() + ", ";
                    else
                        Query += Columns[i] + "=N'" + Values[i].ToString() + "',";
            }
            if (Condition=="")
                Query = Query.Substring(0, Query.Length - 1) ;
            else
                Query = Query.Substring(0, Query.Length - 1) + " WHERE " + Condition;
            ExecuteQueryUsingTran(Query);
        }


        public static string UpdateToTableString(string TableName, object[] Values, string Condition)
        {

            string Query = "UPDATE " + TableName + " SET VALUES(";
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == null)
                    Query += "null, ";
                else
                    Query += "N'" + Values[i].ToString() + "',";
            }
            if (Condition == "")
                Query = Query.Substring(0, Query.Length - 1);
            else
                Query = Query.Substring(0, Query.Length - 1) + ")" + " WHERE " + Condition;

            return Query;
        }

        public static void UpdateToTable(string TableName, object[] Values, string Condition)
        {
            
            string Query = "UPDATE " + TableName + " SET VALUES(";
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == null)
                    Query += "null, ";
                else    
                    Query += "N'" + Values[i].ToString() + "',";
            }
            if (Condition == "")
                Query = Query.Substring(0, Query.Length - 1);
            else
                Query = Query.Substring(0, Query.Length - 1) + ")" + " WHERE " + Condition;
            ExecuteQueryUsingTran(Query );
        }

        public static void UpdateToTable(string TableName, DataTable tbl)
        {
            try
            {
                Error = false;
                SqlDataAdapter adp = new SqlDataAdapter("select * from " + TableName, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adp);
                adp.InsertCommand = builder.GetInsertCommand();
                adp.Update(tbl);
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
        }
        public static void DeleteFromTable(string TableName, string Condition)
        {
            ExecuteQueryUsingTran("DELETE FROM " + TableName + " WHERE " + Condition);
        }
        public static void UpdateImage(string Table, string ImageColumn, byte[] Value, string Condition)
        {
            Error = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                if (Condition=="")
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = :par1";
                else
                    command.CommandText = "update " + Table + " set " + ImageColumn + " = :par1" + " where " + Condition;
                command.Parameters.AddWithValue("par1", Value);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }        
        public static void ExecuteFunction(string functionName, string IDColumnName, string IDColumnValue, string ByteaColumnName,byte[] ByteaColumnValue)
        {
            Error = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(IDColumnName, IDColumnValue);
                command.Parameters.AddWithValue(ByteaColumnName, ByteaColumnValue);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
        public static void ExecuteFunction(string functionName, string[] parName, object[] parValue)
        {
            Error = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parName.Length; i++)
                    command.Parameters.AddWithValue(parName[i], parValue[i]);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Error = true;
                ErrorMessage = ex.Message;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
        #endregion        
        public static bool CheckExist(string Query)
        {
            DataTable tbl = new DataTable();
            tbl = GetData(Query);
            return (tbl.Rows.Count > 0);
        }

        public enum DataGridViewColumnType { TextBox, ComboBox, Link };
        public static void CreateDataGridView(DataGridView dgv, string[] ColumnName, DataGridViewColumnType[] ColumnType, string[] HeaderText, string[] DataProperties)
        {
            for (int i = 0; i < ColumnName.Length; i++)
            {
                switch (ColumnType[i])
                {
                    case DataGridViewColumnType.TextBox:
                        DataGridViewTextBoxColumn tbc = new DataGridViewTextBoxColumn();
                        tbc.Name = ColumnName[i];
                        tbc.HeaderText = HeaderText[i];
                        tbc.DataPropertyName = DataProperties[i];
                        dgv.Columns.Add(tbc);
                        break;
                    case DataGridViewColumnType.ComboBox:
                        DataGridViewComboBoxColumn cbc = new DataGridViewComboBoxColumn();
                        cbc.Name = ColumnName[i];
                        cbc.HeaderText = HeaderText[i];
                        cbc.DataPropertyName = DataProperties[i];
                        dgv.Columns.Add(cbc);
                        break;
                    case DataGridViewColumnType.Link:
                        DataGridViewLinkColumn lc = new DataGridViewLinkColumn();
                        lc.Name = ColumnName[i];
                        lc.HeaderText = HeaderText[i];
                        lc.DataPropertyName = DataProperties[i];
                        dgv.Columns.Add(lc);
                        break;
                }
            }
        }
        public static void CreateDataGridView(DataGridView dgv, string DataProperties,string HeaderTexts)
        {
            string[] headerTexts = HeaderTexts.Trim().Split(',');
            string[] DataPropertieNames = DataProperties.Trim().Split(',');
            if (headerTexts.Length != DataPropertieNames.Length)
            {
                ShowError("HeaderTexts và DataProperties phải cùng số phần tử");
                return;
            }
            string[] ColumnNames = new string[DataPropertieNames.Length];
            DataPropertieNames.CopyTo(ColumnNames, 0);
            DataGridViewColumnType[] dgct = new DataGridViewColumnType[ColumnNames.Length];
            for (int i = 0; i < ColumnNames.Length; i++)
            {
                dgct[i] = DataGridViewColumnType.TextBox;
                ColumnNames[i] += "dgc";
            }
            CreateDataGridView(
                dgv,
                ColumnNames,
                dgct,
                headerTexts,
                DataPropertieNames);
        }        
        #region Các phương thức điền dữ liệu cho Control
        public static void FillDataToGrid(DataGridView dgv, string Query)
        {
            dgv.DataSource = GetData(Query);
        }
        public static void CreateComboBox(ComboBox @ComboBox, DataTable DataSource, string DisplayMember, string ValueMember)
        {
            try
            {
                ComboBox.DisplayMember = DisplayMember;
                ComboBox.ValueMember = ValueMember;
                ComboBox.DataSource = DataSource;
                
            }
            catch { }
        }
        public static void CreateComboBoxInt(DataGridViewComboBoxColumn Cb, string TableName, string FieldValue, string FieldText, string DieuKien)
        {
            string Sql;
            
            if (DieuKien=="") Sql = "Select " + FieldValue + "," + FieldText + " from " + TableName + "";
            else Sql = "Select " + FieldValue + "," + FieldText + " from " + TableName + "where " + DieuKien;
            DataTable Tbl = new DataTable();
            DataColumn col1 = new DataColumn("ID", typeof(string));
            DataColumn col2 = new DataColumn("Ten", typeof(string));
            Tbl.Columns.Add(col1);
            Tbl.Columns.Add(col2);
            DataRow row = null;
            
            foreach (DataRow dr in GetData(Sql).Rows)    
                {
                    row = Tbl.NewRow();
                    
                    row["ID"] = dr[0].ToString() ;
                    row["Ten"] = dr[1].ToString();
                    Tbl.Rows.Add(row);
                }
            
            Cb.DataSource = Tbl;
            Cb.DisplayMember = "Ten";
            Cb.ValueMember = "ID";
        }

        public static void CreateComboBox(ComboBox @ComboBox, string Query, string DisplayMember, string ValueMember)
        {
            CreateComboBox(ComboBox, GetData(Query), DisplayMember, ValueMember);
        }

        public static void CreateListBox(ListBox @ComboBox, DataTable DataSource, string DisplayMember, string ValueMember)
        {
            try
            {
                ComboBox.DataSource = DataSource;
                ComboBox.DisplayMember = DisplayMember;
                ComboBox.ValueMember = ValueMember;
            }
            catch { }
        }

        public static void CreateListBox(ListBox @ComboBox, string Query, string DisplayMember, string ValueMember)
        {
            CreateListBox(ComboBox, GetData(Query), DisplayMember, ValueMember);
        }

        public static void CreateDataGridViewComboBoxColumn(DataGridViewComboBoxColumn ComboBoxColumn, DataTable DataSource, string DisplayMember, string ValueMember)
        {
            try
            {
                ComboBoxColumn.DisplayMember = DisplayMember;
                ComboBoxColumn.ValueMember = ValueMember;
                ComboBoxColumn.DataSource = DataSource;
                ComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            }
            catch { }
        }
        public static void CreateDataGridViewComboBoxColumn(DataGridViewComboBoxColumn ComboBoxColumn, string Query, string DisplayMember, string ValueMember)
        {
            CreateDataGridViewComboBoxColumn(ComboBoxColumn, GetData(Query), DisplayMember, ValueMember);
        }
        #endregion
        #region Các hàm tiện ích
        /// <summary>
        /// Hàm định dạng lại tiền tệ theo kiểu Việt Nam: 1.500,55
        /// </summary>
        /// <param name="Str">Tiền tệ theo kiểu Anh: 1,500.55</param>
        /// <returns>Tiền tệ theo kiểu Việt Nam: 1.500,55</returns>
        public static string MoneyFormat(string Str)
        {
            string ret = "";
            for (int i = 0; i < Str.Length; i++)
                ret+= Str[i] == '.' ? ',' : (Str[i] == ',' ? '.' : Str[i]);
            return ret;
        }
        #endregion
    }
}
