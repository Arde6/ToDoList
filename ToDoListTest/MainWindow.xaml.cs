using System.Collections.ObjectModel;
using System.Windows;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Tasks { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<string>();
            taskListBox.ItemsSource = Tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string task = taskTextBox.Text;
            Tasks.Add(task);
            taskTextBox.Clear();
        }
    }
}
