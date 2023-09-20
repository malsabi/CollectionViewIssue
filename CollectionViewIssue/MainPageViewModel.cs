using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CollectionViewIssue
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Assessment> assessments = AssessmentsMockup.GetAssessments();

        public MainPageViewModel()
        {
        }

        [RelayCommand]
        private void Download(Assessment assessment)
        {
        }

        private void Upload(Assessment assessment)
        {
        }
    }
}