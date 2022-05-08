using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
public class Source
{
static Type type = typeof(Source);
    public static AutoIndexedObservableCollection<Author> list = new AutoIndexedObservableCollection<Author>();
    static Source()
    {
        DateTime dt = new DateTime(2019, 1, 1);
        list.Add(new Author(true, "Mahesh Chand", dt, "ADO.NET Programming")); ;
        list.Add(new Author(true, "Mike Gold", DTHelperGeneral.AddDays(ref dt, 1), "Programming C#"));
        list.Add(new Author(false, "Raj Kumar", DTHelperGeneral.AddDays(ref dt, 1), "WPF Cookbook"));
        list.Add(new Author(false, "Tony Parker", DTHelperGeneral.AddDays(ref dt, 1), "VB.NET Coding"));
        list.Add(new Author(true, "Renee Ward", DTHelperGeneral.AddDays(ref dt, 1), "Coding Standards"));
        list.Add(new Author(false, "Praveen Kumar", DTHelperGeneral.AddDays(ref dt, 1), "Vista Development"));
    }
    public static void SortReceiptsByDateBorn()
    {
        // ToList() here must be - sorted still contains reference to original collection
        var sorted = list.OrderBy(d => d.DateBorn).Reverse().ToList();
        list.Clear();
        list.AddRange(sorted);
    }
    public static AutoIndexedObservableCollection<Author> ItemsSource()
    {
        return list;
    }
}
public class Author : INotifyPropertyChanged, IIdentificatorDesktop<int>
{
    public static Type type = typeof(Author);

    public Author(bool authorMVP, string authorName, DateTime dateBorn, string authorBook)
    {
        this.Name = authorName;
        this.dateBorn = dateBorn;
        this.Book = authorBook;
        this.IsChecked = authorMVP;
    }
    private bool isChecked;
    public bool IsChecked
    {
        get { return isChecked; }
        set
        {
            isChecked = value;
            OnPropertyChanged("IsChecked");
        }
    }
    public int Id { get; set; }
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private DateTime dateBorn;
    public DateTime DateBorn
    {
        get { return dateBorn; }
        set { dateBorn = value; }
    }
    private string book;
    public string Book
    {
        get { return book; }
        set { book = value; }
    }
    public bool IsSelected
    {
        get
        {
            //ThrowEx.NotImplementedMethod();
            return false;
        }
        set {  }
    }
    public Visibility Visibility { get { return Visibility.Visible; } set {  } }
    public  event PropertyChangedEventHandler PropertyChanged;
    
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}