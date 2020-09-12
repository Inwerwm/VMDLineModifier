using System.Windows.Forms;

namespace VMDLineModifier
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全モーフを選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全ボーンを選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.包含数が1を選択1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前に付加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.先頭に追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.末尾に追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上書き保存時バックアップをとるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxArticles = new System.Windows.Forms.ListBox();
            this.contextMenuStripEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.すべて選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全モーフを選択ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全ボーンを選択ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.包含数が1の項目を選択1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.削除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.名前に付加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.先頭に追加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.末尾に追加ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIncludeFrameNum = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.設定SToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(988, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem,
            this.toolStripSeparator,
            this.上書き保存SToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開くOToolStripMenuItem.Image")));
            this.開くOToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.開くOToolStripMenuItem.Text = "開く(&O)";
            this.開くOToolStripMenuItem.Click += new System.EventHandler(this.開くOToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(245, 6);
            // 
            // 上書き保存SToolStripMenuItem
            // 
            this.上書き保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上書き保存SToolStripMenuItem.Image")));
            this.上書き保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.上書き保存SToolStripMenuItem.Name = "上書き保存SToolStripMenuItem";
            this.上書き保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.上書き保存SToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.上書き保存SToolStripMenuItem.Text = "上書き保存(&S)";
            this.上書き保存SToolStripMenuItem.Click += new System.EventHandler(this.上書き保存SToolStripMenuItem_Click);
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)";
            this.名前を付けて保存AToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripSeparator3,
            this.すべて選択AToolStripMenuItem,
            this.全モーフを選択ToolStripMenuItem,
            this.全ボーンを選択ToolStripMenuItem,
            this.包含数が1を選択1ToolStripMenuItem,
            this.toolStripSeparator2,
            this.削除ToolStripMenuItem,
            this.名前に付加ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)";
            this.元に戻すUToolStripMenuItem.Click += new System.EventHandler(this.元に戻すUToolStripMenuItem_Click);
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(&R)";
            this.やり直しRToolStripMenuItem.Click += new System.EventHandler(this.やり直しRToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
            // 
            // すべて選択AToolStripMenuItem
            // 
            this.すべて選択AToolStripMenuItem.Name = "すべて選択AToolStripMenuItem";
            this.すべて選択AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.すべて選択AToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.すべて選択AToolStripMenuItem.Text = "すべて選択(&A)";
            this.すべて選択AToolStripMenuItem.Click += new System.EventHandler(this.すべて選択AToolStripMenuItem_Click);
            // 
            // 全モーフを選択ToolStripMenuItem
            // 
            this.全モーフを選択ToolStripMenuItem.Name = "全モーフを選択ToolStripMenuItem";
            this.全モーフを選択ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.全モーフを選択ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.全モーフを選択ToolStripMenuItem.Text = "全モーフを選択(&M)";
            this.全モーフを選択ToolStripMenuItem.Click += new System.EventHandler(this.全モーフを選択ToolStripMenuItem_Click);
            // 
            // 全ボーンを選択ToolStripMenuItem
            // 
            this.全ボーンを選択ToolStripMenuItem.Name = "全ボーンを選択ToolStripMenuItem";
            this.全ボーンを選択ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.全ボーンを選択ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.全ボーンを選択ToolStripMenuItem.Text = "全ボーンを選択(&B)";
            this.全ボーンを選択ToolStripMenuItem.Click += new System.EventHandler(this.全ボーンを選択ToolStripMenuItem_Click);
            // 
            // 包含数が1を選択1ToolStripMenuItem
            // 
            this.包含数が1を選択1ToolStripMenuItem.Name = "包含数が1を選択1ToolStripMenuItem";
            this.包含数が1を選択1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.包含数が1を選択1ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.包含数が1を選択1ToolStripMenuItem.Text = "包含数が1の項目を選択(&1)";
            this.包含数が1を選択1ToolStripMenuItem.Click += new System.EventHandler(this.包含数が1の項目を選択1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // 削除ToolStripMenuItem
            // 
            this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
            this.削除ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.削除ToolStripMenuItem.Text = "削除(&D)";
            this.削除ToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // 名前に付加ToolStripMenuItem
            // 
            this.名前に付加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.先頭に追加ToolStripMenuItem,
            this.末尾に追加ToolStripMenuItem});
            this.名前に付加ToolStripMenuItem.Name = "名前に付加ToolStripMenuItem";
            this.名前に付加ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.名前に付加ToolStripMenuItem.Text = "名前に付加(&N)";
            // 
            // 先頭に追加ToolStripMenuItem
            // 
            this.先頭に追加ToolStripMenuItem.Name = "先頭に追加ToolStripMenuItem";
            this.先頭に追加ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.先頭に追加ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.先頭に追加ToolStripMenuItem.Text = "先頭に追加(&P)";
            this.先頭に追加ToolStripMenuItem.Click += new System.EventHandler(this.先頭に追加ToolStripMenuItem_Click);
            // 
            // 末尾に追加ToolStripMenuItem
            // 
            this.末尾に追加ToolStripMenuItem.Name = "末尾に追加ToolStripMenuItem";
            this.末尾に追加ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.末尾に追加ToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.末尾に追加ToolStripMenuItem.Text = "末尾に追加(&A)";
            this.末尾に追加ToolStripMenuItem.Click += new System.EventHandler(this.末尾に追加ToolStripMenuItem_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上書き保存時バックアップをとるToolStripMenuItem});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // 上書き保存時バックアップをとるToolStripMenuItem
            // 
            this.上書き保存時バックアップをとるToolStripMenuItem.Checked = true;
            this.上書き保存時バックアップをとるToolStripMenuItem.CheckOnClick = true;
            this.上書き保存時バックアップをとるToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.上書き保存時バックアップをとるToolStripMenuItem.Name = "上書き保存時バックアップをとるToolStripMenuItem";
            this.上書き保存時バックアップをとるToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.上書き保存時バックアップをとるToolStripMenuItem.Text = "上書き保存時バックアップをとる (&B)";
            // 
            // listBoxArticles
            // 
            this.listBoxArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxArticles.ContextMenuStrip = this.contextMenuStripEdit;
            this.listBoxArticles.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBoxArticles.FormattingEnabled = true;
            this.listBoxArticles.ItemHeight = 21;
            this.listBoxArticles.Location = new System.Drawing.Point(0, 0);
            this.listBoxArticles.Name = "listBoxArticles";
            this.listBoxArticles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxArticles.Size = new System.Drawing.Size(317, 504);
            this.listBoxArticles.TabIndex = 1;
            this.listBoxArticles.SelectedIndexChanged += new System.EventHandler(this.listBoxArticles_SelectedIndexChanged);
            // 
            // contextMenuStripEdit
            // 
            this.contextMenuStripEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.すべて選択ToolStripMenuItem,
            this.全モーフを選択ToolStripMenuItem1,
            this.全ボーンを選択ToolStripMenuItem1,
            this.包含数が1の項目を選択1ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.削除ToolStripMenuItem1,
            this.名前に付加ToolStripMenuItem1});
            this.contextMenuStripEdit.Name = "contextMenuStripEdit";
            this.contextMenuStripEdit.Size = new System.Drawing.Size(247, 142);
            // 
            // すべて選択ToolStripMenuItem
            // 
            this.すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem";
            this.すべて選択ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.すべて選択ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.すべて選択ToolStripMenuItem.Text = "すべて選択(&A)";
            this.すべて選択ToolStripMenuItem.Click += new System.EventHandler(this.すべて選択AToolStripMenuItem_Click);
            // 
            // 全モーフを選択ToolStripMenuItem1
            // 
            this.全モーフを選択ToolStripMenuItem1.Name = "全モーフを選択ToolStripMenuItem1";
            this.全モーフを選択ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.全モーフを選択ToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.全モーフを選択ToolStripMenuItem1.Text = "全モーフを選択(&M)";
            this.全モーフを選択ToolStripMenuItem1.Click += new System.EventHandler(this.全モーフを選択ToolStripMenuItem_Click);
            // 
            // 全ボーンを選択ToolStripMenuItem1
            // 
            this.全ボーンを選択ToolStripMenuItem1.Name = "全ボーンを選択ToolStripMenuItem1";
            this.全ボーンを選択ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.全ボーンを選択ToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.全ボーンを選択ToolStripMenuItem1.Text = "全ボーンを選択(&B)";
            this.全ボーンを選択ToolStripMenuItem1.Click += new System.EventHandler(this.全ボーンを選択ToolStripMenuItem_Click);
            // 
            // 包含数が1の項目を選択1ToolStripMenuItem
            // 
            this.包含数が1の項目を選択1ToolStripMenuItem.Name = "包含数が1の項目を選択1ToolStripMenuItem";
            this.包含数が1の項目を選択1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.包含数が1の項目を選択1ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.包含数が1の項目を選択1ToolStripMenuItem.Text = "包含数が1の項目を選択(&1)";
            this.包含数が1の項目を選択1ToolStripMenuItem.Click += new System.EventHandler(this.包含数が1の項目を選択1ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 6);
            // 
            // 削除ToolStripMenuItem1
            // 
            this.削除ToolStripMenuItem1.Name = "削除ToolStripMenuItem1";
            this.削除ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除ToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.削除ToolStripMenuItem1.Text = "削除(&D)";
            this.削除ToolStripMenuItem1.Click += new System.EventHandler(this.Remove_Click);
            // 
            // 名前に付加ToolStripMenuItem1
            // 
            this.名前に付加ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.先頭に追加ToolStripMenuItem1,
            this.末尾に追加ToolStripMenuItem1});
            this.名前に付加ToolStripMenuItem1.Name = "名前に付加ToolStripMenuItem1";
            this.名前に付加ToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.名前に付加ToolStripMenuItem1.Text = "名前に付加(&N)";
            // 
            // 先頭に追加ToolStripMenuItem1
            // 
            this.先頭に追加ToolStripMenuItem1.Name = "先頭に追加ToolStripMenuItem1";
            this.先頭に追加ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.先頭に追加ToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.先頭に追加ToolStripMenuItem1.Text = "先頭に追加(&P)";
            this.先頭に追加ToolStripMenuItem1.Click += new System.EventHandler(this.先頭に追加ToolStripMenuItem_Click);
            // 
            // 末尾に追加ToolStripMenuItem1
            // 
            this.末尾に追加ToolStripMenuItem1.Name = "末尾に追加ToolStripMenuItem1";
            this.末尾に追加ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.末尾に追加ToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.末尾に追加ToolStripMenuItem1.Text = "末尾に追加(&A)";
            this.末尾に追加ToolStripMenuItem1.Click += new System.EventHandler(this.末尾に追加ToolStripMenuItem_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(3, 2);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "名前";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelIncludeFrameNum);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 509);
            this.panel1.TabIndex = 3;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRemove.Location = new System.Drawing.Point(7, 464);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(617, 42);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "VMDから削除";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(7, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(617, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelIncludeFrameNum
            // 
            this.labelIncludeFrameNum.AutoSize = true;
            this.labelIncludeFrameNum.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelIncludeFrameNum.Location = new System.Drawing.Point(48, 2);
            this.labelIncludeFrameNum.Name = "labelIncludeFrameNum";
            this.labelIncludeFrameNum.Size = new System.Drawing.Size(108, 20);
            this.labelIncludeFrameNum.TabIndex = 2;
            this.labelIncludeFrameNum.Text = "包含フレーム数 : ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel1.Controls.Add(this.listBoxArticles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(964, 519);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "VMD Line Modifier";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripEdit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem すべて選択AToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxArticles;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelIncludeFrameNum;
        private System.Windows.Forms.ToolStripMenuItem 全モーフを選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全ボーンを選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前に付加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 先頭に追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 末尾に追加ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEdit;
        private ToolStripMenuItem すべて選択ToolStripMenuItem;
        private ToolStripMenuItem 全モーフを選択ToolStripMenuItem1;
        private ToolStripMenuItem 全ボーンを選択ToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 削除ToolStripMenuItem1;
        private ToolStripMenuItem 名前に付加ToolStripMenuItem1;
        private ToolStripMenuItem 先頭に追加ToolStripMenuItem1;
        private ToolStripMenuItem 末尾に追加ToolStripMenuItem1;
        private ToolStripMenuItem 設定SToolStripMenuItem;
        private ToolStripMenuItem 上書き保存時バックアップをとるToolStripMenuItem;
        private ToolStripMenuItem 包含数が1を選択1ToolStripMenuItem;
        private ToolStripMenuItem 包含数が1の項目を選択1ToolStripMenuItem;
        private SplitContainer splitContainer1;
    }
}

