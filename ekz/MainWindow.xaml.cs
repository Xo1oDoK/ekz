using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;

namespace ekz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PartnerListViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new PartnerListViewModel();
            DataContext = _viewModel;
        }

        private void AddPartner_Click(object sender, RoutedEventArgs e)
        {
            var form = new Window1();
            if (form.ShowDialog() == true)
                _viewModel.Refresh();
        }

        private void Partner_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var selected = (Partner)e.AddedItems[0];
                var form = new Window1(selected);
                if (form.ShowDialog() == true)
                    _viewModel.Refresh();
            }
        }


    }
}




