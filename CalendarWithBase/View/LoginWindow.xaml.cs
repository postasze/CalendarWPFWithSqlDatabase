using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace CalendarWithBase.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public String NewUsername { get; set; }
        public Int32 ComboBoxSelectedIndex { get; set; }
        public String ComboBoxSelectedItem { get; set; }
        //public ComboBox existentUsernamesComboBox { get; set; }

        public LoginWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            if (ViewModel.MainWindowViewModel.getInstance().databaseContext.Users.Count() == 0)
                selectionButton.IsEnabled = false;
            else
            {
                for (int i = 0; i < ViewModel.MainWindowViewModel.getInstance().databaseContext.Users.Count(); i++)
                    existentUsernamesComboBox.Items.Add(ViewModel.MainWindowViewModel.getInstance().databaseContext.Users.AsEnumerable().ElementAt(i).username);
                existentUsernamesComboBox.SelectedIndex = 0;
            }
            NewUsername = "";
        }

        private void selectionButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.MainWindowViewModel.getInstance().username = ComboBoxSelectedItem;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void creationButton_Click(object sender, RoutedEventArgs e)
        {
            if(String.Equals(NewUsername, ""))
            {
                MessageBox.Show("New username can not be empty");
                return;
            }
            if (NewUsername.Length > 32)
            {
                MessageBox.Show("New username can not be longer than 32 letters");
                return;
            }
            if (ViewModel.MainWindowViewModel.getInstance().databaseContext.Users.Any<Users>(user => user.username == NewUsername))
            {
                MessageBox.Show("This user already exists in database");
                return;
            }

            Users newUser = new Users()
            {
                username = NewUsername
            };

            ViewModel.MainWindowViewModel.getInstance().databaseContext.Users.AddObject(newUser);
            ViewModel.MainWindowViewModel.getInstance().databaseContext.SaveChanges();
            ViewModel.MainWindowViewModel.getInstance().username = NewUsername;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
