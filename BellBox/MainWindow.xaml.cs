using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using BellBox.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BellBox
{
    public class MainWindow : Window
    {
        public ObservableCollection<Song> SongList { get; }
        private List<Song> Songs = new List<Song>
        {
            new Song{Album = "AAA",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "BBB",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "CCC",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
            new Song{Album = "DDD",Artist="AAA",Time=325,Title="AAA"},
        };
        public MainWindow()
        {
            SongList = new ObservableCollection<Song>(Songs);
            InitializeComponent();
            #if DEBUG
            this.AttachDevTools();
            #endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        #region Window Events
        // Windows Control Button [Disabled in this Time]
        private void BtnClose_OnClick(object sender, RoutedEventArgs e) => Close();
        private void BtnMinimize_OnClick(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;
        private void BtnMaximize_OnClick(object sender, RoutedEventArgs e) =>
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;

        // Window Property Changed Event
        private void OnPropertyChanged(object sender, AvaloniaPropertyChangedEventArgs e)
        {
            //to Fix Width of DataGrid View
            if (e.Property == WidthProperty)
            {
                var dataList = this.FindControl<DataGrid>("DataList");
                dataList.Width = (double)e.NewValue - 40;
            }
        }
        #endregion
    }
}
