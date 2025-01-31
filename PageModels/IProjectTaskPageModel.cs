using CommunityToolkit.Mvvm.Input;
using Critter_Care.Models;

namespace Critter_Care.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}