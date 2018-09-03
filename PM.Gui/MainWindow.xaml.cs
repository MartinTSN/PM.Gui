using System;
using System.Linq;
using System.Windows;
using PM.EF;

namespace PM.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProjectManagementDBEntities model = new ProjectManagementDBEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            Project project = new Project();
            project.Name = textBoxProjectName.Text;
            project.Description = textBoxDescription.Text;
            model.Projects.Add(project);
            model.SaveChanges();
            dataGridContactInfo.ItemsSource = model.Projects.ToList();
        }
    }
}
