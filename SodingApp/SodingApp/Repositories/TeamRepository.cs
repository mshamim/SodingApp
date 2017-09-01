using System.Diagnostics.CodeAnalysis;
using SodingApp.Models;
using SodingApp.Persistence;

namespace SodingApp.Repositories
{
    [ExcludeFromCodeCoverage]
    public class TeamRepository : RepositoryBase<Team>, ITeamRepository
    {
        public TeamRepository(IDataContext dataContext)
            : base(dataContext)
        {
        }
    }
    
}