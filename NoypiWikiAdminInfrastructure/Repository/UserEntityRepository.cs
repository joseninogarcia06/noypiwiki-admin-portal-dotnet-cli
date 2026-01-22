using NoypiWikiAdminDomain.Interface;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminInfrastructure.Repository;

public class UserEntityRepository : IUserEntityRepository
{
    private readonly NoypiWikiDbContext _noypiWikiDbContext;

    public UserEntityRepository(NoypiWikiDbContext noypiWikiDbContext)
    {
        _noypiWikiDbContext = noypiWikiDbContext;
    }

    public Task Add(UserEntity user)
    {
        throw new NotImplementedException();
    }
}
