using System;

namespace Dev_10
{
    class MyException : Exception
    {
        private int errorCode;
        public int ErrorCode { get { return errorCode; } }

        public MyException(string aMessage, int aCode) : base(aMessage)
        {
            errorCode = aCode;
        }
    }
}
