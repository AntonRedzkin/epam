using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicNotepad.Commands
{
    class AddNoteCommand : ICommand
    {
        //NoteBook noteBook;
        NoteBookProvider noteBookProvider;
        public AddNoteCommand(NoteBookProvider noteBookProviderSet)
        {
            noteBookProvider = noteBookProviderSet;
        }
        //public AddNoteCommand(NoteBook noteBookSet)
        //{
        //    noteBook = noteBookSet;
        //}
        public void Execute()
        {
            noteBookProvider.AddNoteToNoteBook();
        }
    }
}
