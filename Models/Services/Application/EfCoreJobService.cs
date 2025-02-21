using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyCourse_Custom.Models.Entities;
using MyCourse_Custom.Models.InputModels;
using MyCourse_Custom.Models.Options;
using MyCourse_Custom.Models.Services.Infrastructure;
using MyCourse_Custom.Models.ViewModels;

namespace MyCourse_Custom.Models.Services.Application
{
    public class EfCoreJobService : IJobService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IOptionsMonitor<JobsOptions> _jobsOptions;

        public EfCoreJobService(ApplicationDbContext applicationDbContext,
                                IOptionsMonitor<JobsOptions> jobsOptions)
        {   
            this._applicationDbContext = applicationDbContext;
            this._jobsOptions = jobsOptions;
        }

        public async Task<List<JobViewModel>> GetJobsAsync(JobListInputModel input)
        {
            int pageSize = _jobsOptions.CurrentValue.PerPage;
            int skipCount = (input.Page - 1) * pageSize;

            // Aggiungi la condizione di ricerca, se presente
            IQueryable<Job> jobsQuery = _applicationDbContext.Jobs.AsQueryable();

            if (!string.IsNullOrEmpty(input.Search))
            {
                jobsQuery = jobsQuery.Where(job => job.Titolo.Contains(input.Search) || job.Descrizione.Contains(input.Search));
            }

            // Conta il numero totale di lavori con la ricerca
            int totalJobs = await jobsQuery.CountAsync();
            int totalPages = (int)Math.Ceiling(totalJobs / (double)pageSize);

            // Esegui la query per ottenere i lavori con la paginazione e la ricerca
            IQueryable<JobViewModel> query = jobsQuery
                .AsNoTracking()  // Ottimizzazione per non tracciare gli oggetti modificati
                .Select(job => JobViewModel.FromEntity(job))
                .Skip(skipCount)
                .Take(pageSize);

            // Esegui la query asincrona
            List<JobViewModel> jobs_finalQuery = await query.ToListAsync();

            return jobs_finalQuery;
        }


    }
}