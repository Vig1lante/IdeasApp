using Caliburn.Micro;
using IdeasApp.Models;
using System;

namespace IdeasApp.ViewModels
{
    public partial class AddEntryViewModel : Screen {
		public string NewEntryCategory { get; set; }
		public string NewEntryTaskName { get; set; }
		public string NewEntryPriority { get; set; }
		public int NewEntryEstTime { get; set; }
		public DateTime NewEntryDeadline { get; set; }

		public Entry NewEntry { get; set; }

		public void AddButton_Click(object sender, EventArgs e) {
			NewEntry = new Entry();
			this.NewEntry.Category = NewEntryCategory;
			this.NewEntry.TaskName = NewEntryTaskName;
			this.NewEntry.Priority = NewEntryPriority;
			this.NewEntry.EstimatedTime = NewEntryEstTime;
			this.NewEntry.Deadline = DateTime.Now;
			Startup.IdeasDataTable.Create(NewEntry);
			MainMenuViewModel.taskTableView.Ideas.Add(NewEntry);
			this.TryClose();
		}
	}
}
