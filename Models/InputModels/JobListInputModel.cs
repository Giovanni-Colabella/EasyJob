using Microsoft.AspNetCore.Mvc;
using MyCourse_Custom.Customizations.ModelBinders;

namespace MyCourse_Custom.Models.InputModels
{
    [ModelBinder(BinderType = typeof(JobListInputModelBinder))]
    public class JobListInputModel
    {
        public JobListInputModel(string search = "", int page = 1)
        {
            Search = search ?? "";
            Page = Math.Max(1, page);
        }

        public string Search {get;}
        public int Page {get;}
    }
}