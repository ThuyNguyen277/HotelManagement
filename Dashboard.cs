using System;
using System.Windows.Forms;

namespace HotelManegemantSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 終了ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     //アプリケーションを終了します
        }

        /// <summary>
        /// フォームが読み込まれた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //各ユーザーコントロールの初期化表示設定
            uC_AddRoom1.Visible = false;    //「ルーム追加」コントロールを非表示にします
            uC_CustomRes1.Visible = false;  //「カスタム登録」コントロールを非表示にします    
            uC_Checkout1.Visible = false;   //「計算」コントロールを非表示にします
            uC_CustomerDetails1.Visible = false;    //「カスタム詳細」コントロールを非表示にします
            uC_Employee1.Visible = false;   //「スタッフ」コントロールを非表示にします
            BtnAddRoom.PerformClick();  //「ルーム追加」ボタンをプログラムからクリックして、初期表示を「ルーム追加」画面にします
        }

        /// <summary>
        /// 「ルーム追加」ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnAddRoom.Left + 50;　 //「移動パネルの位置を「ルーム追加」ボタンの位置に設定します
            uC_AddRoom1.Visible = true;     //「ルーム追加」コントロールを表示にします
            uC_AddRoom1.BringToFront();     //「ルーム追加」コントロールを最前面に表示します
        }

        /// <summary>
        /// 「カスタム登録」ボタンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustomRes_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnCustomRes.Left + 50;    //「移動パネルの位置を「カスタム登録」ボタンの位置に設定します
            uC_CustomRes1.Visible = true;   //「カスタム登録」コントロールを表示にします
            uC_CustomRes1.BringToFront();   //「カスタム登録」コントロールを最前面に表示します
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnCheckOut.Left + 50;    //「移動パネルの位置を「計算」ボタンの位置に設定します
            uC_Checkout1.Visible = true;   //「計算」コントロールを表示にします
            uC_Checkout1.BringToFront();   //「計算」コントロールを最前面に表示します
        }

        private void BtnCustomDetail_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnCustomDetail.Left + 50;    //「移動パネルの位置を「カスタム詳細」ボタンの位置に設定します
            uC_CustomerDetails1.Visible = true;   //「カスタム詳細」コントロールを表示にします
            uC_CustomerDetails1.BringToFront();   //「カスタム詳細」コントロールを最前面に表示します
        }

        private void BtnEmploy_Click(object sender, EventArgs e)
        {
            PnlMoving.Left = BtnEmploy.Left + 50;    //「移動パネルの位置を「スタッフ」ボタンの位置に設定します
            uC_Employee1.Visible = true;   //「スタッフ」コントロールを表示にします
            uC_Employee1.BringToFront();   //「スタッフ」コントロールを最前面に表示します
        }

        /// <summary>
        /// ログアウトのアイコンがクリックされる時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //ログアウトアイコンクリックされたら確認メッセージボックスを表示する
            DialogResult result = MessageBox.Show("ログアウトしますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //OKボタンをクリックされる場合
            if (result == DialogResult.OK)
            {
                Form1 form1 = new Form1();  ////Form1(ログイン）フォームのインスタンスを作成します
                form1.Show();   //ログインフォームを表示する
                this.Close();   //現在のフォームを閉じる
            }
        }
    }
}
