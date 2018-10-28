using ASPNETMVCApp.Models;
using System.Collections.Generic;

namespace ASPNETMVCApp.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}