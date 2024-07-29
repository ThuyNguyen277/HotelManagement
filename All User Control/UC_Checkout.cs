using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManegemantSystem.All_User_Control
{
    public partial class UC_Checkout : UserControl
    {
        Function fn = new Function();   //データベース操作を処理するFunctionクラスのインスタンスを作成します
        string query;   //SQLクリアを格納する文字列変数を宣言します
        public UC_Checkout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DashBoardの計算ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Checkout_Load(object sender, EventArgs e)
        {
            //ホテルに泊まっている顧客と対応する部屋の情報を取得します
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where chekout = 'NO' ";
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得する
            CustomerDetailsView.DataSource = ds.Tables[0];   //DataGridViewの中に取得されたデータを表示します

        }

        /// <summary>
        /// 名前を検索するイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            //入力された名前に部分一致するチェックアウトしていない顧客と対応する部屋の情報を取得します
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid where cname like '%" + TxtName.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得します
            CustomerDetailsView.DataSource = ds.Tables[0];　  //DataGridViewに取得されたデータを表示します
        }

        int id;     //顧客IDを格納する整数変数を宣言します

        /// <summary>
        /// DataGridViewのセルがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CustomerDetailsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // クリックされたセルの値がnullでないことを確認します。
            if (CustomerDetailsView.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                // クリックされた行の顧客ID、顧客名、部屋番号を取得して対応するテキストボックスに設定します。
                id = int.Parse(CustomerDetailsView.Rows[e.RowIndex].Cells[0].Value.ToString());
                TxtCName.Text = CustomerDetailsView.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtRoom.Text = CustomerDetailsView.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        /// <summary>
        /// 計算ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            //顧客の名前が空でないことを確認
            if (TxtCName.Text != "")
            {
                //チェックアウト確認の大アロづを表示し、Okがクリックされた場合に処理を実行します
                if (MessageBox.Show("チェックアウトしますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = TxtCheckoutDate.Text; //チェックアウト日を取得します
                    //顧客のチェックアウト情報を更新し、部屋の予約状況を更新します
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "' where cid = " + id + "update rooms set booked = 'NO' where roomNo = '" + TxtRoom.Text + "'";
                    fn.SetData(query, "計算済みです。");   //クエリを実行して成功メッセージを表示します
                    UC_Checkout_Load(this, null);　  //計算ページ内容を再読み込みします
                    ClearAll(); //すべての入力フィールドをクリアします
                }
                else
                {
                    //情報メッセージを表示します
                    MessageBox.Show("顧客がいません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// すべての入力フィールドをクリアします
        /// </summary>
        public void ClearAll()
        {
            TxtCName.Clear();     //顧客名フィールドをクリアします
            TxtName.Clear();    //名前フィールドをクリアします
            TxtRoom.Clear();    //部屋フィールドをクリアします
            TxtCheckoutDate.ResetText();    //チェックアウト日フィールドをリセットします
        }

        /// <summary>
        /// 計算ページが離れたときのイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Checkout_Leave(object sender, EventArgs e)
        {
            ClearAll();     //すべての入力フィールドをクリアします
        }


    }
}
