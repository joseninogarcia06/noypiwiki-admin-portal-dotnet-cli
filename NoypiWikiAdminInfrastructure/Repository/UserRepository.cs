using System;
using NoypiWikiAdminDomain.Interface;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminInfrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly NoypiWikiDbContext _noypiWikiDbContext;

    public UserRepository(NoypiWikiDbContext noypiWikiDbContext)
    {
        _noypiWikiDbContext = noypiWikiDbContext;
    }

    public Task Add(User user)
    {
        throw new NotImplementedException();
    }
}
