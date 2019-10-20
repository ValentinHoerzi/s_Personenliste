using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;

namespace Personenliste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Person> listPerson = new List<Person>();

        public MainWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void InitUIWithSelectedItem(Person item)
        {
            txtFirstname.Text = item.FirstName;
            txtLastname.Text = item.LastName;
            datePicker.SelectedDate = item.BirthDate;
            if (item.IsMale)
            {
                rdbMale.SetCurrentValue(CheckBox.IsCheckedProperty, true);
                rdbFemale.SetCurrentValue(CheckBox.IsCheckedProperty, false);
            }
            else
            {
                rdbMale.SetCurrentValue(CheckBox.IsCheckedProperty, false);
                rdbFemale.SetCurrentValue(CheckBox.IsCheckedProperty, true);
            }
            chDriversLicense.IsChecked = item.HasDriversLicense;
        }

        private void BtnDeleteSelection_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                var p = listBox.SelectedItems[0];
                listBox.Items.Remove(p);
                listPerson.Remove((Person)p);
            }
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var firstName = txtFirstname.Text;
            var lastName = txtLastname.Text;
            var date = datePicker.SelectedDate;
            var male = rdbMale.IsChecked ?? false;
            var hasLicense = chDriversLicense.IsChecked ?? false;

            var person = new Person(firstName, lastName, date, male, hasLicense);
            listBox.Items.Add(person);
            listPerson.Add(person);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                var person = listBox.SelectedItems[0];
                InitUIWithSelectedItem((Person)person);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "|*.csv";
            if (openFileDialog.ShowDialog() == true)
            {
                var files = File.ReadAllLines(openFileDialog.FileName);
                foreach (string f in files)
                {
                    var line = f.Split(';');

                    var firstName = line[0];
                    var lastName = line[1];
                    var date = DateTime.Parse(line[4]);
                    var male = bool.Parse(line[2]);
                    var hasLicense = bool.Parse(line[3]);

                    var person = new Person(firstName, lastName, date, male, hasLicense);
                    listBox.Items.Add(person);
                    listPerson.Add(person);
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == false) return;

            var writer = new StreamWriter(saveFileDialog.FileName);
            foreach (var item in listBox.Items)
            {
                writer.WriteLine((item as Person).AsCsvString());
            }
            writer.Flush();
            writer.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBoxSearch.Items.Clear();
            Dictionary<string, List<Person>> personDictionary = new Dictionary<string, List<Person>>();

            var firstname = rdbFirstname.IsChecked ?? false;
            var txt = txtSearch.Text;
            var temp = new List<Person>(listPerson);

            if (firstname)
            {

                foreach (Person p in listPerson)
                {
                    if (!p.FirstName.StartsWith(txt))
                        temp.Remove(p);
                }

                foreach (Person p in temp)
                {
                    if (!personDictionary.ContainsKey(p.FirstName))
                        personDictionary.Add(p.FirstName, listPerson);
                }

                foreach (string s in personDictionary.Keys)
                {
                    int countPerson = 0;
                    foreach (Person p in personDictionary[s])
                    {
                        if (s.Equals(p.FirstName))
                        {
                            countPerson++;
                        }
                    }
                    listBoxSearch.Items.Add($"{s} ({countPerson})");
                }
            }
            else
            {
                foreach (Person p in listPerson)
                {
                    if (!p.LastName.StartsWith(txt))
                        temp.Remove(p);
                }

                foreach (Person p in temp)
                {
                    if (!personDictionary.ContainsKey(p.LastName))
                        personDictionary.Add(p.LastName, listPerson);
                }

                foreach (string s in personDictionary.Keys)
                {
                    int countPerson = 0;
                    foreach (Person p in personDictionary[s])
                    {
                        if (s.Equals(p.LastName))
                        {
                            countPerson++;
                        }
                    }
                    listBoxSearch.Items.Add($"{s} ({countPerson})");
                }

            }
        }
    }
}