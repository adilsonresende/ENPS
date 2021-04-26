using ENPS.Data;
using ENPS.Models;
using ENPS.Repos.BaseRepos;

namespace ENPS.Repositorios.COF_estadoRepos
{
    public class COF_estadoRepo : BaseRepo<COF_estado>, ICOF_estadoRepo
    {
        private readonly DataContext _dataContext;
        public COF_estadoRepo(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}