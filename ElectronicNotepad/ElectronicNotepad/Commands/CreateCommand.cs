using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNotepad.Commands
{
    class CreateCommand : ICommand
    {
        NoteBookProvider noteBookProvider;
        public CreateCommand(NoteBookProvider noteBookProviderSet)
        {
            noteBookProvider = noteBookProviderSet;
        }
        public void Execute()
        {
            noteBookProvider.Create();
        }
    }
}
