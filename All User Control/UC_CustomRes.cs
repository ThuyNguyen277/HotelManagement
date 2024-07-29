using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManegemantSystem.All_User_Control
{
    public partial class UC_CustomRes : UserControl
    {
        Function fn = new Function();       //データベースの操作を処理するFunctionクラスのインスタンスを作成します
        string query;   //SQLクエリを格納するための文字列変数を定義します
        public UC_CustomRes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ComboBoxにデータを指定します
        /// </summary>
        /// <param name="query"></param>
        /// <param name="combo"></param>
        public void SetComboBox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.GetForCombo(query);      //指定されたクエリを実行してデータリーダーを取得します
            while (sdr.Read())      //データリーダーからデータを読み込みます
            {
                for (int i = 0; i < sdr.FieldCount; i++)    //各フィールドのデータを取得します
                {
                    combo.Items.Add(sdr.GetString(i));  //コンボボックスにデータを追加します
                }
            }
            sdr.Close(); //データリーダーを閉じます
        }

        /// <summary>
        /// ベッドの選択が変更さらた時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtRoom.SelectedIndex = -1;　　//部屋の選択をリセットします
            TxtRoomNo.Items.Clear();    //部屋番号のコンボボックスをクリアします
            TxtPrice.Clear();   //価格のテキストボックスをクリアします
        }

        /// <summary>
        /// 部屋の選択が変更された時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtRoomNo.Items.Clear();    //部屋番号のコンボボックスをクリアします
            //指定された条件に一致する部屋番号を取得するクエリを設定します
            query = "select roomNo from rooms where bed = '" + TxtBed.Text + "' and roomType = '" + TxtRoom.Text + "' and booked = 'NO'";
            SetComboBox(query, TxtRoomNo);  //コンボボックスに部屋番号を設定します
        }

        int rid;    //部屋IDを格納するための変数
        /// <summary>
        /// 部屋番号の選択が変更された時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //選択された部屋番号に応じる価格た部屋IDを取得するクエリを設定します
            query = "select price, roomid from rooms where roomNo = '" + TxtRoomNo.Text + "'";
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得します
            TxtPrice.Text = ds.Tables[0].Rows[0][0].ToString();     //価格をテキストボックスに設定します
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());        //部屋IDを変数に設定します

        }

        /// <summary>
        /// 顧客を割り当てるボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAllotCustomer_Click(object sender, EventArgs e)
        {
            //必要な情報がすべての入力されているかを確認します
            if (TxtName.Text != "" && TxtContact.Text != "" && TxtNationality.Text !="" && TxtGender.Text != "" && TxtDob.Text != "" && TxtIDProof.Text != "" && TxtAddress.Text != "" && TxtCheckIn.Text != "" && TxtPrice.Text != "")
            {
                string name = TxtName.Text;     //顧客の名前を取得します
                Int64 mobile = Int64.Parse(TxtContact.Text);    //顧客の電話番号を数値に変更します
                string national = TxtNationality.Text;      //顧客の国籍を取得します
                string gender = TxtGender.Text;     //顧客の性別を取得します
                string dob = TxtDob.Text;       //顧客の生年月日を取得します
                string idproof = TxtIDProof.Text;   //顧客の個人番号を取得します
                string address = TxtAddress.Text;   //顧客の住所を取得します
                string checkin = TxtCheckIn.Text;   //申請日を取得します

                //顧客情報をデータベースに挿入し、部屋を予約済みにするためのクエリを設定します
                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid) values ('" + name + "', " + mobile + ", '" + national + "', '" + gender + "', '" + dob + "','" + idproof + "', '" + address + "', '" + checkin + "', " + rid + ") update rooms set booked = 'YES' where roomNo = '" + TxtRoomNo.Text + "'";
                fn.SetData(query, " 部屋番号 " + TxtRoomNo.Text + "カスタム登録に成功しました。");    //クエリを実行して顧客情報を登録し、部屋を予約済みにします
                ClearAll(); 　　//入力フィールドをクリアします

            }
            else
            {
                //必要な情報がすべて入力されていない場合、警告メッセージを表示します
                MessageBox.Show("情報を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /// <summary>
        /// 入力フィールドをクリアします
        /// </summary>
        public void ClearAll()
        {
            TxtName.Clear();    //名前フィールドをクリアします
            TxtContact.Clear();     //電話番号フィールドをクリアします
            TxtNationality.Clear();     //国籍フィールドをクリアします
            TxtGender.SelectedIndex = -1;   //性別コンボボックスの選択をクリアします
            TxtDob.ResetText();     //生年月日フィールドをリセットします
            TxtIDProof.Clear();     //個人番号フィールドをクリアします  
            TxtAddress.Clear();     //住所フィールドをクリアします
            TxtCheckIn.ResetText(); //申請日フィールドをリセットします
            TxtBed.SelectedIndex = -1;  //ヘッドコンボボックスの選択をクリアします  
            TxtRoom.SelectedIndex = -1; //部屋種類コンボボックスのアイテムをクリアします
            TxtRoomNo.Items.Clear();    //部屋番号コンボボックスのアイテムをクリアします
            TxtPrice.Clear();   //価格フィールドをクリアします

        }

        /// <summary>
        /// カスタム登録ページが離れた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_CustomRes_Leave(object sender, EventArgs e)
        {
            ClearAll();     //入力フィールドをクリアします
        }
    }
}
