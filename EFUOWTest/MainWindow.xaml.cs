using System;
using System.Linq;
using System.Windows;

namespace EFUOWTest
{
    public partial class MainWindow : Window
    {
        UnitOfWork Unitofwork;

        public MainWindow()
        {
            InitializeComponent();

            Unitofwork = new UnitOfWork();

            TableGrid.ItemsSource = Unitofwork.Person.GetPeopleList().ToList();
            HobbyTableGrid.ItemsSource = Unitofwork.Hobby.GetHobbiesList().ToList();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person();
            newPerson.id = Convert.ToInt32(IDBox.Text);
            newPerson.Person_name = NameBox.Text;
            newPerson.Person_surname = SurnameBox.Text;
            newPerson.Gender = GenderBox.Text;
            Unitofwork.Person.Create(newPerson);
            Unitofwork.Save();
            TableGrid.ItemsSource = Unitofwork.Person.GetPeopleList().ToList();
            HobbyTableGrid.ItemsSource = Unitofwork.Hobby.GetHobbiesList().ToList();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            int IDToRemove = Convert.ToInt32(IDBox.Text);

            Unitofwork.Person.Delete(IDToRemove);
            Unitofwork.Hobby.DeleteHobby(IDToRemove);
            Unitofwork.Save();

            TableGrid.ItemsSource = Unitofwork.Person.GetPeopleList().ToList();
            HobbyTableGrid.ItemsSource = Unitofwork.Hobby.GetHobbiesList().ToList();
        }
    }
}


