using System;

namespace Dev_8
{
    class MultiplyException : Exception
    {
        private int errorCode;
        public int ErrorCode { get { return errorCode; } }

        public MultiplyException(string aMessage, int aCode) : base(aMessage)
        {
            errorCode = aCode;
        }
    }
}
