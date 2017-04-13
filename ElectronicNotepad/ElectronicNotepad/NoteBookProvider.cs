using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ElectronicNotepad
{
    /// <summary>
    /// pattern singletone. Provide any action with NoteBook currentNoteBook. 
    /// </summary>
    class NoteBookProvider
    {
        private static NoteBookProvider noteBookProvider;
        private  NoteBook currentNoteBook;
        ICommand command;
        NoteBookConsoleView noteBookConsoleView;

        private NoteBookProvider()
        { }

        public static NoteBookProvider GetInstance()
        {
            if (noteBookProvider == null)
                noteBookProvider = new NoteBookProvider();
            return noteBookProvider;
        }

        public void Create()
        {
            currentNoteBook = new NoteBook();
            Console.WriteLine("NoteBook Created!");
            noteBookConsoleView = new NoteBookConsoleView(ref currentNoteBook);
        }

        public void Save()
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(NoteBook));
                using (FileStream fs = new FileStream("Notebook.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, currentNoteBook);
                }
                Console.WriteLine("NoteBook Saved!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("NoteBook can't be saved!");
            }
        }
        public void Open()
        {
            currentNoteBook = new NoteBook();
            try
            {
                using (FileStream fs = new FileStream("Notebook.json", FileMode.OpenOrCreate))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(NoteBook));
                    currentNoteBook = (NoteBook)jsonFormatter.ReadObject(fs);
                }
                Console.WriteLine("NoteBook Opened!");
            }
            catch (SerializationException)
            {
                Console.WriteLine("NoteBook can't be saved!");
            }
        }

        //public void TakeCommandFrom()
        //{
        //    SetCommand(new AddNoteCommand(currentNoteBook));
        //}
        //public void SetCommand(ICommand com)
        //{
        //    command = com;
        //}
        public void AddNoteToNoteBook()
        {
            currentNoteBook.AddNote();
            //if (command != null)
            //{
            //    command.Execute();
            //    noteBookConsoleView.Print();
            //}
        }

    }
}
