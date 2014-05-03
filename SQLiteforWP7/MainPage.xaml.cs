using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SQLiteforWP7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        private   void btngrabar_Click(object sender, RoutedEventArgs e)
        {
            App.db.Insert(new Persona() { nombre  = txtnombre.Text});
            MessageBox.Show("Guardado!");
        }
        private void btnlistar_Click(object sender, RoutedEventArgs e)
        {
            List<Persona> items = null;
            items = App.db.Query<Persona>("select * from Persona ");
            lista.ItemsSource = items;
        }
       

         
        private  void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            App.db.Update(new Persona() { Id = int.Parse(txtcodigo.Text), nombre = txtnombre.Text });
            MessageBox.Show("Modifico!");
        }

        private void btneliminar_Click(object sender, RoutedEventArgs e)
        {
            App.db.Delete(new Persona() { Id = int.Parse(txtcodigo.Text) });
            MessageBox.Show("Elimino!");
        }
       
    }
}