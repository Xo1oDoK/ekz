using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ekz
{
    public partial class Window1 : Window
    {
        private PartnerContext _context = new PartnerContext();
        public Partner CurrentPartner { get; set; }

        public Window1(Partner partner = null)
        {
            InitializeComponent();
            CurrentPartner = partner ?? new Partner();
            DataContext = CurrentPartner;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPartner.id == 0)
                _context.Partners.Add(CurrentPartner);
            else
                _context.Partners.Update(CurrentPartner);

            _context.SaveChanges();
            DialogResult = true;
        }
    }
}
