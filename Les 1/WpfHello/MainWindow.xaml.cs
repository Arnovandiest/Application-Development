using System;
using System.Collections.Generic;
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

namespace WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBoxItem item = new ComboBoxItem();
            item.Content = "Spanje ";
            cboLanden.Items.Add(item);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblBoodschap.Content = "Aangenaam " + txtName.Text + "!";
            txtName.Text = "";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            lblAkkoord.Content = "Bedankt om te bevestigen ";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            lblAkkoord.Content = "Je dient akkoord te zijn met de voorwaarden ";
        }

        private void cboLanden_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           ComboBoxItem selectie = (ComboBoxItem)cboLanden.SelectedItem;
            lblSelectie.Content = selectie.Content;
        }

        private void buttonAfbeelding_Click(object sender, RoutedEventArgs e)
        {
            imgAfbeelding.Source = new BitmapImage(new Uri("Documents/image.jpeg", UriKind.Relative));
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectie = (ListBoxItem)lsbEten.SelectedItem;
            lblBoodschappen.Content = selectie.Content;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lblGrootte.Content = "Je selecteerde een kleine pizza";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            lblGrootte.Content = "Je selecteerde een medium pizza";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            lblGrootte.Content = "Je selecteerde een grootte pizza";

        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSlider.Content = sldVolume.Value;
        }
    }
}
