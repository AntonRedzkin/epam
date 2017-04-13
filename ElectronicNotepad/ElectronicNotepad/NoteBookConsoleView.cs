using System;

namespace ElectronicNotepad
{
    /// <summary>
    /// This class writes on console content of ENoteBook's Notes, wich added by ref in constructor.
    /// </summary>
    class NoteBookConsoleView
    {
        public NoteBook ENoteBook { get; private set; }

        public NoteBookConsoleView(ref NoteBook noteBook)
        {
            this.ENoteBook = noteBook;
        }

        /// <summary>
        /// prints content of note, or a few notes.
        /// </summary>
        /// <param name="numbers"></param>
        public void Print(params int[] numbers)
        {          
            foreach (int tmpValue in numbers)
            {                
                Console.WriteLine(ENoteBook.ENotes[tmpValue]);
            }            
        }
        /// <summary>
        /// prints content of all notes in ENoteBook, if param all is true.
        /// </summary>
        /// <param name="all"></param>
        public void Print(bool all = false)
        {
            if (all == true)
            {
                foreach (Note tmpNote in ENoteBook.ENotes)
                {
                    Console.WriteLine(tmpNote.ToString());
                }
            }
        }
    }
}
