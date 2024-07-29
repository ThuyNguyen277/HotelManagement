using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManegemantSystem
{
    class Function
    {
        /// <summary>
        /// データソースに接続
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=AGILET-2024-008\\SQLSERVER;Initial Catalog=DBMyHotel;Integrated Security=True;TrustServerCertificate=True"   //接続文字列を設定します  
            };
            
            return con;　    //接続を返します
        }

        /// <summary>
        /// データを取得します
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet GetData(String query)
        {
            SqlConnection con = GetConnection();    //データベース接続を取得します
            SqlCommand cmd = new SqlCommand
            {
                Connection = con,      // コマンドの接続を設定します
                CommandText = query    // コマンドテキストにSQLクエリを設定します
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);　　//SqlDataAdapterの新しいインスタンスを作成し、コマンドを設定します
            DataSet ds = new DataSet();   //DataSetの新しいインスタンスを作成します
            da.Fill(ds);    //DataSetにデータを読み込みます
            return ds;  //DataSetを返します
        }

        /// <summary>
        /// データを設定します
        /// </summary>
        /// <param name="query"></param>
        /// <param name="message"></param>
        public void SetData(String query, String message)
        {
            using (SqlConnection con = GetConnection()) // データベース接続を取得し、usingステートメントでリソースを解放
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con,   // コマンドの接続を設定
                    CommandText = query // コマンドテキストにSQLクエリを設定
                };
                con.Open();             // データベース接続を開く
                cmd.ExecuteNonQuery();  // コマンドを実行
                con.Close();        //データベース接続を閉じます
            }

            

            //処置成功のメッセージを表示します
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// コンボボックスのデータを取得します
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public SqlDataReader GetForCombo(string query)
        {
            SqlConnection con = GetConnection(); // データベース接続を取得します
            SqlCommand cmd = new SqlCommand(query, con); // SqlCommandの新しいインスタンスを作成し、クエリと接続を設定します
            con.Open(); // データベース接続を開きます
            return cmd.ExecuteReader(CommandBehavior.CloseConnection); // データリーダーを実行して結果を取得し、リーダーが閉じるときに接続も閉じるように設定します
        }
    }
}
