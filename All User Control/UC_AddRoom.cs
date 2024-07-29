using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManegemantSystem.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        Function fn = new Function();  //データベース操作を処理するFunctionクラスのインスタンスを作成します
        String query;   //Sqlクエリを格納する文字列変数を宣言します
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ルーム追加のコントロールが動かすイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "Select * from rooms";  //roomsテーブルから全てのレコードを選択するSQLクエリを設定します
            DataSet ds = fn.GetData(query);　    //クエリを実行し、その結果をDataSetに格納します
            DataGridView1.DataSource = ds.Tables[0];    //結果をDataGridViewコントロールにバインドしてデータを表示します
        }

        /// <summary>
        /// 追加ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            //必要なフィールドが全て入力されているかチェックします
            if (TxtRoomNo.Text != "" && TxtRoomType.Text != "" && TxtBed.Text != "" && TxtPrice.Text != "")
            {
                //テキストフィールドから入力されているかチェックします
                string roomno = TxtRoomNo.Text;
                string type = TxtRoomType.Text;
                string bed = TxtBed.Text;
                Int64 price = Int64.Parse(TxtPrice.Text);       //価格入力を64ビット整数に変換する

                //新しい部屋のレコードを挿入するSQLクエリを構築します
                query = "insert into rooms (roomNo, roomType, bed, price) values ('" + roomno + "', '" + type + "', '" + bed + "', " + price + ")";
                fn.SetData(query, "部屋を追加しました。");  //挿入クエリを実行し、成功を示すメッセージを表示します

                UC_AddRoom_Load(this, null);    //ルーム追加のページが再読み込みして表示データを更新する
                ClearAll();　// 全ての入力フィールドをクリアする
            }
            else
            {
                //必要なフィールドのいずれかが空の場合、警告メッセージを表示します
                MessageBox.Show("情報を入力してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// すべての入力フィールドをクリアします
        /// </summary>
        public void ClearAll()
        {
            TxtRoomNo.Clear();      //部屋番号のテキストフィールドをクリアします
            TxtRoomType.SelectedIndex = 1;      //部屋タイプのドロップダウンを最初の項目にリセットします
            TxtBed.SelectedItem = 1;　   //ベッドのドロップダウンを最初の項目にリセットします
            TxtPrice.Clear();   //価格テキストフィールドをクリアします
        }

        /// <summary>
        /// ルーム追加コントロールが離れたときのイベント処理です
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            ClearAll();     //すべての入力フィールドをクリアします
        }

        /// <summary>
        /// ルーム追加コントロールを再読み込みして表示データを更新します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
