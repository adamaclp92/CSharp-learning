using System;
using System.Runtime.Serialization;

namespace GameOfDrones
{
    [Serializable]
    internal class TooShortStringException : Exception
    {
        private string text;

        public string Text
        {
            get { return text; }
        }

        public TooShortStringException(string text)
        {
            this.text = text;
        }

        // OVERRIDE MESSAGE
    }
}