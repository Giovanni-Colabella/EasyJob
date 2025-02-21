using MyCourse_Custom.Models.InputModels;
using MyCourse_Custom.Models.ViewModels;

namespace MyCourse_Custom.Models.Services.Application
{
    public interface IJobService
    {
        Task<List<JobViewModel>> GetJobsAsync(JobListInputModel input);
    }
}