using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ekz
{
    public  class PartnerListViewModel
    {
        public ObservableCollection<Partner> Partners { get; set; }

        public PartnerListViewModel()
        {
            Load();
        }

        public void Refresh()
        {
            Load();
        }

        private void Load()
        {
            using (var db = new PartnerContext())
            {
                db.Database.EnsureCreated();
                Partners = new ObservableCollection<Partner>(db.Partners.Include(p => p.partner_type_id).ToList());
            }
        }
    }
}
