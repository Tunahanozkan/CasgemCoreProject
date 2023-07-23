using MimeKit;

namespace Pizzapan.PresentationLayer.Models
{
    public class MailRequest
    {
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public MimeEntity TextBody { get; internal set; }
    }
}
