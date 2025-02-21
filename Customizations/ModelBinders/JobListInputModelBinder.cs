using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using MyCourse_Custom.Models.InputModels;
using MyCourse_Custom.Models.Options;
using System;
using System.Threading.Tasks;

namespace MyCourse_Custom.Customizations.ModelBinders
{
    public class JobListInputModelBinder : IModelBinder
    {
        private readonly IOptionsMonitor<JobsOptions> _jobsOptions;

        public JobListInputModelBinder(IOptionsMonitor<JobsOptions> jobsOptions)
        {
            _jobsOptions = jobsOptions;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // Ottieni il valore del parametro "Search", se non è presente sarà una stringa vuota
            string search = bindingContext.ValueProvider.GetValue("Search").FirstValue ?? "";

            // Ottieni il valore del parametro "Page", se non è presente o è invalido, usa il valore di default (1)
            string pageValue = bindingContext.ValueProvider.GetValue("Page").FirstValue;
            int page = string.IsNullOrEmpty(pageValue) ? 1 : Math.Max(1, Convert.ToInt32(pageValue));  // Imposta a 1 se mancante o negativo

            // Crea un'istanza del modello di input con i valori ottenuti
            var inputModel = new JobListInputModel(search, page);

            // Costruiamo il nostro modelInput
            bindingContext.Result = ModelBindingResult.Success(inputModel);

            return Task.CompletedTask; // task completato
        }
    }
}
