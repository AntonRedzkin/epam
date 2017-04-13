using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNotepad.Commands
{
    class SaveCommand : ICommand
    {
        NoteBookProvider noteBookProvider;
        public SaveCommand(NoteBookProvider noteBookProviderSet)
        {
            noteBookProvider = noteBookProviderSet;
        }
        public void Execute()
        {
            noteBookProvider.Save();
        }
    }
}
