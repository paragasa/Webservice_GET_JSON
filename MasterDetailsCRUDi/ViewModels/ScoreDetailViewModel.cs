using MasterDetailsCRUDi.Models;

namespace MasterDetailsCRUDi.ViewModels
{
    public class ScoreDetailViewModel : BaseViewModel
    {
        public Score Data { get; set; }
        public ScoreDetailViewModel(Score data = null)
        {
            Title = data?.Name;
            Data = data;
        }
    }
}
