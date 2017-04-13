using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNotepad.CommandsCreators
{
    abstract class ICommandCreator
    {
        public ICommandCreator Successor { get; set; }
        public abstract ICommand GetCommand(string receiver);
    }
}
