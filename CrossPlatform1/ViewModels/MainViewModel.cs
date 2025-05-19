using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CrossPlatform1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
    public ObservableCollection<Person> People { get; }
    public MainViewModel()
    {
        var people = new List<Person>
        {
            new Person("Neil", "Armstrong"),
            new Person("Buzz", "Lightyear"),
            new Person("James", "Kirk")
        };
        People = new ObservableCollection<Person>(people);
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Person(string firstName , string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
