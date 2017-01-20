using System;

namespace PingToCode.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int IdMedia { get; set; }
        public int IdUser { get; set; }
        public DateTime DateComment { get; set; }
    }
}