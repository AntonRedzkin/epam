using System;

namespace ElectronicNotepad
{
    /// <summary>
    /// class-essence note.
    /// </summary>
    public class Note
    {
        public string Content { get; private set; }
        public string Date { get; private set; }
        public int Id { get; private set; }

        public Note(int id, string date)
        {
            this.Date = date;
            this.Id = id;
        }
        /// <summary>
        /// Add Text From Console to note's Content.
        /// </summary>
        public void AddTextFromConsole()
        {
            Console.WriteLine("Enter Note..");
            AddText(Console.ReadLine());            
        }
        /// <summary>
        /// Add Text newContent to note's Content.
        /// </summary>
        public void AddText(string newContent)
        {
            this.Content = this.Content + newContent;
        }
        /// <summary>
        /// compare this Note's fields whith given gNote.
        /// </summary>
        /// <param name="gNote"></param>
        /// <returns></returns>
        public bool Equals(Note gNote)
        {
            bool result = false;
            if (Content.Equals(gNote.Content) && Date.Equals(gNote.Date) && Id.Equals(gNote.Id))
            { result = true; }
            else
            { result = false; }
            return result;
        }

        public override int GetHashCode()
        {
            return this.Content.GetHashCode() + this.Date.GetHashCode();
        }
        /// <summary>
        /// override of string ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Date:{0} \nText:{1} \nId:{2}", Date, Content, Id);
        }        
    }
}
