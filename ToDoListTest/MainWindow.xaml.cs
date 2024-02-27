using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.Generic;
using System.Windows;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        private ToDoList toDoList;

        public MainWindow()
        {
            InitializeComponent();
            toDoList = new ToDoList();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string task = taskTextBox.Text;
            toDoList.AddTask(task);
            taskListBox.ItemsSource = toDoList.GetTasks();
            taskTextBox.Clear();
        }
    }
}

