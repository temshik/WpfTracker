using System.Windows;
using WpfTracker.Services;
using WpfTracker.ViewModels;

namespace WpfTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IFileService fileService, IDialogService dialogService)
        {
            InitializeComponent();

            DataContext = new MainViewModel(fileService, dialogService);
        }
    }
}
