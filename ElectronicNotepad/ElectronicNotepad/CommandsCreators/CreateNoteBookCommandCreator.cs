using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElectronicNotepad.Commands;
using ElectronicNotepad.Resources;

namespace ElectronicNotepad.CommandsCreators
{
    class CreateNoteBookCommandCreator : ICommandCreator
    {
        ICommand command;

        public CreateNoteBookCommandCreator(ICommandCreator creator)
        {
            Successor = creator;
        }
        public override ICommand GetCommand(string strCommand)
        {
            if (strCommand.Contains(Resource.CreateNoteBook))
            {
                command = new CreateCommand(NoteBookProvider);
            }
            else if (Successor != null)
            {
                Successor.GetCommand(strCommand);
            }
            return command
        }
    }
}
