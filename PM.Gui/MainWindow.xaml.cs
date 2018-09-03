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
            try
            {
                project.Name = textBoxProjectName.Text;
                project.Description = textBoxDescription.Text;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("You must Write a name and a Description. " + ex.Message);
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("The name and description must be within allowed parameters. " + ex.Message);
                throw;
            }
            try
            {
                model.Projects.Add(project);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("You must Write a name and a Description. " + ex.Message);
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("The name and description must be within allowed parameters. " + ex.Message);
                throw;
            }

            try
            {
                model.SaveChanges();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("You must Write a name and a Description. " + ex.Message);
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("The name and description must be within allowed parameters. " + ex.Message);
                throw;
            }
            dataGridContactInfo.ItemsSource = model.Projects.ToList();
        }
    }
}
