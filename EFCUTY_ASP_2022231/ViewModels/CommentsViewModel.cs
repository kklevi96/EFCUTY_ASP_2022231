using EFCUTY_ASP_2022231.Models;

namespace EFCUTY_ASP_2022231.ViewModels
{
    public class CommentsViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
        public string PostId { get; set; }
    }
}
