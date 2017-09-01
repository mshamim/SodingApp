using System.Diagnostics.CodeAnalysis;
using SodingApp.Models;
using SodingApp.Persistence;

namespace SodingApp.Repositories
{
    [ExcludeFromCodeCoverage] 
    public class UserTaskRepository : RepositoryBase<UserTask>, IUserTaskRepository
    {
        public UserTaskRepository(IDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}