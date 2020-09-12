using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMDLineModifier
{
    class ModifierDecorator
    {
        public (bool IsModified, string FilePath) Info => (IsModified, Modifier.FilePath);
        public bool IsModified { get; private set; }
        public bool IsLoaded { get; private set; } = false;
        private Stack<IModifyCommand> UndoCommands = new Stack<IModifyCommand>();
        private Stack<IModifyCommand> RedoCommands = new Stack<IModifyCommand>();

        VmdArticleModifier Modifier { get; set; } = new VmdArticleModifier();

        public void Read(string path)
        {
            Modifier = new VmdArticleModifier();
            Modifier.Read(path);

            IsModified = false;
            UndoCommands.Clear();
            RedoCommands.Clear();
            IsLoaded = true;
        }

        public void OverwriteSave()
        {
            if (!IsLoaded)
                return;

            Modifier.Write(Modifier.FilePath);

            IsModified = false;
        }

        public void SaveAs(string path)
        {
            if (!IsLoaded)
                return;

            Modifier.Write(path);

            IsModified = false;
        }

        public void SaveBackup()
        {
            var dir = Path.GetDirectoryName(Modifier.FilePath);
            var name = Path.GetFileName(Modifier.FilePath);
            File.Copy(Modifier.FilePath, $"{Path.Combine(dir, name)}_{DateTime.Now:yyyyMMdd-HHmmss}.vmd");
        }

        public IEnumerable<Article> GetArticleList()
        {
            var articles = Modifier.Articles.Select(p => p.Value);
            var morphs = articles.Where(a => a.Type == MikuMikuMethods.Vmd.FrameType.Morph);
            var motions = articles.Where(a => a.Type == MikuMikuMethods.Vmd.FrameType.Motion);
            motions = motions.OrderBy(a => a.Name, new MikuMikuMethods.Utilities.BoneNameComparer());

            return morphs.Concat(motions);
        }

        public void Rename(Article target, string newName) => Do(new RenameCommand(target, newName));
        public void Rename(IEnumerable<Article> targets, string newName) => Do(new CommandMacro(targets.Select(a => new RenameCommand(a, newName))));

        public void PrependName(IEnumerable<Article> targets, string prependString) => Do(new CommandMacro(targets.Select(a => new PrependNameCommand(a, prependString))));
        public void AppendName(IEnumerable<Article> targets, string appendString) => Do(new CommandMacro(targets.Select(a => new AppendNameCommand(a, appendString))));

        public void Remove(Article target) => Do(new RemoveCommand(Modifier, target));
        public void Remove(IEnumerable<Article> targets) => Do(new CommandMacro(targets.Select(a => new RemoveCommand(Modifier, a))));

        private void Do(IModifyCommand com)
        {
            if (!IsLoaded)
                return;

            com.Do();
            UndoCommands.Push(com);
            RedoCommands.Clear();
            IsModified = true;
        }

        /// <summary>
        /// 元に戻す
        /// </summary>
        /// <returns>更新の必要性</returns>
        public bool Undo()
        {
            if (!IsModified)
                return false;
            if (!UndoCommands.Any())
                return false;

            var com = UndoCommands.Pop();
            com.Undo();
            RedoCommands.Push(com);

            if (!UndoCommands.Any())
                IsModified = false;

            return true;
        }

        /// <summary>
        /// やり直し
        /// </summary>
        /// <returns>更新の必要性</returns>
        public bool Redo()
        {
            if (!RedoCommands.Any())
                return false;

            var com = RedoCommands.Pop();
            com.Do();
            UndoCommands.Push(com);
            IsModified = true;

            return true;
        }
    }
}
