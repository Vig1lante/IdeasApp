using Caliburn.Micro;

namespace IdeasApp.ViewModels
{
    public class MainMenuViewModel : Conductor<object>.Collection.OneActive {

        //TODO
        /*public MainMenuViewModel(EntryRepository databaseConnenction) {
                
        }*/
        public MainMenuViewModel() {

        }

        public static TasksListViewModel taskTableView;

        public void LoadTasksList() {
            taskTableView = new TasksListViewModel();
            ActivateItem(taskTableView);
        }
    }
}
