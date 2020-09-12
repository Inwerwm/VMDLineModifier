using System.Collections.Generic;
using System.Linq;

namespace VMDLineModifier
{
    class CommandMacro : IModifyCommand
    {
        public List<IModifyCommand> Commands { get; }

        public CommandMacro() => Commands = new List<IModifyCommand>();

        public CommandMacro(IEnumerable<IModifyCommand> commands) => Commands = commands.ToList();

        public void Do()
        {
            foreach (var c in Commands) c.Do();
        }

        public void Undo()
        {
            foreach (var c in Commands) c.Undo();
        }
    }

    class RenameCommand : IModifyCommand
    {
        Article target;
        string newName;
        string preName;

        public RenameCommand(Article target, string newName)
        {
            this.target = target;
            this.newName = newName;
            preName = target.Name;
        }

        public void Do()
        {
            target.Name = newName;
        }

        public void Undo()
        {
            target.Name = preName;
        }
    }

    class PrependNameCommand : IModifyCommand
    {
        Article target;
        string prependString;
        string preName;

        public PrependNameCommand(Article target, string prependString)
        {
            this.target = target;
            this.prependString = prependString;
            preName = target.Name;
        }

        public void Do()
        {
            target.Name = prependString + preName;
        }

        public void Undo()
        {
            target.Name = preName;
        }
    }

    class AppendNameCommand : IModifyCommand
    {
        Article target;
        string appendString;
        string preName;

        public AppendNameCommand(Article target, string appendString)
        {
            this.target = target;
            this.appendString = appendString;
            preName = target.Name;
        }

        public void Do()
        {
            target.Name = preName + appendString;
        }

        public void Undo()
        {
            target.Name = preName;
        }
    }

    class RemoveCommand : IModifyCommand
    {
        VmdArticleModifier vmd;
        Article target;

        public RemoveCommand(VmdArticleModifier vmd, Article target)
        {
            this.vmd = vmd;
            this.target = target;
        }

        public void Do()
        {
            vmd.Articles.Remove(target.ToKey());
        }

        public void Undo()
        {
            vmd.Articles.Add(target.ToKey(), target);
        }
    }
}
