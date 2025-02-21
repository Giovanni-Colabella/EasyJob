using System.ComponentModel.DataAnnotations;

namespace MyCourse_Custom.Models.Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; } // Identificativo univoco del lavoro nel database
        public string Titolo { get; set; } // Titolo del lavoro
        public string Autore { get; set; } // Nome dell'autore o azienda che offre il lavoro
        public string Descrizione { get; set; } // Descrizione del lavoro
        public string TipoLavoro { get; set; } // Full-time, Part-time, Remote
        public string Localita { get; set; } // Località del lavoro
        public DateTime DataPubblicazione { get; set; } // Quando è stata pubblicata l'offerta
        public string Requisiti { get; set; } // Requisiti per il lavoro
        public decimal Salario { get; set; } // Salario offerto
        public string Contatto { get; set; } // Contatto per inviare la candidatura
        public string Link { get; set; } // Link per ulteriori dettagli o candidatura


        // Proprietà di navigazione con JobDetail
        public JobDetail JobDetail {get; set;}
    }
}
