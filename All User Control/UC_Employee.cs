using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManegemantSystem.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        Function fn = new Function();   //データベース操作を処理するFunctionクラスのインスタンスを作成します
        string query;　//SQLクエリを格納する文字列変数を宣言します
        public UC_Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DashBoardのスタッフボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Employee_Load(object sender, EventArgs e)
        {
            GetMaxID();     //最大のIDを取得してラベルに設定するメソッドを呼び出します
        }

        /// <summary>
        /// 最大の従業員IDを取得して次に登録するIDを設定するメソッド
        /// </summary>
        public void GetMaxID()
        {
            query = "select max(eid) from employee";    //従業員テーブルから最大のIDを取得するクエリを設定します
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得します

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows [0][0].ToString()); //最大IDを変数に変換します
                LabelToSET.Text = (num + 1).ToString();     //次に登録するIDを設定します
            }
        }

        /// <summary>
        /// 登録ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResigtration_Click(object sender, EventArgs e)
        {
            //フォームのすべての入力フィールドが埋まっているか確認
            if (TxtName.Text != "" && TxTMobile.Text != "" && TxtEmail.Text != "" && TxtGender.Text != "" && TxtUserName.Text != "" && TxtPassword.Text != "" )
            {
                string name = TxtName.Text;     //名前を取得します
                Int64 mobile = Int64.Parse(TxTMobile.Text);     //電話番号を数値に変換します
                string email = TxtEmail.Text;   //メールアドレスを取得します
                string gender = TxtGender.Text;     //性別を取得します
                string username = TxtUserName.Text; //ユーザ名を取得します
                string pass = TxtPassword.Text; //パスワードを取得します

                //従業員情報をデータベースに挿入するためのクエリを設定します
                query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + name + "', " + mobile + ", '" + gender + "', '" + email + "', '" + username + "', '" + pass + "')";
                fn.SetData(query, "スタッフ登録に成功しました。");    //クエリを実行してデータベースに情報を登録します

                ClearAll(); //入力フィールドをクリアします
                GetMaxID(); //最大IDを再取して得次のIDを設定します
            }
        }

        /// <summary>
        /// 入力フィールドをクリアします
        /// </summary>
        public void ClearAll()
        {
            TxtName.Clear();    //名前フィールドをクリアします
            TxTMobile.Clear();  //電話番号フィールドをクリアします
            TxtGender.SelectedIndex = -1;　//性別コンボボックスの選択をクリアします
            TxtUserName.Clear();    //ユーザ名フィールドをクリアします
            TxtEmail.Clear();   //メールアドレスフィールドをクリアします
            TxtPassword.Clear();    //パスワードフィールドをクリアします
        }

        /// <summary>
        /// タブを選択された時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //タブの選択に応じて表示するDataGridViewを設定します
            if (TabEmployee.SelectedIndex == 1)
            {
                SetEmployee(guna2DataGridView1);    //最初のDataGridViewにデータを設定します
            }
            else if (TabEmployee.SelectedIndex == 2)
            {
                SetEmployee(guna2DataGridView2);    //二番目のDataGridViewにデータを設定します
            }
        }

        /// <summary>
        /// 指定されたDataGridViewに従業員情報を設定します
        /// </summary>
        /// <param name="dgv"></param>
        public void SetEmployee(DataGridView dgv)
        {
            query = "select * from employee";   //従業員テーブルのすべての情報を取得します
            DataSet ds = fn.GetData(query);     //クエリを実行してデータセットを取得します
            dgv.DataSource = ds.Tables[0];  //DataGridViewにデータをバインドします
        }

        /// <summary>
        /// 削除ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //従業員IDが入力されているか確認します
            if (TxtID.Text != "")
            {
                //削除確認メッセージを表示させます
                if (MessageBox.Show("Are you sure", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //従業員IDに基づいて従業員情報を削除するクエリを設定します
                    query = "delete from employee where eid = " + TxtID.Text + "";
                    fn.SetData(query, "スタッフ情報が削除されました。");   //クエリを実行してデータベースから情報を削除します
                    TabEmployee_SelectedIndexChanged(this, null);   //タブの選択状態を変更してデータベースを更新します
                }
            }
        }

        /// <summary>
        /// スタッフページが離れた時のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            ClearAll();     //入力フィールドをクリアします
        }
    }
}



