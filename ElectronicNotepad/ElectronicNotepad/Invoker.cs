using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicNotepad.Resources;
using ElectronicNotepad.Commands;
using ElectronicNotepad.CommandsCreators;


namespace ElectronicNotepad
{
    class Invoker
    {
        ICommand command;
        enum comands { Create, Save, Open, AddNote };
        public Invoker() { }

        public void TakeCommandFrom(NoteBookProvider nbp)
        {
            Console.WriteLine("Enter command...");
            comands s = (comands)Enum.Parse(typeof(comands), Console.ReadLine());
            Console.WriteLine("The  value {0:D}  of {0}", s);
            switch (s)
            {
                case comands.Create:
                    SetCommand(new CreateCommand(nbp));
                    break;
                case comands.Save:
                    SetCommand(new SaveCommand(nbp));
                    break;
                case comands.Open:
                    SetCommand(new OpenCommand(nbp));
                    break;
                case comands.AddNote:
                    SetCommand(new AddNoteCommand(nbp));
                    break;
            }
        }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PressExecute()
        {
            if (command != null)
                command.Execute();
        }
    }
}
