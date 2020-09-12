using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VMDLineModifier
{
    public partial class FormMain : Form
    {
        ModifierDecorator mod = new ModifierDecorator();
        bool isTransitioning = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Reload()
        {
            var selectedItemTmp = listBoxArticles.SelectedItems.Cast<Article>().ToList();
            listBoxArticles.Items.Clear();
            listBoxArticles.Items.AddRange(mod.GetArticleList().ToArray());
            foreach (var item in selectedItemTmp)
            {
                listBoxArticles.SelectedItems.Add(item);
            }

            var info = mod.Info;
            Text = $"VMD Line Modifier{(info.IsModified ? "(*)" : "")} : {Path.GetFileName(info.FilePath)}";

            textBoxNameReset();
        }

        private void textBoxNameReset()
        {
            isTransitioning = true;

            if (listBoxArticles.SelectedItem is null)
                textBoxName.Text = "";
            else
            {
                var oneItem = listBoxArticles.SelectedItem as Article;
                var allNameIsSame = listBoxArticles.SelectedItems.Cast<Article>().All(a => a.Name == oneItem.Name);

                textBoxName.Text = allNameIsSame ? oneItem.Name : "";
                labelIncludeFrameNum.Text = listBoxArticles.SelectedItems.Count == 1 ? $"包含フレーム数 : {oneItem.Frames.Count}" : $"選択項目数 : {listBoxArticles.SelectedItems.Count}";
            }
            isTransitioning = false;
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "VMDファイル(*.vmd)|*.vmd|すべてのファイル(*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mod.Read(ofd.FileName);
                Reload();
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileNames.Length > 1)
            {
                MessageBox.Show("ファイルは1つだけ投入してください。", "ファイル読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mod.Read(fileNames[0]);
            Reload();
        }

        private void 元に戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mod.Undo())
                Reload();
        }

        private void やり直しRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mod.Redo())
                Reload();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (isTransitioning)
                return;

            mod.Rename(listBoxArticles.SelectedItems.Cast<Article>(), (sender as TextBox).Text);
            Reload();
        }

        private void listBoxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedItem is null)
                return;
            textBoxNameReset();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            mod.Remove(listBoxArticles.SelectedItems.Cast<Article>());
            Reload();
        }

        private void SelectByType(MikuMikuMethods.Vmd.FrameType selectType)
        {
            var items = listBoxArticles.Items.Cast<Article>().Where(a => a.Type == selectType).ToList();
            listBoxArticles.SelectedItems.Clear();
            foreach (var item in items)
                listBoxArticles.SelectedItems.Add(item);
        }

        private void 全モーフを選択ToolStripMenuItem_Click(object sender, EventArgs e) => SelectByType(MikuMikuMethods.Vmd.FrameType.Morph);

        private void 全ボーンを選択ToolStripMenuItem_Click(object sender, EventArgs e) => SelectByType(MikuMikuMethods.Vmd.FrameType.Motion);

        private void すべて選択AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxArticles.Items.Cast<Article>().ToList())
            {
                listBoxArticles.SelectedItems.Add(item);
            }
        }

        private void 包含数が1の項目を選択1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var items = listBoxArticles.Items.Cast<Article>().Where(a => a.Frames.Count == 1).ToList();
            listBoxArticles.SelectedItems.Clear();
            foreach (var item in items)
                listBoxArticles.SelectedItems.Add(item);
        }

        private void 先頭に追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prependStr = Microsoft.VisualBasic.Interaction.InputBox("先頭に付加する文字列を入力してください。", "先頭に追加");
            if (!string.IsNullOrEmpty(prependStr))
                mod.PrependName(listBoxArticles.SelectedItems.Cast<Article>(), prependStr);

            Reload();
        }

        private void 末尾に追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var appendStr = Microsoft.VisualBasic.Interaction.InputBox("末尾に付加する文字列を入力してください。", "末尾に追加");
            if (!string.IsNullOrEmpty(appendStr))
                mod.AppendName(listBoxArticles.SelectedItems.Cast<Article>(), appendStr);

            Reload();
        }

        private void 上書き保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mod.IsLoaded)
                return;

            if (上書き保存時バックアップをとるToolStripMenuItem.Checked)
                mod.SaveBackup();
            mod.OverwriteSave();
            Reload();
        }

        private void 名前を付けて保存AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mod.IsLoaded)
                return;

            var sfd = new SaveFileDialog();
            sfd.InitialDirectory = Path.GetDirectoryName(mod.Info.FilePath);
            sfd.Filter = "VMDファイル(*.vmd)|*.vmd|すべてのファイル(*.*)|*.*";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mod.SaveAs(sfd.FileName);
                Reload();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
