using System.Collections.Generic;

namespace ASPNETMVCApp.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}