using System;

namespace ElectronicNotepad
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note targetNote = new Note();
            NoteBookProvider NP = NoteBookProvider.GetInstance();
            Invoker sInvoker = new Invoker();
            bool key = true;
            while(key)
            {
                sInvoker.TakeCommandFrom(NP);
                sInvoker.PressExecute();
                Console.WriteLine("continue?");
                if (Console.ReadLine().ToLower().Equals("y"))
                {
                    key = true;
                }
                else
                {
                    key = false;
                }
            }
            //NP.TakeCommandFrom();
            //NP.AddNoteToNoteBook();
            //bool all = false;
            // NoteBookConsoleView noteBookConsoleView = new NoteBookConsoleView(ref noteBook);
            //noteBook.RegisterHandler(new NoteBook.IdHandler(Generate));
            //noteBook.AddNote();
            //noteBookConsoleView.Print(0);
            //noteBook.AddNote();
            //noteBookConsoleView.Print(0, 1);
            //noteBook.AddNote();
            //noteBookConsoleView.Print(2);
            //noteBook.RegisterHandler(new NoteBook.IdHandler(NoGenerate));
            //all = true;
            //noteBook.AddNote();
            //noteBookConsoleView.Print(all);
        }
        private static int Generate()
        {
            Random random = new Random();
            return random.Next();
        }

        private static int NoGenerate()
        {
            return 55;
        }
    }
}
