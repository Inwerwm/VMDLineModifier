using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMDLineModifier
{
    interface IModifyCommand
    {
        public void Do();
        public void Undo();
    }
}
