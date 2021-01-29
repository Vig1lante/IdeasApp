using Caliburn.Micro;
using IdeasApp.Models;

namespace IdeasApp.ViewModels
{

    public class TasksListViewModel : Conductor<object>.Collection.OneActive {

        public static IWindowManager manager = new WindowManager();
        public static Entry SelectedEntry { get; set; }
        private AddEntryViewModel addingWindow;
        private UpdateEntryViewModel updateWindow;
        public BindableCollection<Entry> Ideas { get; set; }

        public TasksListViewModel() {
            var ideasList = Startup.IdeasDataTable.ReadAll();
            Ideas = new BindableCollection<Entry>(ideasList);
        }
        public void AddEntry() {
            this.addingWindow = new AddEntryViewModel();
            manager.ShowWindow(addingWindow, null, null);
            ActivateItem(addingWindow);
        }

        public void UpdateEntry() {
            this.updateWindow = new UpdateEntryViewModel();
            manager.ShowWindow(updateWindow, null, null);
            ActivateItem(updateWindow);
        }

        public void DeleteEntry() {
            Startup.IdeasDataTable.Delete(SelectedEntry);
            MainMenuViewModel.taskTableView.Ideas.Remove(SelectedEntry);
        }
    }
}
