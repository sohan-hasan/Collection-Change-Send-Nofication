using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RunObservableCollectionCode();
        }

        private static void RunObservableCollectionCode()
        {
            ObservableCollection<string> names = new ObservableCollection<string>();
            names.CollectionChanged += names_CollectionChanged;
            names.Add("Adam");
            names.Add("Eve");
            names[0] = "Sohan";
            names[0] = "Sohan";
            names.Remove("Adam");
            names.Add("John");
            names.Add("Peter");

            names.Clear();
        }

        static void names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine("Change type: " + e.Action);
            if (e.NewItems != null)
            {
                Debug.WriteLine("Items added: ");
                foreach (var item in e.NewItems)
                {
                    Debug.WriteLine(item);
                }
            }

            if (e.OldItems != null)
            {
                Debug.WriteLine("Items removed: ");
                foreach (var item in e.OldItems)
                {
                    Debug.WriteLine(item);
                }
            }
        }
    }

}
