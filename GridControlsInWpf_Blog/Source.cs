using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Source
{
    public static AutoIndexedObservableCollection<Author> list = new AutoIndexedObservableCollection<Author>();

    static Source()
    {
        list.Add(new Author(true, "Mahesh Chand", 30, "ADO.NET Programming"));
        list.Add(new Author(true, "Mike Gold", 35, "Programming C#"));
        list.Add(new Author(false, "Raj Kumar", 25, "WPF Cookbook"));
        list.Add(new Author(false, "Tony Parker", 48, "VB.NET Coding"));
        list.Add(new Author(true, "Renee Ward", 22, "Coding Standards"));
        list.Add(new Author(false, "Praveen Kumar", 33, "Vista Development"));
    }

    public static AutoIndexedObservableCollection<Author> ItemsSource()
    {
        return list;
    }
}

public class Author : INotifyPropertyChanged, IIdentificator
{


    public Author(bool authorMVP, string authorName, Int16 authorAge, string authorBook)
    {
        this.Name = authorName;
        this.Age = authorAge;
        this.Book = authorBook;
        this.Mvp = authorMVP;
    }

    private bool mvp;
    public bool Mvp
    {
        get { return mvp; }
        set
        {
            mvp = value;
            OnPropertyChanged("Mvp");
        }
    }

    public object Id { get; set; }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private Int16 age;

    public Int16 Age
    {
        get { return age; }
        set { age = value; }
    }
    private string book;

    public string Book
    {
        get { return book; }
        set { book = value; }
    }
    

    public  event PropertyChangedEventHandler PropertyChanged;

    

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

