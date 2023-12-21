using DesktopContactsApp.Models;
using SQLite;
using System;
using System.IO;
using System.Windows;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }      

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Save contact
            Contact c= new()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
            };

            

            using (SQLiteConnection connection = new(App.dbPath))
            {
                //If there is no table, create it
                connection.CreateTable<Contact>();
                //Add to table
                connection.Insert(c);
            }
            //Close Window
            Close();
        }
    }
}
