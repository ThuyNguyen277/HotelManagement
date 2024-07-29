using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManegemantSystem.All_User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {
         
        Function fn = new Function();   //データベース操作を処理するFunctionクラスのインスタンスを作成します
        string query;   //SQLクエリを格納する文字列変数を宣言します
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 検索条件のコンボボックスの選択項目が変更された時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //「すべての顧客情報」を選択した場合の処理
            if ( TxtSearchBy.SelectedIndex == 0 )
            {
                //すべての顧客情報を取得するクエリを設定します
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid ";
                GetRecord(query);   //クエリを実行してDataGridViewにデータを表示します
            }
            //「ホテルに泊まっている顧客」を選択した場合の処理
            else if ( TxtSearchBy.SelectedIndex == 1 )
            {
                //チェックアウトしてない顧客情報を取得するクエリを設定します
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is null ";
                GetRecord(query);   //クエリを実行してDataGridViewにデータを表示します
            }
            //「すでに計算済みの顧客」を選択した場合の処理
            else if (TxtSearchBy.SelectedIndex == 2 )
            {
                //チェックアウトした顧客情報を取得するクエリを設定します
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where checkout is not null ";
                GetRecord(query);  //クエリを実行してDataGridViewにデータを表示します
            }
        }

        /// <summary>
        /// 指定しているクエリを実行してデータを取得し、DataGridViewに表示します
        /// </summary>
        /// <param name="query"></param>
        private void GetRecord(String query)
        {
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得します
            CustomerDetailsView.DataSource = ds.Tables[0];   //DataGridViewにデータベースを設定する
        }
    }
}
