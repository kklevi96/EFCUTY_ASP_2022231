using EFCUTY_ASP_2022231.Models;
using System.ComponentModel.DataAnnotations;

namespace EFCUTY_ASP_2022231.ViewModels
{
    public class PostsViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public string SubjectCode { get; set; }
    }
}
