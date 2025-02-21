using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyCourse_Custom.Models.InputModels;
using MyCourse_Custom.Models.Options;
using MyCourse_Custom.Models.Services.Application;
using MyCourse_Custom.Models.Services.Infrastructure;
using MyCourse_Custom.Models.ViewModels;

namespace MyCourse_Custom.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;
        private readonly IOptionsMonitor<JobsOptions> _jobsOptions;
        private readonly ApplicationDbContext _context;
        public JobsController(IJobService jobService, IOptionsMonitor<JobsOptions> jobsOptions, ApplicationDbContext context)
        {
            _jobService = jobService;
            _jobsOptions = jobsOptions;
            _context = context;
        }

        public async Task<IActionResult> Index(JobListInputModel input) 
        {

            List<JobViewModel> jobs = await _jobService.GetJobsAsync(input);

            // Calcola il numero totale di lavori e le pagine
            int totalJobs = await _context.Jobs
                .Where(job => job.Titolo.Contains(input.Search) || job.Descrizione.Contains(input.Search))
                .CountAsync();

            int pageSize = _jobsOptions.CurrentValue.PerPage;
            int totalPages = (int)Math.Ceiling(totalJobs / (double)pageSize);

            // Passa i lavori e le informazioni sulla paginazione alla vista
            var model = new JobListViewModel
            {
                Jobs = jobs,
                CurrentPage = input.Page,
                TotalPages = totalPages,
                Search = input.Search
            };

            return View(model);
        }
    }
}