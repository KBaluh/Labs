using System;
using System.IO;
namespace FileData
{
    public class DataWriteEvent : EventArgs
    {
        public BinaryWriter Writer { get; set; }
    }
}
