using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalR5.Models
{
    public class Mesaj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MesajId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Metin { get; set; }
        
        
    }
}
