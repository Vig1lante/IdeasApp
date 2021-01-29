using Caliburn.Micro;
using System;

namespace IdeasApp.ViewModels
{
    class UpdateEntryViewModel : Screen {
		public string UpdateEntryCategory { get; set; }
		public string UpdateEntryTaskName { get; set; }
		public string UpdateEntryPriority { get; set; }
		public int UpdateEntryEstTime { get; set; }

		public void UpdateButton_Click(object sender, EventArgs e) {
			TasksListViewModel.SelectedEntry.Category = UpdateEntryCategory;
			TasksListViewModel.SelectedEntry.TaskName = UpdateEntryTaskName;
			TasksListViewModel.SelectedEntry.Priority = UpdateEntryPriority;
			TasksListViewModel.SelectedEntry.EstimatedTime = UpdateEntryEstTime;
			TasksListViewModel.SelectedEntry.Deadline = DateTime.Now;
			Startup.IdeasDataTable.Update(TasksListViewModel.SelectedEntry);
			MainMenuViewModel.taskTableView.Ideas.Refresh();
			this.TryClose();
		}

	}
}
