using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlataformaSeguimientoEducativo.Models
{
    public class Communication
    {
        public int CommunicationId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public required string Message { get; set; }
        public DateTime DateSent { get; set; }

        public required User Sender { get; set; }
        public required User Receiver { get; set; }
    }
}
