using Caliburn.Micro;
using IdeasApp.ViewModels;
using System;
using System.Windows;
using IdeasApp.Models;
using System.Data.SQLite;
using System.IO;

namespace IdeasApp {
    public class Startup : BootstrapperBase {
        public int SwitchView { get; set; }

        //TODO: Use Dependency Injection design pattern

        //FIXME: no static fields, move that to ViewModel
        public static SQLiteConnection ConnectionToDb;
        public static EntryRepository IdeasDataTable;

        //TODO: update class name to Startup/Bootstrapper - not Menu
        public Startup() {
            Initialize();
            var path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"IdeasDb.db"));
            ConnectionToDb = new SQLiteConnection($"Data Source = {path};Version = 3;");
            IdeasDataTable = new EntryRepository(ConnectionToDb);
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            //TODO Pass Entry Repository as parameter in DisplayRootViewFor to MainMenuViewModel constructor
            new AppShellViewModel();
            DisplayRootViewFor<AppShellViewModel>();
        }
    }
}
