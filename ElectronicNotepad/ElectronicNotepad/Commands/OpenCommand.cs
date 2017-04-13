using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNotepad.Commands
{
    class OpenCommand : ICommand
    {
        NoteBookProvider noteBookProvider;
        public OpenCommand(NoteBookProvider noteBookProviderSet)
        {
            noteBookProvider = noteBookProviderSet;
        }
        public void Execute()
        {
            noteBookProvider.Open();
        }
    }
}
