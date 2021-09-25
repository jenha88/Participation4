using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contact> CC = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();
            var lines = File.ReadAllLines("contacts.txt").Skip(1);

            foreach (var line in lines)
            {
                CC.Add(new Contact(line)); //adding items to the list 
            }



            foreach (var cc in CC)
            {
                lstBox.Items.Add(cc);
            }


        }
        private void btbDetail_Click(object sender, RoutedEventArgs e)
        {
            Contact selectedcontact = (Contact)lstBox.SelectedItem;
            var uri = new Uri(selectedcontact.Photo);
            var img = new BitmapImage(uri);
            imgPhoto.Source = img;

            txtF.Text = selectedcontact.FirstName;
            txtL.Text = selectedcontact.LastName;
            txtE.Text = selectedcontact.Email;
        }
    }
    }

