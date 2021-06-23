using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.ExcursionRepository
{
    public class ExcursionRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ExcursionRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(ExcursionRepository Excursion)
        {
            _appDbContext.Excursions.Add(Excursion);
            _appDbContext.SaveChanges();
        }
        public void Update(Excursion Excursion)
        {
            var oldExcursion = _appDbContext.Excursion.Single(x => x.Id == Excursion.Id);
            oldExcursion.Country = excursion.Country;
        }

    }
}
