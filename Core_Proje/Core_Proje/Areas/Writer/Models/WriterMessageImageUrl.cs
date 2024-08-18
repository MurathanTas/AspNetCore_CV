using System;

namespace Core_Proje.Areas.Writer.Models
{
    public class WriterMessageImageUrl
    {
        public int WriterMessageID { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string SenderImageUrl { get; set; }
    }
}
