using MyCourse_Custom.Models.Entities;

namespace MyCourse_Custom.Models.ViewModels
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public string Descrizione { get; set; } // Descrizione del lavoro
        public string TipoLavoro { get; set; } // Full-time, Part-time, Remote
        public string Localita { get; set; } // Dove si trova il lavoro
        public DateTime DataPubblicazione { get; set; } // Data di pubblicazione
        public string Requisiti { get; set; } // Requisiti del lavoro
        public decimal Salario { get; set; } // Salario previsto
        public string Contatto { get; set; } // Informazioni di contatto per candidarsi
        public string Link { get; set; } // Link per ulteriori dettagli o per candidarsi


        public static JobViewModel FromEntity(Job job)
        {
            return new JobViewModel {
                Id = job.Id,
                Titolo = job.Titolo,
                Autore = job.Autore,
                Descrizione = job.Descrizione,
                TipoLavoro = job.TipoLavoro,
                Localita = job.Localita,
                DataPubblicazione = job.DataPubblicazione,
                Requisiti =  job.Requisiti,
                Salario = job.Salario,
                Contatto = job.Contatto,
                Link = job.Link
            };
        }
    }
}
