using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1._1
{
    public class Task
    {
        public int Id { get; set; }
        public bool RelisIsClosed = false;
        public DateTime DateStart { get; set; }
        public int TimeToReliaseMinut { get; set; }
        public string NameTask { get; set; }
        //public ObservableCollection<OrderProduct> Products { get; set; } //вместо листа _ для впф _ для уведомлений впф
        //public decimal Price => Products.Sum(x => x.Product.Price * x.Quantity);
        //public decimal QuantityProducts => Products.Count();
    }
}
