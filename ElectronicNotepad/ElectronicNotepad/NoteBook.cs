using System;
using System.Collections.Generic;

namespace ElectronicNotepad
{
    /// <summary>
    /// class-essence notebook.
    /// </summary>
    public class NoteBook
    {
        public string Author { get; private set; }
        public List<Note> ENotes { get; set; }

        public NoteBook()
        {
            ENotes = new List<Note>();
        }
        /// <summary>
        /// Add new note to List<Note> ENotes and ask to add some text in it.
        /// </summary>
        public void AddNote()
        {
            Note ENote = new Note(IdGenerate(), DateTime.Now.ToString());
            ENote.AddTextFromConsole();
            this.ENotes.Add(ENote);
            Console.WriteLine("Note Added!");
        }

        public bool Equals(NoteBook objNoteBook)
        {
            bool result = false;
            if (Author.Equals(objNoteBook.Author) && ENotes.Capacity == objNoteBook.ENotes.Capacity)
            {
                for(int i=0; i < ENotes.Capacity; i++)
                {
                    if (ENotes[i].Equals(objNoteBook.ENotes[i]))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return this.ENotes.GetHashCode() + this.Author.GetHashCode();
        }

        public override string ToString()
        {
            return Author;
        }

        // Declare a delegate.
        public delegate int IdHandler();
        // Create a delegate variable.
        IdHandler del;

        /// <summary>
        /// register the delegate.
        /// </summary>
        /// <param name="_del"></param>
        public void RegisterHandler(IdHandler _del)
        {
            del = _del;
        }
        /// <summary>
        /// Generate Id for new Note.
        /// </summary>
        /// <returns></returns>
        public int IdGenerate()
        {
            if (del != null)
                return del();
            else
                return 0;
        }
    }
}
