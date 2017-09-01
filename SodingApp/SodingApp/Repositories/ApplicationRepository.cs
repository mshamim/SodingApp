using SodingApp.Models;
using SodingApp.Persistence;
using System.Diagnostics.CodeAnalysis;

namespace SodingApp.Repositories
{
    [ExcludeFromCodeCoverage] 
    public class ApplicationRepository : RepositoryBase<Application>, IApplicationRepository
    {
        public ApplicationRepository(IDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}