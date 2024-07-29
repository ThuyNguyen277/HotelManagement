using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManegemantSystem
{
    public partial class Form1 : Form
    {

        Function fn = new Function();   //データベース操作を行うFunctionクラスのインスタンスを作成します
        string query;   //SQLクエリを格納するための文字列変数を宣言します
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「終了」ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     //アプリケーションを終了します
        }

        /// <summary>
        /// 「ログイン」ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //ユーザ名とパスワードに基づいてデータベースからユーザー情報を取得するクエリを作成します
            query = "select username, pass from employee where username = '" + TxtUserName.Text + "' and pass = '" + TxtPassword.Text + "'";
            DataSet ds = fn.GetData(query);　    //クリアを実行してデータセットを取得します

            //データセットに結果が含まれているかどうかを確認します
            if (ds.Tables[0].Rows.Count != 0)
            {
                LabelError.Visible = false;     //エラーメッセージラベルを非表示にします
                Dashboard dash = new Dashboard();       //DashBoardフォームのインスタンスを作成します
                this.Hide();    //現在のフォームを非表示にします
                dash.Show();    //DashBoardフォームを表示します
            }
            else
            {
                
                LabelError.Visible = true;  //エラーメッセージラベルを表示します
                TxtPassword.Clear();    //パスワード入力フィールドをクリアします
            }
        }
    }
}