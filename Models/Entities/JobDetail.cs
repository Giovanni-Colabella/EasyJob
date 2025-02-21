namespace MyCourse_Custom.Models.Entities
{
    public class JobDetail
    {
        public int Id { get; set; } // Identificativo univoco del dettaglio

        // Chiave esterna per il lavoro a cui appartiene il dettaglio
        public int JobId { get; set; }
        public Job Job { get; set; } // Relazione con la tabella Job

        public string Responsabilita { get; set; } // Descrizione delle responsabilità
        public string Competenze { get; set; } // Elenco delle competenze richieste
        public string Benefits { get; set; } // Benefici offerti dal lavoro (assicurazione, ferie, ecc.)
        public string OrarioLavoro { get; set; } // Dettagli sull'orario (full-time, part-time, flessibile, ecc.)
        public string Carriera { get; set; } // Opportunità di crescita e sviluppo nella posizione
    }
}
