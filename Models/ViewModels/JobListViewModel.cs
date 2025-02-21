namespace MyCourse_Custom.Models.ViewModels
{
    public class JobListViewModel
    {
        // Lista dei lavori da visualizzare nella pagina corrente
        public List<JobViewModel> Jobs { get; set; }

        // Numero della pagina attuale
        public int CurrentPage { get; set; }

        // Numero totale di pagine
        public int TotalPages { get; set; }

        // Query di ricerca (opzionale)
        public string Search { get; set; }
    }
}
