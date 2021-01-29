using Caliburn.Micro;

namespace IdeasApp.ViewModels
{
    class AppShellViewModel : Conductor<object>.Collection.OneActive {
        public AppShellViewModel() {
            ShowMainMenu();
        }

        public void ShowMainMenu() {
            ActivateItem(new MainMenuViewModel());
        }

        public void ShowTasksList() {
            ActivateItem(new TasksListViewModel());
        }
    }
}
