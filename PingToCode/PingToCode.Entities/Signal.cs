using System;

namespace PingToCode.Entities
{
    public class Signal
    {
        public int IdUser { get; set; }
        public int IdMedia { get; set; }
        public string Content { get; set; }
        public DateTime DateSignal { get; set; }
    }
}