using System;

namespace Dev_9
{
    class ExceptionHandler
    {
        public void Handle(Exception exception, bool key)
        {
            Console.WriteLine("{0}", exception.Message);
            key = true;
        }
    }
}
